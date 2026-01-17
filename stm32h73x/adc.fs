\
\ @file adc.fs
\ @brief Analog to Digital Converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC_DEF

  [ifdef] ADC_ADC_ISR_DEF
    \
    \ @brief ADC interrupt and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ADRDY                      \ [0x00] ADC ready This bit is set by hardware after the ADC has been enabled (bit ADEN=1) and when the ADC reaches a state where it is ready to accept conversion requests. It is cleared by software writing 1 to it.
    $01 constant ADC_EOSMP                      \ [0x01] End of sampling flag This bit is set by hardware during the conversion of any channel (only for regular channels), at the end of the sampling phase.
    $02 constant ADC_EOC                        \ [0x02] End of conversion flag This bit is set by hardware at the end of each regular conversion of a channel when a new data is available in the ADC_DR register. It is cleared by software writing 1 to it or by reading the ADC_DR register
    $03 constant ADC_EOS                        \ [0x03] End of regular sequence flag This bit is set by hardware at the end of the conversions of a regular sequence of channels. It is cleared by software writing 1 to it.
    $04 constant ADC_OVR                        \ [0x04] ADC overrun This bit is set by hardware when an overrun occurs on a regular channel, meaning that a new conversion has completed while the EOC flag was already set. It is cleared by software writing 1 to it.
    $05 constant ADC_JEOC                       \ [0x05] Injected channel end of conversion flag This bit is set by hardware at the end of each injected conversion of a channel when a new data is available in the corresponding ADC_JDRy register. It is cleared by software writing 1 to it or by reading the corresponding ADC_JDRy register
    $06 constant ADC_JEOS                       \ [0x06] Injected channel end of sequence flag This bit is set by hardware at the end of the conversions of all injected channels in the group. It is cleared by software writing 1 to it.
    $07 constant ADC_AWD1                       \ [0x07] Analog watchdog 1 flag This bit is set by hardware when the converted voltage crosses the values programmed in the fields LT1[11:0] and HT1[11:0] of ADC_TR1 register. It is cleared by software. writing 1 to it.
    $08 constant ADC_AWD2                       \ [0x08] Analog watchdog 2 flag This bit is set by hardware when the converted voltage crosses the values programmed in the fields LT2[7:0] and HT2[7:0] of ADC_TR2 register. It is cleared by software writing 1 to it.
    $09 constant ADC_AWD3                       \ [0x09] Analog watchdog 3 flag This bit is set by hardware when the converted voltage crosses the values programmed in the fields LT3[7:0] and HT3[7:0] of ADC_TR3 register. It is cleared by software writing 1 to it.
    $0a constant ADC_JQOVF                      \ [0x0a] Injected context queue overflow This bit is set by hardware when an Overflow of the Injected Queue of Context occurs. It is cleared by software writing 1 to it. Refer to for more information.
    $0c constant ADC_LDORDY                     \ [0x0c] ADC LDO output voltage ready bit This bit is set and cleared by hardware. It indicates that the ADC internal LDO output is ready and that the ADC can be enabled or calibrated. Note: Refer to for the availability of the LDO regulator.
  [then]


  [ifdef] ADC_ADC_IER_DEF
    \
    \ @brief ADC interrupt enable register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ADRDYIE                    \ [0x00] ADC ready interrupt enable This bit is set and cleared by software to enable/disable the ADC Ready interrupt. Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $01 constant ADC_EOSMPIE                    \ [0x01] End of sampling flag interrupt enable for regular conversions This bit is set and cleared by software to enable/disable the end of the sampling phase interrupt for regular conversions. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no regular conversion is ongoing).
    $02 constant ADC_EOCIE                      \ [0x02] End of regular conversion interrupt enable This bit is set and cleared by software to enable/disable the end of a regular conversion interrupt. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no regular conversion is ongoing).
    $03 constant ADC_EOSIE                      \ [0x03] End of regular sequence of conversions interrupt enable This bit is set and cleared by software to enable/disable the end of regular sequence of conversions interrupt. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no regular conversion is ongoing).
    $04 constant ADC_OVRIE                      \ [0x04] Overrun interrupt enable This bit is set and cleared by software to enable/disable the Overrun interrupt of a regular conversion. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no regular conversion is ongoing).
    $05 constant ADC_JEOCIE                     \ [0x05] End of injected conversion interrupt enable This bit is set and cleared by software to enable/disable the end of an injected conversion interrupt. Note: The software is allowed to write this bit only when JADSTART is cleared to 0 (no injected conversion is ongoing).
    $06 constant ADC_JEOSIE                     \ [0x06] End of injected sequence of conversions interrupt enable This bit is set and cleared by software to enable/disable the end of injected sequence of conversions interrupt. Note: The software is allowed to write this bit only when JADSTART=0 (which ensures that no injected conversion is ongoing).
    $07 constant ADC_AWD1IE                     \ [0x07] Analog watchdog 1 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog 1 interrupt. Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $08 constant ADC_AWD2IE                     \ [0x08] Analog watchdog 2 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog 2 interrupt. Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $09 constant ADC_AWD3IE                     \ [0x09] Analog watchdog 3 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog 2 interrupt. Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $0a constant ADC_JQOVFIE                    \ [0x0a] Injected context queue overflow interrupt enable This bit is set and cleared by software to enable/disable the Injected Context Queue Overflow interrupt. Note: The software is allowed to write this bit only when JADSTART=0 (which ensures that no injected conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_CR_DEF
    \
    \ @brief ADC control register
    \ Address offset: 0x08
    \ Reset value: 0x20000000
    \
    $00 constant ADC_ADEN                       \ [0x00] ADC enable control This bit is set by software to enable the ADC. The ADC will be effectively ready to operate once the flag ADRDY has been set. It is cleared by hardware when the ADC is disabled, after the execution of the ADDIS command. Note: The software is allowed to set ADEN only when all bits of ADC_CR registers are 0 (ADCAL=0, JADSTART=0, ADSTART=0, ADSTP=0, ADDIS=0 and ADEN=0) except for bit ADVREGEN which must be 1 (and the software must have wait for the startup time of the voltage regulator)
    $01 constant ADC_ADDIS                      \ [0x01] ADC disable command This bit is set by software to disable the ADC (ADDIS command) and put it into power-down state (OFF state). It is cleared by hardware once the ADC is effectively disabled (ADEN is also cleared by hardware at this time). Note: The software is allowed to set ADDIS only when ADEN=1 and both ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing)
    $02 constant ADC_ADSTART                    \ [0x02] ADC start of regular conversion This bit is set by software to start ADC conversion of regular channels. Depending on the configuration bits EXTEN, a conversion will start immediately (software trigger configuration) or once a regular hardware trigger event occurs (hardware trigger configuration). It is cleared by hardware: in single conversion mode (CONT=0, DISCEN=0) when software trigger is selected (EXTEN=0x0): at the assertion of the End of Regular Conversion Sequence (EOS) flag. In discontinuous conversion mode (CONT=0, DISCEN=1), when the software trigger is selected (EXTEN=0x0): at the end of conversion (EOC) flag. in all other cases: after the execution of the ADSTP command, at the same time that ADSTP is cleared by hardware. Note: The software is allowed to set ADSTART only when ADEN=1 and ADDIS=0 (ADC is enabled and there is no pending request to disable the ADC) In auto-injection mode (JAUTO=1), regular and auto-injected conversions are started by setting bit ADSTART (JADSTART must be kept cleared)
    $03 constant ADC_JADSTART                   \ [0x03] ADC start of injected conversion This bit is set by software to start ADC conversion of injected channels. Depending on the configuration bits JEXTEN, a conversion will start immediately (software trigger configuration) or once an injected hardware trigger event occurs (hardware trigger configuration). It is cleared by hardware: in single conversion mode when software trigger is selected (JEXTSEL=0x0): at the assertion of the End of Injected Conversion Sequence (JEOS) flag. in all cases: after the execution of the JADSTP command, at the same time that JADSTP is cleared by hardware. Note: The software is allowed to set JADSTART only when ADEN=1 and ADDIS=0 (ADC is enabled and there is no pending request to disable the ADC). In auto-injection mode (JAUTO=1), regular and auto-injected conversions are started by setting bit ADSTART (JADSTART must be kept cleared)
    $04 constant ADC_ADSTP                      \ [0x04] ADC stop of regular conversion command This bit is set by software to stop and discard an ongoing regular conversion (ADSTP Command). It is cleared by hardware when the conversion is effectively discarded and the ADC regular sequence and triggers can be re-configured. The ADC is then ready to accept a new start of regular conversions (ADSTART command). Note: The software is allowed to set ADSTP only when ADSTART=1 and ADDIS=0 (ADC is enabled and eventually converting a regular conversion and there is no pending request to disable the ADC). In auto-injection mode (JAUTO=1), setting ADSTP bit aborts both regular and injected conversions (do not use JADSTP). In dual ADC regular simultaneous mode and interleaved mode, the bit ADSTP of the master ADC must be used to stop regular conversions. The other ADSTP bit is inactive.
    $05 constant ADC_JADSTP                     \ [0x05] ADC stop of injected conversion command This bit is set by software to stop and discard an ongoing injected conversion (JADSTP Command). It is cleared by hardware when the conversion is effectively discarded and the ADC injected sequence and triggers can be re-configured. The ADC is then ready to accept a new start of injected conversions (JADSTART command). Note: The software is allowed to set JADSTP only when JADSTART=1 and ADDIS=0 (ADC is enabled and eventually converting an injected conversion and there is no pending request to disable the ADC). In auto-injection mode (JAUTO=1), setting ADSTP bit aborts both regular and injected conversions (do not use JADSTP)
    $08 constant ADC_BOOST                      \ [0x08 : 2] Boost mode control This bitfield is set and cleared by software to enable/disable the Boost mode. Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing). When dual mode is enabled (bits DAMDF of ADCx_CCR register are not equal to zero), the BOOST bitfield of the slave ADC is no more writable and its content must be equal to the master ADC BOOST bitfield.
    $10 constant ADC_ADCALLIN                   \ [0x10] Linearity calibration This bit is set and cleared by software to enable the Linearity calibration. Note: The software is allowed to write this bit only when the ADC is disabled and is not calibrating (ADCAL=0, JADSTART=0, JADSTP=0, ADSTART=0, ADSTP=0, ADDIS=0 and ADEN=0).
    $16 constant ADC_LINCALRDYW1                \ [0x16] Linearity calibration ready Word 1 Refer to LINCALRDYW6 description. Note: ADC_CALFACT2[29:0] corresponds linearity correction factor bits[29:0]. The software is allowed to toggle this bit only if the LINCALRDYW6, LINCALRDYW5, LINCALRDYW4, LINCALRDYW3 and LINCALRDYW2 bits are left unchanged.
    $17 constant ADC_LINCALRDYW2                \ [0x17] Linearity calibration ready Word 2 Refer to LINCALRDYW6 description. Note: ADC_CALFACT2[29:0] corresponds linearity correction factor bits[59:30]. The software is allowed to toggle this bit only if the LINCALRDYW6, LINCALRDYW5, LINCALRDYW4, LINCALRDYW3 and LINCALRDYW1 bits are left unchanged.
    $18 constant ADC_LINCALRDYW3                \ [0x18] Linearity calibration ready Word 3 Refer to LINCALRDYW6 description. Note: ADC_CALFACT2[29:0] corresponds linearity correction factor bits[89:60]. The software is allowed to toggle this bit only if the LINCALRDYW6, LINCALRDYW5, LINCALRDYW4, LINCALRDYW2 and LINCALRDYW1 bits are left unchanged.
    $19 constant ADC_LINCALRDYW4                \ [0x19] Linearity calibration ready Word 4 Refer to LINCALRDYW6 description. Note: ADC_CALFACT2[29:0] correspond linearity correction factor bits[119:90]. The software is allowed to toggle this bit only if the LINCALRDYW6, LINCALRDYW5, LINCALRDYW3, LINCALRDYW2 and LINCALRDYW1 bits are left unchanged.
    $1a constant ADC_LINCALRDYW5                \ [0x1a] Linearity calibration ready Word 5 Refer to LINCALRDYW6 description. Note: ADC_CALFACT2[29:0] corresponds linearity correction factor bits[149:120]. The software is allowed to toggle this bit only if the LINCALRDYW6, LINCALRDYW5, LINCALRDYW3, LINCALRDYW2 and LINCALRDYW1 bits are left unchanged.
    $1b constant ADC_LINCALRDYW6                \ [0x1b] Linearity calibration ready Word 6 This control / status bit allows to read/write the 6th linearity calibration factor. When the linearity calibration is complete, this bit is set. A bit clear will launch the transfer of the linearity factor 6 into the LINCALFACT[29:0] of the ADC_CALFACT2 register. The bit will be reset by hardware when the ADC_CALFACT2 register can be read (software must poll the bit until it is cleared). When the LINCALRDYW6 bit is reset, a new linearity factor 6 value can be written into the LINCALFACT[29:0] of the ADC_CALFACT2 register. A bit set will launch the linearity factor 6 update and the bit will be effectively set by hardware once the update will be done (software must poll the bit until it is set to indicate the write is effective). Note: ADC_CALFACT2[29:10] contains 0. ADC_CALFACT2[9:0] corresponds linearity correction factor bits[159:150]. The software is allowed to toggle this bit only if the LINCALRDYW5, LINCALRDYW4, LINCALRDYW3, LINCALRDYW2 and LINCALRDYW1 bits are left unchanged, see chapter for details. The software is allowed to update the linearity calibration factor by writing LINCALRDYWx only when ADEN=1 and ADSTART=0 and JADSTART=0 (ADC enabled and no conversion is ongoing)
    $1c constant ADC_ADVREGEN                   \ [0x1c] ADC voltage regulator enable This bits is set by software to enable the ADC voltage regulator. Before performing any operation such as launching a calibration or enabling the ADC, the ADC voltage regulator must first be enabled and the software must wait for the regulator start-up time. For more details about the ADC voltage regulator enable and disable sequences, refer to (ADVREGEN). The software can program this bitfield only when the ADC is disabled (ADCAL=0, JADSTART=0, ADSTART=0, ADSTP=0, ADDIS=0 and ADEN=0).
    $1d constant ADC_DEEPPWD                    \ [0x1d] Deep-power-down enable This bit is set and cleared by software to put the ADC in deep-power-down mode. Note: The software is allowed to write this bit only when the ADC is disabled (ADCAL=0, JADSTART=0, JADSTP=0, ADSTART=0, ADSTP=0, ADDIS=0 and ADEN=0).
    $1e constant ADC_ADCALDIF                   \ [0x1e] Differential mode for calibration This bit is set and cleared by software to configure the single-ended or differential inputs mode for the calibration. Note: The software is allowed to write this bit only when the ADC is disabled and is not calibrating (ADCAL=0, JADSTART=0, JADSTP=0, ADSTART=0, ADSTP=0, ADDIS=0 and ADEN=0).
    $1f constant ADC_ADCAL                      \ [0x1f] ADC calibration This bit is set by software to start the calibration of the ADC. Program first the bit ADCALDIF to determine if this calibration applies for single-ended or differential inputs mode. It is cleared by hardware after calibration is complete. Note: The software is allowed to launch a calibration by setting ADCAL only when ADEN=0. The software is allowed to update the calibration factor by writing ADC_CALFACT only when ADEN=1 and ADSTART=0 and JADSTART=0 (ADC enabled and no conversion is ongoing)
  [then]


  [ifdef] ADC_ADC_CFGR_DEF
    \
    \ @brief ADC configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x80000000
    \
    $00 constant ADC_DMNGT                      \ [0x00 : 2] Data Management configuration This bit is set and cleared by software to select how ADC interface output data are managed. Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing). In dual-ADC modes, this bit is not relevant and replaced by control bit DAMDF of the ADCx_CCR register.
    $02 constant ADC_RES                        \ [0x02 : 3] Data resolution These bits are written by software to select the resolution of the conversion. Others: Reserved, must not be used. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $05 constant ADC_EXTSEL                     \ [0x05 : 5] External trigger selection for regular group These bits select the external event used to trigger the start of conversion of a regular group: ... Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
    $0a constant ADC_EXTEN                      \ [0x0a : 2] External trigger enable and polarity selection for regular channels These bits are set and cleared by software to select the external trigger polarity and enable the trigger of a regular group. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
    $0c constant ADC_OVRMOD                     \ [0x0c] Overrun Mode This bit is set and cleared by software and configure the way data overrun is managed. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no regular conversion is ongoing).
    $0d constant ADC_CONT                       \ [0x0d] Single / continuous conversion mode for regular conversions This bit is set and cleared by software. If it is set, regular conversion takes place continuously until it is cleared. Note: It is not possible to have both discontinuous mode and continuous mode enabled: it is forbidden to set both DISCEN=1 and CONT=1. The software is allowed to write this bit only when ADSTART=0 (which ensures that no regular conversion is ongoing). When dual mode is enabled (DAMDF bits in ADCx_CCR register are not equal to zero), the bit CONT of the slave ADC is no more writable and its content is equal to the bit CONT of the master ADC.
    $0e constant ADC_AUTDLY                     \ [0x0e] Delayed conversion mode This bit is set and cleared by software to enable/disable the Auto Delayed Conversion mode.. Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing). When dual mode is enabled (DAMDF bits in ADCx_CCR register are not equal to zero), the bit AUTDLY of the slave ADC is no more writable and its content is equal to the bit AUTDLY of the master ADC.
    $10 constant ADC_DISCEN                     \ [0x10] Discontinuous mode for regular channels This bit is set and cleared by software to enable/disable Discontinuous mode for regular channels. Note: It is not possible to have both discontinuous mode and continuous mode enabled: it is forbidden to set both DISCEN=1 and CONT=1. It is not possible to use both auto-injected mode and discontinuous mode simultaneously: the bits DISCEN and JDISCEN must be kept cleared by software when JAUTO is set. The software is allowed to write this bit only when ADSTART=0 (which ensures that no regular conversion is ongoing). When dual mode is enabled (DAMDF bits in ADCx_CCR register are not equal to zero), the bit DISCEN of the slave ADC is no more writable and its content is equal to the bit DISCEN of the master ADC.
    $11 constant ADC_DISCNUM                    \ [0x11 : 3] Discontinuous mode channel count These bits are written by software to define the number of regular channels to be converted in discontinuous mode, after receiving an external trigger. ... Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing). When dual mode is enabled (DAMDF bits in ADCx_CCR register are not equal to zero), the bits DISCNUM[2:0] of the slave ADC are no more writable and their content is equal to the bits DISCNUM[2:0] of the master ADC.
    $14 constant ADC_JDISCEN                    \ [0x14] Discontinuous mode on injected channels This bit is set and cleared by software to enable/disable discontinuous mode on the injected channels of a group. Note: The software is allowed to write this bit only when JADSTART=0 (which ensures that no injected conversion is ongoing). It is not possible to use both auto-injected mode and discontinuous mode simultaneously: the bits DISCEN and JDISCEN must be kept cleared by software when JAUTO is set. When dual mode is enabled (bits DAMDF of ADCx_CCR register are not equal to zero), the bit JDISCEN of the slave ADC is no more writable and its content is equal to the bit JDISCEN of the master ADC.
    $15 constant ADC_JQM                        \ [0x15] JSQR queue mode This bit is set and cleared by software. It defines how an empty Queue is managed. Refer to for more information. Note: The software is allowed to write this bit only when JADSTART=0 (which ensures that no injected conversion is ongoing). When dual mode is enabled (DAMDF bits in ADCx_CCR register are not equal to zero), the bit JQM of the slave ADC is no more writable and its content is equal to the bit JQM of the master ADC.
    $16 constant ADC_AWD1SGL                    \ [0x16] Enable the watchdog 1 on a single channel or on all channels This bit is set and cleared by software to enable the analog watchdog on the channel identified by the AWD1CH[4:0] bits or on all the channels Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $17 constant ADC_AWD1EN                     \ [0x17] Analog watchdog 1 enable on regular channels This bit is set and cleared by software Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no regular conversion is ongoing).
    $18 constant ADC_JAWD1EN                    \ [0x18] Analog watchdog 1 enable on injected channels This bit is set and cleared by software Note: The software is allowed to write this bit only when JADSTART=0 (which ensures that no injected conversion is ongoing).
    $19 constant ADC_JAUTO                      \ [0x19] Automatic injected group conversion This bit is set and cleared by software to enable/disable automatic injected group conversion after regular group conversion. Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no regular nor injected conversion is ongoing). When dual mode is enabled (DAMDF bits in ADCx_CCR register are not equal to zero), the bit JAUTO of the slave ADC is no more writable and its content is equal to the bit JAUTO of the master ADC.
    $1a constant ADC_AWD1CH                     \ [0x1a : 5] Analog watchdog 1 channel selection These bits are set and cleared by software. They select the input channel to be guarded by the analog watchdog. ..... others: Reserved, must not be used Note: The channel selected by AWD1CH must be also selected into the SQRi or JSQRi registers. The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $1f constant ADC_JQDIS                      \ [0x1f] Injected Queue disable These bits are set and cleared by software to disable the Injected Queue mechanism: Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no regular nor injected conversion is ongoing). A set or reset of JQDIS bit causes the injected queue to be flushed and the JSQR register is cleared.
  [then]


  [ifdef] ADC_ADC_CFGR2_DEF
    \
    \ @brief ADC configuration register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ROVSE                      \ [0x00] Regular Oversampling Enable This bit is set and cleared by software to enable regular oversampling. Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing)
    $01 constant ADC_JOVSE                      \ [0x01] Injected Oversampling Enable This bit is set and cleared by software to enable injected oversampling. Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing)
    $05 constant ADC_OVSS                       \ [0x05 : 4] Oversampling right shift This bitfield is set and cleared by software to define the right shifting applied to the raw oversampling result. Others: Reserved, must not be used. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no conversion is ongoing).
    $09 constant ADC_TROVS                      \ [0x09] Triggered Regular Oversampling This bit is set and cleared by software to enable triggered oversampling Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $0a constant ADC_ROVSM                      \ [0x0a] Regular Oversampling mode This bit is set and cleared by software to select the regular oversampling mode. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $0b constant ADC_RSHIFT1                    \ [0x0b] Right-shift data after Offset 1 correction This bitfield is set and cleared by software to right-shift 1-bit data after offset1 correction. This bit can only be used for 8-bit and 16-bit data format (see (ADC_DR, ADC_JDRy, OFFSETy, OFFSETy_CH, OVSS, LSHIFT, RSHIFT, SSATE) for details).
    $0c constant ADC_RSHIFT2                    \ [0x0c] Right-shift data after Offset 2 correction Refer to RSHIFT1 description
    $0d constant ADC_RSHIFT3                    \ [0x0d] Right-shift data after Offset 3 correction Refer to RSHIFT1 description
    $0e constant ADC_RSHIFT4                    \ [0x0e] Right-shift data after Offset 4 correction Refer to RSHIFT1 description.
    $10 constant ADC_OSVR                       \ [0x10 : 10] Oversampling ratio This bitfield is set and cleared by software to define the oversampling ratio. 2: 3x ... 1023: 1024x Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $1c constant ADC_LSHIFT                     \ [0x1c : 4] Left shift factor This bitfield is set and cleared by software to define the left shifting applied to the final result with or without oversampling. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_SMPR1_DEF
    \
    \ @brief ADC sample time register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SMP0                       \ [0x00 : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $03 constant ADC_SMP1                       \ [0x03 : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $06 constant ADC_SMP2                       \ [0x06 : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $09 constant ADC_SMP3                       \ [0x09 : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $0c constant ADC_SMP4                       \ [0x0c : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $0f constant ADC_SMP5                       \ [0x0f : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $12 constant ADC_SMP6                       \ [0x12 : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $15 constant ADC_SMP7                       \ [0x15 : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $18 constant ADC_SMP8                       \ [0x18 : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $1b constant ADC_SMP9                       \ [0x1b : 3] Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_SMPR2_DEF
    \
    \ @brief ADC sample time register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SMP10                      \ [0x00 : 3] Channel x sampling time selection (x = 10 to 19) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $03 constant ADC_SMP11                      \ [0x03 : 3] Channel x sampling time selection (x = 10 to 19) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $06 constant ADC_SMP12                      \ [0x06 : 3] Channel x sampling time selection (x = 10 to 19) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $09 constant ADC_SMP13                      \ [0x09 : 3] Channel x sampling time selection (x = 10 to 19) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $0c constant ADC_SMP14                      \ [0x0c : 3] Channel x sampling time selection (x = 10 to 19) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $0f constant ADC_SMP15                      \ [0x0f : 3] Channel x sampling time selection (x = 10 to 19) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $12 constant ADC_SMP16                      \ [0x12 : 3] Channel x sampling time selection (x = 10 to 19) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $15 constant ADC_SMP17                      \ [0x15 : 3] Channel x sampling time selection (x = 10 to 19) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $18 constant ADC_SMP18                      \ [0x18 : 3] Channel x sampling time selection (x = 10 to 19) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $1b constant ADC_SMP19                      \ [0x1b : 3] Channel x sampling time selection (x = 10 to 19) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_PCSEL_DEF
    \
    \ @brief ADC channel preselection register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_PCSEL0                     \ [0x00] :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $01 constant ADC_PCSEL1                     \ [0x01] :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $02 constant ADC_PCSEL2                     \ [0x02] :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $03 constant ADC_PCSEL3                     \ [0x03] :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $04 constant ADC_PCSEL4                     \ [0x04] :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $05 constant ADC_PCSEL5                     \ [0x05] :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $06 constant ADC_PCSEL6                     \ [0x06] :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $07 constant ADC_PCSEL7                     \ [0x07] :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $08 constant ADC_PCSEL8                     \ [0x08] :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $09 constant ADC_PCSEL9                     \ [0x09] :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $0a constant ADC_PCSEL10                    \ [0x0a] :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $0b constant ADC_PCSEL11                    \ [0x0b] :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $0c constant ADC_PCSEL12                    \ [0x0c] :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $0d constant ADC_PCSEL13                    \ [0x0d] :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $0e constant ADC_PCSEL14                    \ [0x0e] :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $0f constant ADC_PCSEL15                    \ [0x0f] :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $10 constant ADC_PCSEL16                    \ [0x10] :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $11 constant ADC_PCSEL17                    \ [0x11] :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $12 constant ADC_PCSEL18                    \ [0x12] :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $13 constant ADC_PCSEL19                    \ [0x13] :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_LTR1_DEF
    \
    \ @brief ADC watchdog threshold register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant ADC_LTR1                       \ [0x00 : 26] Analog watchdog 1 lower threshold These bits are written by software to define the lower threshold for the analog watchdog 1. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy) Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_HTR1_DEF
    \
    \ @brief ADC watchdog threshold register 1
    \ Address offset: 0x24
    \ Reset value: 0x03FFFFFF
    \
    $00 constant ADC_HTR1                       \ [0x00 : 26] Analog watchdog 1 higher threshold These bits are written by software to define the higher threshold for the analog watchdog 1. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy) Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_SQR1_DEF
    \
    \ @brief ADC regular sequence register 1
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant ADC_L                          \ [0x00 : 4] Regular channel sequence length These bits are written by software to define the total number of conversions in the regular channel conversion sequence. ... Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
    $06 constant ADC_SQ1                        \ [0x06 : 5] 1st conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 1st in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
    $0c constant ADC_SQ2                        \ [0x0c : 5] 2nd conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 2nd in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
    $12 constant ADC_SQ3                        \ [0x12 : 5] 3rd conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 3rd in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
    $18 constant ADC_SQ4                        \ [0x18 : 5] 4th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 4th in the regular conversion sequence.
  [then]


  [ifdef] ADC_ADC_SQR2_DEF
    \
    \ @brief ADC regular sequence register 2
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ5                        \ [0x00 : 5] 5th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 5th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
    $06 constant ADC_SQ6                        \ [0x06 : 5] 6th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 6th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
    $0c constant ADC_SQ7                        \ [0x0c : 5] 7th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 7th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
    $12 constant ADC_SQ8                        \ [0x12 : 5] 8th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 8th in the regular conversion sequence Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
    $18 constant ADC_SQ9                        \ [0x18 : 5] 9th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 9th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_SQR3_DEF
    \
    \ @brief ADC regular sequence register 3
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ10                       \ [0x00 : 5] 10th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 10th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
    $06 constant ADC_SQ11                       \ [0x06 : 5] 11th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 11th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
    $0c constant ADC_SQ12                       \ [0x0c : 5] 12th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 12th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
    $12 constant ADC_SQ13                       \ [0x12 : 5] 13th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 13th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
    $18 constant ADC_SQ14                       \ [0x18 : 5] 14th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 14th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_SQR4_DEF
    \
    \ @brief ADC regular sequence register 4
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ15                       \ [0x00 : 5] 15th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 15th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
    $06 constant ADC_SQ16                       \ [0x06 : 5] 16th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 16th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_DR_DEF
    \
    \ @brief ADC regular Data Register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant ADC_RDATA                      \ [0x00 : 32] Regular Data converted These bits are read-only. They contain the conversion result from the last converted regular channel. The data are left- or right-aligned as described in .
  [then]


  [ifdef] ADC_ADC_JSQR_DEF
    \
    \ @brief ADC injected sequence register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JL                         \ [0x00 : 2] Injected channel sequence length These bits are written by software to define the total number of conversions in the injected channel conversion sequence. Note: The software is allowed to write these bits only when JADSTART is cleared to 0 (no injected conversion is ongoing).
    $02 constant ADC_JEXTSEL                    \ [0x02 : 5] External trigger selection for injected group These bits select the external event used to trigger the start of conversion of an injected group: ... Note: The software is allowed to write these bits only when JADSTART is cleared to 0 (no injected conversion is ongoing).
    $07 constant ADC_JEXTEN                     \ [0x07 : 2] External trigger enable and polarity selection for injected channels These bits are set and cleared by software to select the external trigger polarity and enable the trigger of an injected group. If JQDIS=1 (queue disabled), Hardware trigger detection disabled (conversions can be launched by software Note: The software is allowed to write these bits only when JADSTART is cleared to 0 (no injected conversion is ongoing). If JQM=1 and if the Queue of Context becomes empty, the software and hardware triggers of the injected sequence are both internally disabled (refer to Queue of context for injected conversions)
    $09 constant ADC_JSQ1                       \ [0x09 : 5] 1st conversion in the injected sequence These bits are written by software with the channel number (0..19) assigned as the 1st in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART is cleared to 0 (no injected conversion is ongoing) unless the context queue is enabled (JQDIS=0 in ADC_CFGR register).
    $0f constant ADC_JSQ2                       \ [0x0f : 5] 2nd conversion in the injected sequence These bits are written by software with the channel number (0..19) assigned as the 2nd in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART is cleared to 0 (no injected conversion is ongoing) unless the context queue is enabled (JQDIS=0 in ADC_CFGR register).
    $15 constant ADC_JSQ3                       \ [0x15 : 5] 3rd conversion in the injected sequence These bits are written by software with the channel number (0..19) assigned as the 3rd in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART is cleared to 0 (no injected conversion is ongoing) unless the context queue is enabled (JQDIS=0 in ADC_CFGR register).
    $1b constant ADC_JSQ4                       \ [0x1b : 5] 4th conversion in the injected sequence These bits are written by software with the channel number (0..19) assigned as the 4th in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART is cleared to 0 (no injected conversion is ongoing) unless the context queue is enabled (JQDIS=0 in ADC_CFGR register).
  [then]


  [ifdef] ADC_ADC_OFR1_DEF
    \
    \ @brief ADC injected channel 1 offset register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET1                    \ [0x00 : 26] Data offset y for the channel programmed into bits OFFSETy_CH[4:0] These bits are written by software to define the offset y to be subtracted from the raw converted data when converting a channel (can be regular or injected). The channel to which applies the data offset y must be programmed in the bits OFFSETy_CH[4:0]. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). When OFFSETy[25:0] bitfield is reset, the offset compensation is disabled. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing). If several offset (OFFSETy) point to the same channel, only the offset with the lowest x value is considered for the subtraction. Ex: if OFFSET1_CH[4:0]=4 and OFFSET2_CH[4:0]=4, this is OFFSET1[25:0] which is subtracted when converting channel 4.
    $1a constant ADC_OFFSET1_CH                 \ [0x1a : 5] Channel selection for the Data offset y These bits are written by software to define the channel to which the offset programmed into bits OFFSETy[25:0] will apply. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $1f constant ADC_SSATE                      \ [0x1f] Signed saturation Enable This bit is written by software to enable or disable the Signed saturation feature. This bit can be enabled only for 8-bit and 16-bit data format (see alignment and offset (ADC_DR, ADC_JDRy, OFFSETy, OFFSETy_CH, OVSS, LSHIFT, RSHIFT, SSATE) for details). Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_OFR2_DEF
    \
    \ @brief ADC injected channel 2 offset register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET2                    \ [0x00 : 26] Data offset y for the channel programmed into bits OFFSETy_CH[4:0] These bits are written by software to define the offset y to be subtracted from the raw converted data when converting a channel (can be regular or injected). The channel to which applies the data offset y must be programmed in the bits OFFSETy_CH[4:0]. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). When OFFSETy[25:0] bitfield is reset, the offset compensation is disabled. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing). If several offset (OFFSETy) point to the same channel, only the offset with the lowest x value is considered for the subtraction. Ex: if OFFSET1_CH[4:0]=4 and OFFSET2_CH[4:0]=4, this is OFFSET1[25:0] which is subtracted when converting channel 4.
    $1a constant ADC_OFFSET2_CH                 \ [0x1a : 5] Channel selection for the Data offset y These bits are written by software to define the channel to which the offset programmed into bits OFFSETy[25:0] will apply. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $1f constant ADC_SSATE                      \ [0x1f] Signed saturation Enable This bit is written by software to enable or disable the Signed saturation feature. This bit can be enabled only for 8-bit and 16-bit data format (see alignment and offset (ADC_DR, ADC_JDRy, OFFSETy, OFFSETy_CH, OVSS, LSHIFT, RSHIFT, SSATE) for details). Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_OFR3_DEF
    \
    \ @brief ADC injected channel 3 offset register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET3                    \ [0x00 : 26] Data offset y for the channel programmed into bits OFFSETy_CH[4:0] These bits are written by software to define the offset y to be subtracted from the raw converted data when converting a channel (can be regular or injected). The channel to which applies the data offset y must be programmed in the bits OFFSETy_CH[4:0]. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). When OFFSETy[25:0] bitfield is reset, the offset compensation is disabled. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing). If several offset (OFFSETy) point to the same channel, only the offset with the lowest x value is considered for the subtraction. Ex: if OFFSET1_CH[4:0]=4 and OFFSET2_CH[4:0]=4, this is OFFSET1[25:0] which is subtracted when converting channel 4.
    $1a constant ADC_OFFSET3_CH                 \ [0x1a : 5] Channel selection for the Data offset y These bits are written by software to define the channel to which the offset programmed into bits OFFSETy[25:0] will apply. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $1f constant ADC_SSATE                      \ [0x1f] Signed saturation Enable This bit is written by software to enable or disable the Signed saturation feature. This bit can be enabled only for 8-bit and 16-bit data format (see alignment and offset (ADC_DR, ADC_JDRy, OFFSETy, OFFSETy_CH, OVSS, LSHIFT, RSHIFT, SSATE) for details). Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_OFR4_DEF
    \
    \ @brief ADC injected channel 4 offset register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET4                    \ [0x00 : 26] Data offset y for the channel programmed into bits OFFSETy_CH[4:0] These bits are written by software to define the offset y to be subtracted from the raw converted data when converting a channel (can be regular or injected). The channel to which applies the data offset y must be programmed in the bits OFFSETy_CH[4:0]. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). When OFFSETy[25:0] bitfield is reset, the offset compensation is disabled. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing). If several offset (OFFSETy) point to the same channel, only the offset with the lowest x value is considered for the subtraction. Ex: if OFFSET1_CH[4:0]=4 and OFFSET2_CH[4:0]=4, this is OFFSET1[25:0] which is subtracted when converting channel 4.
    $1a constant ADC_OFFSET4_CH                 \ [0x1a : 5] Channel selection for the Data offset y These bits are written by software to define the channel to which the offset programmed into bits OFFSETy[25:0] will apply. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
    $1f constant ADC_SSATE                      \ [0x1f] Signed saturation Enable This bit is written by software to enable or disable the Signed saturation feature. This bit can be enabled only for 8-bit and 16-bit data format (see alignment and offset (ADC_DR, ADC_JDRy, OFFSETy, OFFSETy_CH, OVSS, LSHIFT, RSHIFT, SSATE) for details). Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_JDR1_DEF
    \
    \ @brief ADC injected channel 1 data register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 32] Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in .
  [then]


  [ifdef] ADC_ADC_JDR2_DEF
    \
    \ @brief ADC injected channel 2 data register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 32] Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in .
  [then]


  [ifdef] ADC_ADC_JDR3_DEF
    \
    \ @brief ADC injected channel 3 data register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 32] Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in .
  [then]


  [ifdef] ADC_ADC_JDR4_DEF
    \
    \ @brief ADC injected channel 4 data register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 32] Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in .
  [then]


  [ifdef] ADC_ADC_AWD2CR_DEF
    \
    \ @brief ADC analog watchdog 2 configuration register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant ADC_AWD2CH                     \ [0x00 : 20] Analog watchdog 2 channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by the analog watchdog 2. AWD2CH[i] = 0: ADC analog input channel-i is not monitored by AWD2 AWD2CH[i] = 1: ADC analog input channel-i is monitored by AWD2 When AWD2CH[19:0] = 000..0, the analog Watchdog 2 is disabled Note: The channels selected by AWD2CH must be also selected into the SQRi or JSQRi registers. The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_AWD3CR_DEF
    \
    \ @brief ADC analog watchdog 3 configuration register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant ADC_AWD3CH                     \ [0x00 : 20] Analog watchdog 3 channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by the analog watchdog 3. AWD3CH[i] = 0: ADC analog input channel-i is not monitored by AWD3 AWD3CH[i] = 1: ADC analog input channel-i is monitored by AWD3 When AWD3CH[19:0] = 000..0, the analog Watchdog 3 is disabled Note: The channels selected by AWD3CH must be also selected into the SQRi or JSQRi registers. The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_LTR2_DEF
    \
    \ @brief ADC watchdog lower threshold register 2
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant ADC_LTR2                       \ [0x00 : 26] Analog watchdog 2 lower threshold These bits are written by software to define the lower threshold for the analog watchdog 2. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy). Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_HTR2_DEF
    \
    \ @brief ADC watchdog higher threshold register 2
    \ Address offset: 0xB4
    \ Reset value: 0x03FFFFFF
    \
    $00 constant ADC_HTR2                       \ [0x00 : 26] Analog watchdog 2 higher threshold These bits are written by software to define the higher threshold for the analog watchdog 2. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy). Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_LTR3_DEF
    \
    \ @brief ADC watchdog lower threshold register 3
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant ADC_LTR3                       \ [0x00 : 26] Analog watchdog 3 lower threshold These bits are written by software to define the lower threshold for the analog watchdog 3. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy) Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_HTR3_DEF
    \
    \ @brief ADC watchdog higher threshold register 3
    \ Address offset: 0xBC
    \ Reset value: 0x03FFFFFF
    \
    $00 constant ADC_HTR3                       \ [0x00 : 26] Analog watchdog 3 higher threshold These bits are written by software to define the higher threshold for the analog watchdog 3. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy) Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_DIFSEL_DEF
    \
    \ @brief ADC differential mode selection register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant ADC_DIFSEL                     \ [0x00 : 20] Differential mode for channels 19 to 0 These bits are set and cleared by software. They allow to select if a channel is configured as single ended or differential mode. DIFSEL[i] = 0: ADC analog input channel-i is configured in single ended mode DIFSEL[i] = 1: ADC analog input channel-i is configured in differential mode Note: The software is allowed to write these bits only when the ADC is disabled (ADCAL=0, JADSTART=0, JADSTP=0, ADSTART=0, ADSTP=0, ADDIS=0 and ADEN=0).
  [then]


  [ifdef] ADC_ADC_CALFACT_DEF
    \
    \ @brief ADC calibration factors register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant ADC_CALFACT_S                  \ [0x00 : 11] Calibration Factors In Single-Ended mode These bits are written by hardware or by software. Once a single-ended inputs calibration is complete, they are updated by hardware with the calibration factors. Software can write these bits with a new calibration factor. If the new calibration factor is different from the current one stored into the analog ADC, it will then be applied once a new single-ended conversion is launched. Note: The software is allowed to write these bits only when ADEN=1, ADSTART=0 and JADSTART=0 (ADC is enabled and no calibration is ongoing and no conversion is ongoing).
    $10 constant ADC_CALFACT_D                  \ [0x10 : 11] Calibration Factors in differential mode These bits are written by hardware or by software. Once a differential inputs calibration is complete, they are updated by hardware with the calibration factors. Software can write these bits with a new calibration factor. If the new calibration factor is different from the current one stored into the analog ADC, it will then be applied once a new differential conversion is launched. Note: The software is allowed to write these bits only when ADEN=1, ADSTART=0 and JADSTART=0 (ADC is enabled and no calibration is ongoing and no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_CALFACT2_DEF
    \
    \ @brief ADC calibration factor register 2
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant ADC_LINCALFACT                 \ [0x00 : 30] Linearity Calibration Factor These bits are written by hardware or by software. They hold 30-bit out of the 160-bit linearity calibration factor. Once a single-ended inputs calibration is complete, they are updated by hardware with the calibration factors. Software can write these bits with a new calibration factor. If the new calibration factor is different from the current one stored into the analog ADC, it will then be applied once a new single-ended calibration is launched. Note: The software is allowed to write these bits only when ADEN=1, ADSTART=0 and JADSTART=0 (ADC is enabled and no calibration is ongoing and no conversion is ongoing).
  [then]

  \
  \ @brief Analog to Digital Converter
  \
  $00 constant ADC_ADC_ISR              \ ADC interrupt and status register
  $04 constant ADC_ADC_IER              \ ADC interrupt enable register
  $08 constant ADC_ADC_CR               \ ADC control register
  $0C constant ADC_ADC_CFGR             \ ADC configuration register
  $10 constant ADC_ADC_CFGR2            \ ADC configuration register 2
  $14 constant ADC_ADC_SMPR1            \ ADC sample time register 1
  $18 constant ADC_ADC_SMPR2            \ ADC sample time register 2
  $1C constant ADC_ADC_PCSEL            \ ADC channel preselection register
  $20 constant ADC_ADC_LTR1             \ ADC watchdog threshold register 1
  $24 constant ADC_ADC_HTR1             \ ADC watchdog threshold register 1
  $30 constant ADC_ADC_SQR1             \ ADC regular sequence register 1
  $34 constant ADC_ADC_SQR2             \ ADC regular sequence register 2
  $38 constant ADC_ADC_SQR3             \ ADC regular sequence register 3
  $3C constant ADC_ADC_SQR4             \ ADC regular sequence register 4
  $40 constant ADC_ADC_DR               \ ADC regular Data Register
  $4C constant ADC_ADC_JSQR             \ ADC injected sequence register
  $60 constant ADC_ADC_OFR1             \ ADC injected channel 1 offset register
  $64 constant ADC_ADC_OFR2             \ ADC injected channel 2 offset register
  $68 constant ADC_ADC_OFR3             \ ADC injected channel 3 offset register
  $6C constant ADC_ADC_OFR4             \ ADC injected channel 4 offset register
  $80 constant ADC_ADC_JDR1             \ ADC injected channel 1 data register
  $84 constant ADC_ADC_JDR2             \ ADC injected channel 2 data register
  $88 constant ADC_ADC_JDR3             \ ADC injected channel 3 data register
  $8C constant ADC_ADC_JDR4             \ ADC injected channel 4 data register
  $A0 constant ADC_ADC_AWD2CR           \ ADC analog watchdog 2 configuration register
  $A4 constant ADC_ADC_AWD3CR           \ ADC analog watchdog 3 configuration register
  $B0 constant ADC_ADC_LTR2             \ ADC watchdog lower threshold register 2
  $B4 constant ADC_ADC_HTR2             \ ADC watchdog higher threshold register 2
  $B8 constant ADC_ADC_LTR3             \ ADC watchdog lower threshold register 3
  $BC constant ADC_ADC_HTR3             \ ADC watchdog higher threshold register 3
  $C0 constant ADC_ADC_DIFSEL           \ ADC differential mode selection register
  $C4 constant ADC_ADC_CALFACT          \ ADC calibration factors register
  $C8 constant ADC_ADC_CALFACT2         \ ADC calibration factor register 2

: ADC_DEF ; [then]
