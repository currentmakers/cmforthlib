\
\ @file adc1.fs
\ @brief ADC1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC1_DEF

  [ifdef] ADC1_ADC_ISR_DEF
    \
    \ @brief ADC interrupt and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_ADRDY                     \ [0x00] ADC ready This bit is set by hardware after the ADC has been enabled (bit ADEN = 1) and when the ADC reaches a state where it is ready to accept conversion requests. It is cleared by software writing 1 to it.
    $01 constant ADC1_EOSMP                     \ [0x01] End of sampling flag This bit is set by hardware during the conversion of any channel (only for regular channels), at the end of the sampling phase.
    $02 constant ADC1_EOC                       \ [0x02] End of conversion flag This bit is set by hardware at the end of each regular conversion of a channel when a new data is available in the ADC_DR register. It is cleared by software writing 1 to it or by reading the ADC_DR register
    $03 constant ADC1_EOS                       \ [0x03] End of regular sequence flag This bit is set by hardware at the end of the conversions of a regular sequence of channels. It is cleared by software writing 1 to it.
    $04 constant ADC1_OVR                       \ [0x04] ADC overrun This bit is set by hardware when an overrun occurs on a regular channel, meaning that a new conversion has completed while the EOC flag was already set. It is cleared by software writing 1 to it.
    $05 constant ADC1_JEOC                      \ [0x05] Injected channel end of conversion flag This bit is set by hardware at the end of each injected conversion of a channel when a new data is available in the corresponding ADC_JDRy register. It is cleared by software writing 1 to it or by reading the corresponding ADC_JDRy register
    $06 constant ADC1_JEOS                      \ [0x06] Injected channel end of sequence flag This bit is set by hardware at the end of the conversions of all injected channels in the group. It is cleared by software writing 1 to it.
    $07 constant ADC1_AWD1                      \ [0x07] Analog watchdog 1 flag This bit is set by hardware when the converted voltage crosses the values programmed in the fields LT1[11:0] and HT1[11:0] of ADC_LTR1, & ADC_HTR1 register. It is cleared by software. writing 1 to it.
    $08 constant ADC1_AWD2                      \ [0x08] Analog watchdog 2 flag This bit is set by hardware when the converted voltage crosses the values programmed in the fields LT2[7:0] and HT2[7:0] of ADC_LTR2 & ADC_HTR2 register. It is cleared by software writing 1 to it.
    $09 constant ADC1_AWD3                      \ [0x09] Analog watchdog 3 flag This bit is set by hardware when the converted voltage crosses the values programmed in the fields LT3[7:0] and HT3[7:0] of ADC_LTR3 & ADC_HTR3 register. It is cleared by software writing 1 to it.
    $0c constant ADC1_LDORDY                    \ [0x0c] ADC voltage regulator ready This bit is set by hardware. It indicates that the ADC internal supply is ready. The ADC is available after tADCVREG_SETUP time.
  [then]


  [ifdef] ADC1_ADC_IER_DEF
    \
    \ @brief ADC interrupt enable register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_ADRDYIE                   \ [0x00] ADC ready interrupt enable This bit is set and cleared by software to enable/disable the ADC Ready interrupt. Note: Software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $01 constant ADC1_EOSMPIE                   \ [0x01] End of sampling flag interrupt enable for regular conversions This bit is set and cleared by software to enable/disable the end of the sampling phase interrupt for regular conversions. Note: Software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $02 constant ADC1_EOCIE                     \ [0x02] End of regular conversion interrupt enable This bit is set and cleared by software to enable/disable the end of a regular conversion interrupt. Note: Software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $03 constant ADC1_EOSIE                     \ [0x03] End of regular sequence of conversions interrupt enable This bit is set and cleared by software to enable/disable the end of regular sequence of conversions interrupt. Note: Software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $04 constant ADC1_OVRIE                     \ [0x04] Overrun interrupt enable This bit is set and cleared by software to enable/disable the Overrun interrupt of a regular conversion. Note: Software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $05 constant ADC1_JEOCIE                    \ [0x05] End of injected conversion interrupt enable This bit is set and cleared by software to enable/disable the end of an injected conversion interrupt. Note: Software is allowed to write this bit only when JADSTART = 0 (which ensures that no regular conversion is ongoing).
    $06 constant ADC1_JEOSIE                    \ [0x06] End of injected sequence of conversions interrupt enable This bit is set and cleared by software to enable/disable the end of injected sequence of conversions interrupt. Note: Software is allowed to write this bit only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
    $07 constant ADC1_AWD1IE                    \ [0x07] Analog watchdog 1 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog 1 interrupt. Note: Software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $08 constant ADC1_AWD2IE                    \ [0x08] Analog watchdog 2 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog 2 interrupt. Note: Software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $09 constant ADC1_AWD3IE                    \ [0x09] Analog watchdog 3 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog 2 interrupt. Note: Software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC1_ADC_CR_DEF
    \
    \ @brief ADC control register
    \ Address offset: 0x08
    \ Reset value: 0x20000000
    \
    $00 constant ADC1_ADEN                      \ [0x00] ADC enable control This bit is set by software to enable the ADC. The ADC is effectively ready to operate once the flag ADRDY has been set. It is cleared by hardware when the ADC is disabled, after the execution of the ADDIS command. Note: The software is allowed to set ADEN only when all bits of ADC_CR registers are 0 (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0) except for bit ADVREGEN which must be 1 (and the software must have wait for the startup time of the voltage regulator)
    $01 constant ADC1_ADDIS                     \ [0x01] ADC disable command This bit is set by software to disable the ADC (ADDIS command) and put it into power-down state (OFF state). It is cleared by hardware once the ADC is effectively disabled (ADEN is also cleared by hardware at this time). Note: The software is allowed to set ADDIS only when ADEN = 1 and both ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing)
    $02 constant ADC1_ADSTART                   \ [0x02] ADC start of regular conversion This bit is set by software to start ADC conversion of regular channels. Depending on the configuration bits EXTEN[1:0], a conversion starts immediately (software trigger configuration) or once a regular hardware trigger event occurs (hardware trigger configuration). It is cleared by hardware:  in Single conversion mode (CONT = 0, DISCEN = 0) when software trigger is selected (EXTEN[1:0] = 0x0): at the assertion of the end of regular conversion sequence (EOS) flag. In Discontinuous conversion mode (CONT = 0, DISCEN = 1), when the software trigger is selected (EXTEN[1:0] = 0x0): at the end of conversion (EOC) flag. in all other cases: after the execution of the ADSTP command, at the same time that ADSTP is cleared by hardware. Note: The software is allowed to set ADSTART only when ADEN = 1 and ADDIS = 0 (ADC is enabled and there is no pending request to disable the ADC) In Auto-injection mode (JAUTO = 1), regular and auto-injected conversions are started by setting bit ADSTART (JADSTART must be kept cleared)
    $03 constant ADC1_JADSTART                  \ [0x03] ADC start of injected conversion This bit is set by software to start ADC conversion of injected channels. Depending on the configuration bits JEXTEN[1:0], a conversion starts immediately (software trigger configuration) or once an injected hardware trigger event occurs (hardware trigger configuration). It is cleared by hardware: in Single conversion mode when software trigger is selected (JEXTSEL = 0x0): at the assertion of the end of injected conversion sequence (JEOS) flag. in all cases: after the execution of the JADSTP command, at the same time as JADSTP is cleared by hardware. Note: The software is allowed to set JADSTART only when ADEN = 1 and ADDIS = 0 (ADC is enabled and there is no pending request to disable the ADC). In Auto-injection mode (JAUTO = 1), regular and auto-injected conversions are started by setting bit ADSTART (JADSTART must be kept cleared)
    $04 constant ADC1_ADSTP                     \ [0x04] ADC stop of regular conversion command This bit is set by software to stop and discard an ongoing regular conversion (ADSTP Command). It is cleared by hardware when the conversion is effectively discarded and the ADC regular sequence and triggers can be re-configured. The ADC is then ready to accept a new start of regular conversions (ADSTART command). Note: The software is allowed to set ADSTP only when ADSTART = 1 and ADDIS = 0 (ADC is enabled and eventually converting a regular conversion and there is no pending request to disable the ADC). In Auto-injection mode (JAUTO = 1), setting ADSTP bit aborts both regular and injected conversions (do not use JADSTP).
    $05 constant ADC1_JADSTP                    \ [0x05] ADC stop of injected conversion command This bit is set by software to stop and discard an ongoing injected conversion (JADSTP Command). It is cleared by hardware when the conversion is effectively discarded and the ADC injected sequence and triggers can be re-configured. The ADC is then ready to accept a new start of injected conversions (JADSTART command). Note: The software is allowed to set JADSTP only when JADSTART = 1 and ADDIS = 0 (ADC is enabled and eventually converting an injected conversion and there is no pending request to disable the ADC). In Auto-injection mode (JAUTO = 1), setting ADSTP bit aborts both regular and injected conversions (do not use JADSTP)
    $10 constant ADC1_ADCALLIN                  \ [0x10] Linearity calibration This bit is set and cleared by software to enable the linearity calibration. Note: The software is allowed to write this bit only when the ADC is disabled and is not calibrating (ADCAL = 0, JADSTART = 0, JADSTP = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
    $18 constant ADC1_CALINDEX                  \ [0x18 : 4] Calibration factor This bitfield controls the calibration factor to be read or written. Calibration index 0 is dedicated to single-ended and differential offsets, calibration index 1 to 7 to the linearity calibration factors, and index 8 to the internal offset: Others: Reserved, must not be used Note: ADC_CALFACT2[31:0] correspond to the location of CALINDEX[3:0] calibration factor data (see for details).
    $1c constant ADC1_ADVREGEN                  \ [0x1c] ADC voltage regulator enable This bits is set by software to enable the ADC voltage regulator. Before performing any operation such as launching a calibration or enabling the ADC, the ADC voltage regulator must first be enabled and the software must wait for the regulator start-up time. For more details about the ADC voltage regulator enable and disable sequences, refer to (ADVREGEN). The software can program this bit field only when the ADC is disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
    $1d constant ADC1_DEEPPWD                   \ [0x1d] Deep-power-down enable This bit is set and cleared by software to put the ADC in Deep-power-down mode. Note: The software is allowed to write this bit only when the ADC is disabled (ADCAL = 0, JADSTART = 0, JADSTP = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
    $1f constant ADC1_ADCAL                     \ [0x1f] ADC calibration This bit is set by software to start the ADC calibration. It is cleared by hardware after calibration is complete. Note: The software is allowed to launch a calibration by setting ADCAL only when ADEN = 0.
  [then]


  [ifdef] ADC1_ADC_CFGR1_DEF
    \
    \ @brief ADC configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x80000000
    \
    $00 constant ADC1_DMNGT                     \ [0x00 : 2] Data management configuration This bit is set and cleared by software to select how the ADC interface output data are managed. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $02 constant ADC1_RES                       \ [0x02 : 2] Data resolution These bits are written by software to select the resolution of the conversion. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $05 constant ADC1_EXTSEL                    \ [0x05 : 5] External trigger selection for regular group These bits select the external event used to trigger the start of conversion of a regular group: ... Refer to the ADC external trigger for regular channels in signals for details on trigger mapping. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $0a constant ADC1_EXTEN                     \ [0x0a : 2] External trigger enable and polarity selection for regular channels These bits are set and cleared by software to select the external trigger polarity and enable the trigger of a regular group. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $0c constant ADC1_OVRMOD                    \ [0x0c] Overrun Mode This bit is set and cleared by software and configure the way data overrun is managed. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $0d constant ADC1_CONT                      \ [0x0d] Single / continuous conversion mode for regular conversions This bit is set and cleared by software. If it is set, regular conversion takes place continuously until it is cleared. Note: It is not possible to have both discontinuous mode and continuous mode enabled: it is forbidden to set both DISCEN = 1 and CONT = 1. The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $0e constant ADC1_AUTDLY                    \ [0x0e] Delayed conversion mode This bit is set and cleared by software to enable/disable the Auto Delayed Conversion mode.. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $10 constant ADC1_DISCEN                    \ [0x10] Discontinuous mode for regular channels This bit is set and cleared by software to enable/disable Discontinuous mode for regular channels. Note: It is not possible to have both discontinuous mode and continuous mode enabled: it is forbidden to set both DISCEN = 1 and CONT = 1. It is not possible to use both auto-injected mode and discontinuous mode simultaneously: the bits DISCEN and JDISCEN must be kept cleared by software when JAUTO is set. The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $11 constant ADC1_DISCNUM                   \ [0x11 : 3] Discontinuous mode channel count These bits are written by software to define the number of regular channels to be converted in discontinuous mode, after receiving an external trigger. ... Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $14 constant ADC1_JDISCEN                   \ [0x14] Discontinuous mode on injected channels This bit is set and cleared by software to enable/disable discontinuous mode on the injected channels of a group. Note: The software is allowed to write this bit only when JADSTART = 0 (which ensures that no injected conversion is ongoing). It is not possible to use both auto-injected mode and discontinuous mode simultaneously: the bits DISCEN and JDISCEN must be kept cleared by software when JAUTO is set.
    $16 constant ADC1_AWD1SGL                   \ [0x16] Enable the watchdog 1 on a single channel or on all channels This bit is set and cleared by software to enable the analog watchdog on the channel identified by the AWD1CH[4:0] bits or on all the channels Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $17 constant ADC1_AWD1EN                    \ [0x17] Analog watchdog 1 enable on regular channels This bit is set and cleared by software Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $18 constant ADC1_JAWD1EN                   \ [0x18] Analog watchdog 1 enable on injected channels This bit is set and cleared by software Note: The software is allowed to write this bit only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
    $19 constant ADC1_JAUTO                     \ [0x19] Automatic injected group conversion This bit is set and cleared by software to enable/disable automatic injected group conversion after regular group conversion. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no regular nor injected conversion is ongoing).
    $1a constant ADC1_AWD1CH                    \ [0x1a : 5] Analog watchdog 1 channel selection These bits are set and cleared by software. They select the input channel to be guarded by the analog watchdog. ..... Others: Reserved, must not be used Note: The channel selected by AWD1CH must be also selected into the SQRi or JSQRi registers. Software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC1_ADC_CFGR2_DEF
    \
    \ @brief ADC configuration register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_ROVSE                     \ [0x00] Regular Oversampling Enable This bit is set and cleared by software to enable regular oversampling. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing)
    $01 constant ADC1_JOVSE                     \ [0x01] Injected Oversampling Enable This bit is set and cleared by software to enable injected oversampling. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing)
    $05 constant ADC1_OVSS                      \ [0x05 : 4] Oversampling right shift This bit field is set and cleared by software to define the right shifting applied to the raw oversampling result. Others: Reserved, must not be used. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no conversion is ongoing).
    $09 constant ADC1_TROVS                     \ [0x09] Triggered Regular Oversampling This bit is set and cleared by software to enable triggered oversampling Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
    $0a constant ADC1_ROVSM                     \ [0x0a] Regular Oversampling mode This bit is set and cleared by software to select the regular oversampling mode. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
    $0d constant ADC1_BULB                      \ [0x0d] Bulb sampling mode This bit is set and cleared by software to select the bulb sampling mode. SMPTRIG bit must not be set when the BULB bit is set. The very first ADC conversion is performed with the sampling time specified in SMPx bits. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
    $0e constant ADC1_SWTRIG                    \ [0x0e] Software trigger bit for sampling time control trigger mode This bit is set and cleared by software to enable the bulb sampling mode. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
    $0f constant ADC1_SMPTRIG                   \ [0x0f] Sampling time control trigger mode This bit is set and cleared by software to enable the sampling time control trigger mode. The sampling time starts on the trigger rising edge, and the conversion on the trigger falling edge. EXTEN[1:0] bits must be set to 01. BULB bit must not be set when the SMPTRIG bit is set. When EXTEN[1:0] bits is set to 00, set SWTRIG to start the sampling and clear SWTRIG bit to start the conversion. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
    $10 constant ADC1_OSR                       \ [0x10 : 10] Oversampling ratio This bitfield is set and cleared by software to define the oversampling ratio. 2: 3x ... 1023: 1024x Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
    $1b constant ADC1_LFTRIG                    \ [0x1b] Low-frequency trigger This bit is set and cleared by software Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
    $1c constant ADC1_LSHIFT                    \ [0x1c : 4] Left shift factor This bitfield is set and cleared by software to define the left shifting applied to the final result with or without oversampling. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC1_ADC_SMPR1_DEF
    \
    \ @brief ADC sample time register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_SMP0                      \ [0x00 : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $03 constant ADC1_SMP1                      \ [0x03 : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $06 constant ADC1_SMP2                      \ [0x06 : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $09 constant ADC1_SMP3                      \ [0x09 : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $0c constant ADC1_SMP4                      \ [0x0c : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $0f constant ADC1_SMP5                      \ [0x0f : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $12 constant ADC1_SMP6                      \ [0x12 : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $15 constant ADC1_SMP7                      \ [0x15 : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $18 constant ADC1_SMP8                      \ [0x18 : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $1b constant ADC1_SMP9                      \ [0x1b : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC1_ADC_SMPR2_DEF
    \
    \ @brief ADC sample time register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_SMP10                     \ [0x00 : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $03 constant ADC1_SMP11                     \ [0x03 : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $06 constant ADC1_SMP12                     \ [0x06 : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $09 constant ADC1_SMP13                     \ [0x09 : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $0c constant ADC1_SMP14                     \ [0x0c : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $0f constant ADC1_SMP15                     \ [0x0f : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $12 constant ADC1_SMP16                     \ [0x12 : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $15 constant ADC1_SMP17                     \ [0x15 : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $18 constant ADC1_SMP18                     \ [0x18 : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $1b constant ADC1_SMP19                     \ [0x1b : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC1_ADC_PCSEL_DEF
    \
    \ @brief ADC channel preselection register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_PCSEL0                    \ [0x00] Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $01 constant ADC1_PCSEL1                    \ [0x01] Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $02 constant ADC1_PCSEL2                    \ [0x02] Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $03 constant ADC1_PCSEL3                    \ [0x03] Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $04 constant ADC1_PCSEL4                    \ [0x04] Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $05 constant ADC1_PCSEL5                    \ [0x05] Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $06 constant ADC1_PCSEL6                    \ [0x06] Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $07 constant ADC1_PCSEL7                    \ [0x07] Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $08 constant ADC1_PCSEL8                    \ [0x08] Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $09 constant ADC1_PCSEL9                    \ [0x09] Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $0a constant ADC1_PCSEL10                   \ [0x0a] Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $0b constant ADC1_PCSEL11                   \ [0x0b] Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $0c constant ADC1_PCSEL12                   \ [0x0c] Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $0d constant ADC1_PCSEL13                   \ [0x0d] Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $0e constant ADC1_PCSEL14                   \ [0x0e] Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $0f constant ADC1_PCSEL15                   \ [0x0f] Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $10 constant ADC1_PCSEL16                   \ [0x10] Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $11 constant ADC1_PCSEL17                   \ [0x11] Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $12 constant ADC1_PCSEL18                   \ [0x12] Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $13 constant ADC1_PCSEL19                   \ [0x13] Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC1_ADC_SQR1_DEF
    \
    \ @brief ADC regular sequence register 1
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_L                         \ [0x00 : 4] Regular channel sequence length These bits are written by software to define the total number of conversions in the regular channel conversion sequence. ... Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $06 constant ADC1_SQ1                       \ [0x06 : 5] 1st conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 1st in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $0c constant ADC1_SQ2                       \ [0x0c : 5] 2nd conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 2nd in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $12 constant ADC1_SQ3                       \ [0x12 : 5] 3rd conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 3rd in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $18 constant ADC1_SQ4                       \ [0x18 : 5] 4th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 4th in the regular conversion sequence.
  [then]


  [ifdef] ADC1_ADC_SQR2_DEF
    \
    \ @brief ADC regular sequence register 2
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_SQ5                       \ [0x00 : 5] 5th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 5th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $06 constant ADC1_SQ6                       \ [0x06 : 5] 6th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 6th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $0c constant ADC1_SQ7                       \ [0x0c : 5] 7th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 7th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $12 constant ADC1_SQ8                       \ [0x12 : 5] 8th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 8th in the regular conversion sequence Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $18 constant ADC1_SQ9                       \ [0x18 : 5] 9th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 9th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
  [then]


  [ifdef] ADC1_ADC_SQR3_DEF
    \
    \ @brief ADC regular sequence register 3
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_SQ10                      \ [0x00 : 5] 10th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 10th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $06 constant ADC1_SQ11                      \ [0x06 : 5] 11th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 11th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $0c constant ADC1_SQ12                      \ [0x0c : 5] 12th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 12th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $12 constant ADC1_SQ13                      \ [0x12 : 5] 13th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 13th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $18 constant ADC1_SQ14                      \ [0x18 : 5] 14th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 14th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
  [then]


  [ifdef] ADC1_ADC_SQR4_DEF
    \
    \ @brief ADC regular sequence register 4
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_SQ15                      \ [0x00 : 5] 15th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 15th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $06 constant ADC1_SQ16                      \ [0x06 : 5] 16th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 16th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
  [then]


  [ifdef] ADC1_ADC_DR_DEF
    \
    \ @brief ADC regular Data Register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_RDATA                     \ [0x00 : 32] Regular data converted These bits are read-only. They contain the conversion result from the last converted regular channel. The data are left- or right-aligned as described in .
  [then]


  [ifdef] ADC1_ADC_JSQR_DEF
    \
    \ @brief ADC injected sequence register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_JL                        \ [0x00 : 2] Injected channel sequence length These bits are written by software to define the total number of conversions in the injected channel conversion sequence. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing.
    $02 constant ADC1_JEXTSEL                   \ [0x02 : 5] External trigger selection for injected group These bits select the external event used to trigger the start of conversion of an injected group: ... Refer to the ADC external trigger for injected channels in internal signals for details on trigger mapping. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing.
    $07 constant ADC1_JEXTEN                    \ [0x07 : 2] External trigger enable and polarity selection for injected channels These bits are set and cleared by software to select the external trigger polarity and enable the trigger of an injected group. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing.
    $09 constant ADC1_JSQ1                      \ [0x09 : 5] 1st conversion in the injected sequence These bits are written by software with the channel number (0..19) assigned as the 1st in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing.
    $0f constant ADC1_JSQ2                      \ [0x0f : 5] 2nd conversion in the injected sequence These bits are written by software with the channel number (0..19) assigned as the 2nd in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing.
    $15 constant ADC1_JSQ3                      \ [0x15 : 5] 3rd conversion in the injected sequence These bits are written by software with the channel number (0..19) assigned as the 3rd in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing.
    $1b constant ADC1_JSQ4                      \ [0x1b : 5] 4th conversion in the injected sequence These bits are written by software with the channel number (0..19) assigned as the 4th in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing.
  [then]


  [ifdef] ADC1_ADC_OFR1_DEF
    \
    \ @brief ADC offset register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_OFFSET                    \ [0x00 : 24] Data offset y for the channel programmed into OFFSETy_CH[4:0] bits These bits are written by software to define the offset y to be subtracted from the raw converted data when converting a channel (regular or injected). The channel to which the data offset y applies must be programmed to the OFFSETy_CH[4:0] bits. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). When OFFSETy[21:0] bitfield is reset, the offset compensation is disabled. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If several offsets (OFFSETy) point to the same channel, only the offset with the lowest y value is considered for the subtraction. For example, if OFFSET1_CH[4:0] = 4 and OFFSET2_CH[4:0] = 4, this is OFFSET1[25:0] that is subtracted when converting channel 4.
    $18 constant ADC1_POSOFF                    \ [0x18] offset sign This bit is set and cleared by software to enable the positive offset. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $19 constant ADC1_USAT                      \ [0x19] Unsigned saturation enable This bit is written by software to enable or disable the unsigned saturation feature. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $1a constant ADC1_SSAT                      \ [0x1a] Signed saturation enable This bit is written by software to enable or disable the Signed saturation feature. (see OFFSETy_CH, OVSS, LSHIFT, USAT, SSAT) for details). Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $1b constant ADC1_OFFSET_CH                 \ [0x1b : 5] Channel selection for the data offset y These bits are written by software to define the channel to which the offset programmed into OFFSETy[25:0] bits applies. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If OFFSETy_EN bit is set, it is not allowed to select the same channel in different ADC_OFRy registers.
  [then]


  [ifdef] ADC1_ADC_OFR2_DEF
    \
    \ @brief ADC offset register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_OFFSET                    \ [0x00 : 24] Data offset y for the channel programmed into OFFSETy_CH[4:0] bits These bits are written by software to define the offset y to be subtracted from the raw converted data when converting a channel (regular or injected). The channel to which the data offset y applies must be programmed to the OFFSETy_CH[4:0] bits. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). When OFFSETy[21:0] bitfield is reset, the offset compensation is disabled. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If several offsets (OFFSETy) point to the same channel, only the offset with the lowest y value is considered for the subtraction. For example, if OFFSET1_CH[4:0] = 4 and OFFSET2_CH[4:0] = 4, this is OFFSET1[25:0] that is subtracted when converting channel 4.
    $18 constant ADC1_POSOFF                    \ [0x18] offset sign This bit is set and cleared by software to enable the positive offset. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $19 constant ADC1_USAT                      \ [0x19] Unsigned saturation enable This bit is written by software to enable or disable the unsigned saturation feature. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $1a constant ADC1_SSAT                      \ [0x1a] Signed saturation enable This bit is written by software to enable or disable the Signed saturation feature. (see OFFSETy_CH, OVSS, LSHIFT, USAT, SSAT) for details). Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $1b constant ADC1_OFFSET_CH                 \ [0x1b : 5] Channel selection for the data offset y These bits are written by software to define the channel to which the offset programmed into OFFSETy[25:0] bits applies. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If OFFSETy_EN bit is set, it is not allowed to select the same channel in different ADC_OFRy registers.
  [then]


  [ifdef] ADC1_ADC_OFR3_DEF
    \
    \ @brief ADC offset register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_OFFSET                    \ [0x00 : 24] Data offset y for the channel programmed into OFFSETy_CH[4:0] bits These bits are written by software to define the offset y to be subtracted from the raw converted data when converting a channel (regular or injected). The channel to which the data offset y applies must be programmed to the OFFSETy_CH[4:0] bits. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). When OFFSETy[21:0] bitfield is reset, the offset compensation is disabled. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If several offsets (OFFSETy) point to the same channel, only the offset with the lowest y value is considered for the subtraction. For example, if OFFSET1_CH[4:0] = 4 and OFFSET2_CH[4:0] = 4, this is OFFSET1[25:0] that is subtracted when converting channel 4.
    $18 constant ADC1_POSOFF                    \ [0x18] offset sign This bit is set and cleared by software to enable the positive offset. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $19 constant ADC1_USAT                      \ [0x19] Unsigned saturation enable This bit is written by software to enable or disable the unsigned saturation feature. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $1a constant ADC1_SSAT                      \ [0x1a] Signed saturation enable This bit is written by software to enable or disable the Signed saturation feature. (see OFFSETy_CH, OVSS, LSHIFT, USAT, SSAT) for details). Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $1b constant ADC1_OFFSET_CH                 \ [0x1b : 5] Channel selection for the data offset y These bits are written by software to define the channel to which the offset programmed into OFFSETy[25:0] bits applies. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If OFFSETy_EN bit is set, it is not allowed to select the same channel in different ADC_OFRy registers.
  [then]


  [ifdef] ADC1_ADC_OFR4_DEF
    \
    \ @brief ADC offset register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_OFFSET                    \ [0x00 : 24] Data offset y for the channel programmed into OFFSETy_CH[4:0] bits These bits are written by software to define the offset y to be subtracted from the raw converted data when converting a channel (regular or injected). The channel to which the data offset y applies must be programmed to the OFFSETy_CH[4:0] bits. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). When OFFSETy[21:0] bitfield is reset, the offset compensation is disabled. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If several offsets (OFFSETy) point to the same channel, only the offset with the lowest y value is considered for the subtraction. For example, if OFFSET1_CH[4:0] = 4 and OFFSET2_CH[4:0] = 4, this is OFFSET1[25:0] that is subtracted when converting channel 4.
    $18 constant ADC1_POSOFF                    \ [0x18] offset sign This bit is set and cleared by software to enable the positive offset. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $19 constant ADC1_USAT                      \ [0x19] Unsigned saturation enable This bit is written by software to enable or disable the unsigned saturation feature. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $1a constant ADC1_SSAT                      \ [0x1a] Signed saturation enable This bit is written by software to enable or disable the Signed saturation feature. (see OFFSETy_CH, OVSS, LSHIFT, USAT, SSAT) for details). Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $1b constant ADC1_OFFSET_CH                 \ [0x1b : 5] Channel selection for the data offset y These bits are written by software to define the channel to which the offset programmed into OFFSETy[25:0] bits applies. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If OFFSETy_EN bit is set, it is not allowed to select the same channel in different ADC_OFRy registers.
  [then]


  [ifdef] ADC1_ADC_GCOMP_DEF
    \
    \ @brief ADC gain compensation register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_GCOMPCOEFF                \ [0x00 : 14] Gain compensation coefficient These bits are set and cleared by software to program the gain compensation coefficient. ... ... The coefficient is divided by 4096 to get the gain factor ranging from 0 to 3.999756. Note: This gain compensation is only applied when GCOMP bit of ADCx_CFGR2 register is 1.
    $1f constant ADC1_GCOMP                     \ [0x1f] Gain compensation mode This bit is set and cleared by software to enable the gain compensation mode. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC1_ADC_JDR1_DEF
    \
    \ @brief ADC injected data register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_JDATA                     \ [0x00 : 32] Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in .
  [then]


  [ifdef] ADC1_ADC_JDR2_DEF
    \
    \ @brief ADC injected data register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_JDATA                     \ [0x00 : 32] Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in .
  [then]


  [ifdef] ADC1_ADC_JDR3_DEF
    \
    \ @brief ADC injected data register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_JDATA                     \ [0x00 : 32] Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in .
  [then]


  [ifdef] ADC1_ADC_JDR4_DEF
    \
    \ @brief ADC injected data register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_JDATA                     \ [0x00 : 32] Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in .
  [then]


  [ifdef] ADC1_ADC_AWD2CR_DEF
    \
    \ @brief ADC analog watchdog 2 configuration register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_AWD2CH                    \ [0x00 : 20] Analog watchdog 2 channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by the analog watchdog 2. AWD2CH[i] = 0: ADC analog input channel-i is not monitored by AWD2 AWD2CH[i] = 1: ADC analog input channel-i is monitored by AWD2 When AWD2CH[19:0] = 000..0, the analog Watchdog 2 is disabled Note: The channels selected by AWD2CH must be also selected into the SQRi or JSQRi registers. Software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC1_ADC_AWD3CR_DEF
    \
    \ @brief ADC analog watchdog 3 configuration register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_AWD3CH                    \ [0x00 : 20] Analog watchdog 3 channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by the analog watchdog 3. AWD3CH[i] = 0: ADC analog input channel-i is not monitored by AWD3 AWD3CH[i] = 1: ADC analog input channel-i is monitored by AWD3 When AWD3CH[19:0] = 000..0, the analog Watchdog 3 is disabled Note: The channels selected by AWD3CH must be also selected into the SQRi or JSQRi registers. The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC1_ADC_LTR1_DEF
    \
    \ @brief ADC watchdog threshold register 1
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_LTR1                      \ [0x00 : 25] Analog watchdog 1 lower threshold These bits are written by software to define the lower threshold for the analog watchdog 1. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy).
  [then]


  [ifdef] ADC1_ADC_HTR1_DEF
    \
    \ @brief ADC watchdog threshold register 1
    \ Address offset: 0xAC
    \ Reset value: 0x01FFFFFF
    \
    $00 constant ADC1_HTR1                      \ [0x00 : 25] Analog watchdog 1 higher threshold These bits are written by software to define the higher threshold for the analog watchdog 1. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy).
    $1d constant ADC1_AWDFILT1                  \ [0x1d : 3] Analog watchdog filtering parameter This bit is set and cleared by software. ... Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC1_ADC_LTR2_DEF
    \
    \ @brief ADC watchdog lower threshold register 2
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_LTR2                      \ [0x00 : 25] Analog watchdog 2 lower threshold These bits are written by software to define the lower threshold for the analog watchdog 2. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy).
  [then]


  [ifdef] ADC1_ADC_HTR2_DEF
    \
    \ @brief ADC watchdog higher threshold register 2
    \ Address offset: 0xB4
    \ Reset value: 0x01FFFFFF
    \
    $00 constant ADC1_HTR2                      \ [0x00 : 25] Analog watchdog 2 higher threshold These bits are written by software to define the higher threshold for the analog watchdog 2. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy).
  [then]


  [ifdef] ADC1_ADC_LTR3_DEF
    \
    \ @brief ADC watchdog lower threshold register 3
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_LTR3                      \ [0x00 : 25] Analog watchdog 3 lower threshold These bits are written by software to define the lower threshold for the analog watchdog 3. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy).
  [then]


  [ifdef] ADC1_ADC_HTR3_DEF
    \
    \ @brief ADC watchdog higher threshold register 3
    \ Address offset: 0xBC
    \ Reset value: 0x01FFFFFF
    \
    $00 constant ADC1_HTR3                      \ [0x00 : 25] Analog watchdog 3 higher threshold These bits are written by software to define the higher threshold for the analog watchdog 3. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy).
  [then]


  [ifdef] ADC1_ADC_DIFSEL_DEF
    \
    \ @brief ADC differential mode selection register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_DIFSEL                    \ [0x00 : 20] Differential mode for channels 19 to 0 These bits are set and cleared by software. They allow selecting if a channel is configured as single ended or differential mode. DIFSEL[i] = 0: ADC analog input channel-i is configured in single ended mode DIFSEL[i] = 1: ADC analog input channel-i is configured in differential mode Note: The software is allowed to write these bits only when the ADC is disabled (ADCAL = 0, JADSTART = 0, JADSTP = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
  [then]


  [ifdef] ADC1_ADC_CALFACT_DEF
    \
    \ @brief ADC user control register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_I_APB_ADDR                \ [0x00 : 8] Delayed write access address This bitfield contains the address that is being written during delayed write accesses.
    $08 constant ADC1_I_APB_DATA                \ [0x08 : 8] Delayed write access data This bitfield contains the data that are being written during delayed write accesses.
    $10 constant ADC1_VALIDITY                  \ [0x10] Delayed write access status bit This bit indicates the communication status between the ADC digital and analog blocks.
    $18 constant ADC1_LATCH_COEF                \ [0x18] Calibration factor latch enable bit This bit latches the calibration factor in the CALFACT[31:0] bits.
    $19 constant ADC1_CAPTURE_COEF              \ [0x19] Calibration factor capture enable bit This bit enables the internal calibration factor capture.
  [then]


  [ifdef] ADC1_ADC_CALFACT2_DEF
    \
    \ @brief ADC calibration factor register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_CALFACT                   \ [0x00 : 32] Linearity or offset calibration factor These bits can be written either by hardware or by software. They contain the 32-bit offset or linearity calibration factor. When CAPTURE_COEF is set to 1, the calibration factor of the analog block is read back and stored in CALFACT[31:0], indexed by CALINDEX[3:0] bits. When LATCH_COEF is set to 1, the calibration factor of the analog block is updated with the value programmed in CALFACT[31:0], indexed by CALINDEX[3:0] bits. To read all calibration factors, perform nine accesses to the ADC_CALFACT2 register. To write all calibration factors, perform eight accesses to the ADC_CALFACT2 register. Note: The software is allowed to write these bits only when ADEN = 1, ADSTART = 0 and JADSTART = 0 (ADC is enabled and no calibration is ongoing and no conversion is ongoing).
  [then]

  \
  \ @brief ADC1
  \
  $00 constant ADC1_ADC_ISR             \ ADC interrupt and status register
  $04 constant ADC1_ADC_IER             \ ADC interrupt enable register
  $08 constant ADC1_ADC_CR              \ ADC control register
  $0C constant ADC1_ADC_CFGR1           \ ADC configuration register
  $10 constant ADC1_ADC_CFGR2           \ ADC configuration register 2
  $14 constant ADC1_ADC_SMPR1           \ ADC sample time register 1
  $18 constant ADC1_ADC_SMPR2           \ ADC sample time register 2
  $1C constant ADC1_ADC_PCSEL           \ ADC channel preselection register
  $30 constant ADC1_ADC_SQR1            \ ADC regular sequence register 1
  $34 constant ADC1_ADC_SQR2            \ ADC regular sequence register 2
  $38 constant ADC1_ADC_SQR3            \ ADC regular sequence register 3
  $3C constant ADC1_ADC_SQR4            \ ADC regular sequence register 4
  $40 constant ADC1_ADC_DR              \ ADC regular Data Register
  $4C constant ADC1_ADC_JSQR            \ ADC injected sequence register
  $60 constant ADC1_ADC_OFR1            \ ADC offset register
  $64 constant ADC1_ADC_OFR2            \ ADC offset register
  $68 constant ADC1_ADC_OFR3            \ ADC offset register
  $6C constant ADC1_ADC_OFR4            \ ADC offset register
  $70 constant ADC1_ADC_GCOMP           \ ADC gain compensation register
  $80 constant ADC1_ADC_JDR1            \ ADC injected data register
  $84 constant ADC1_ADC_JDR2            \ ADC injected data register
  $88 constant ADC1_ADC_JDR3            \ ADC injected data register
  $8C constant ADC1_ADC_JDR4            \ ADC injected data register
  $A0 constant ADC1_ADC_AWD2CR          \ ADC analog watchdog 2 configuration register
  $A4 constant ADC1_ADC_AWD3CR          \ ADC analog watchdog 3 configuration register
  $A8 constant ADC1_ADC_LTR1            \ ADC watchdog threshold register 1
  $AC constant ADC1_ADC_HTR1            \ ADC watchdog threshold register 1
  $B0 constant ADC1_ADC_LTR2            \ ADC watchdog lower threshold register 2
  $B4 constant ADC1_ADC_HTR2            \ ADC watchdog higher threshold register 2
  $B8 constant ADC1_ADC_LTR3            \ ADC watchdog lower threshold register 3
  $BC constant ADC1_ADC_HTR3            \ ADC watchdog higher threshold register 3
  $C0 constant ADC1_ADC_DIFSEL          \ ADC differential mode selection register
  $C4 constant ADC1_ADC_CALFACT         \ ADC user control register
  $C8 constant ADC1_ADC_CALFACT2        \ ADC calibration factor register

: ADC1_DEF ; [then]
