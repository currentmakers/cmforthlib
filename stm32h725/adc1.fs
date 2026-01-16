\
\ @file adc1.fs
\ @brief Analog to Digital Converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief ADC interrupt and status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant ADC1_ADC_ISR_ADRDY                               \ ADC ready This bit is set by hardware after the ADC has been enabled (bit ADEN=1) and when the ADC reaches a state where it is ready to accept conversion requests. It is cleared by software writing 1 to it.
$00000002 constant ADC1_ADC_ISR_EOSMP                               \ End of sampling flag This bit is set by hardware during the conversion of any channel (only for regular channels), at the end of the sampling phase.
$00000004 constant ADC1_ADC_ISR_EOC                                 \ End of conversion flag This bit is set by hardware at the end of each regular conversion of a channel when a new data is available in the ADC_DR register. It is cleared by software writing 1 to it or by reading the ADC_DR register
$00000008 constant ADC1_ADC_ISR_EOS                                 \ End of regular sequence flag This bit is set by hardware at the end of the conversions of a regular sequence of channels. It is cleared by software writing 1 to it.
$00000010 constant ADC1_ADC_ISR_OVR                                 \ ADC overrun This bit is set by hardware when an overrun occurs on a regular channel, meaning that a new conversion has completed while the EOC flag was already set. It is cleared by software writing 1 to it.
$00000020 constant ADC1_ADC_ISR_JEOC                                \ Injected channel end of conversion flag This bit is set by hardware at the end of each injected conversion of a channel when a new data is available in the corresponding ADC_JDRy register. It is cleared by software writing 1 to it or by reading the corresponding ADC_JDRy register
$00000040 constant ADC1_ADC_ISR_JEOS                                \ Injected channel end of sequence flag This bit is set by hardware at the end of the conversions of all injected channels in the group. It is cleared by software writing 1 to it.
$00000080 constant ADC1_ADC_ISR_AWD1                                \ Analog watchdog 1 flag This bit is set by hardware when the converted voltage crosses the values programmed in the fields LT1[11:0] and HT1[11:0] of ADC_TR1 register. It is cleared by software. writing 1 to it.
$00000100 constant ADC1_ADC_ISR_AWD2                                \ Analog watchdog 2 flag This bit is set by hardware when the converted voltage crosses the values programmed in the fields LT2[7:0] and HT2[7:0] of ADC_TR2 register. It is cleared by software writing 1 to it.
$00000200 constant ADC1_ADC_ISR_AWD3                                \ Analog watchdog 3 flag This bit is set by hardware when the converted voltage crosses the values programmed in the fields LT3[7:0] and HT3[7:0] of ADC_TR3 register. It is cleared by software writing 1 to it.
$00000400 constant ADC1_ADC_ISR_JQOVF                               \ Injected context queue overflow This bit is set by hardware when an Overflow of the Injected Queue of Context occurs. It is cleared by software writing 1 to it. Refer to for more information.
$00001000 constant ADC1_ADC_ISR_LDORDY                              \ ADC LDO output voltage ready bit This bit is set and cleared by hardware. It indicates that the ADC internal LDO output is ready and that the ADC can be enabled or calibrated. Note: Refer to for the availability of the LDO regulator.


\
\ @brief ADC interrupt enable register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant ADC1_ADC_IER_ADRDYIE                             \ ADC ready interrupt enable This bit is set and cleared by software to enable/disable the ADC Ready interrupt. Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00000002 constant ADC1_ADC_IER_EOSMPIE                             \ End of sampling flag interrupt enable for regular conversions This bit is set and cleared by software to enable/disable the end of the sampling phase interrupt for regular conversions. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no regular conversion is ongoing).
$00000004 constant ADC1_ADC_IER_EOCIE                               \ End of regular conversion interrupt enable This bit is set and cleared by software to enable/disable the end of a regular conversion interrupt. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no regular conversion is ongoing).
$00000008 constant ADC1_ADC_IER_EOSIE                               \ End of regular sequence of conversions interrupt enable This bit is set and cleared by software to enable/disable the end of regular sequence of conversions interrupt. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no regular conversion is ongoing).
$00000010 constant ADC1_ADC_IER_OVRIE                               \ Overrun interrupt enable This bit is set and cleared by software to enable/disable the Overrun interrupt of a regular conversion. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no regular conversion is ongoing).
$00000020 constant ADC1_ADC_IER_JEOCIE                              \ End of injected conversion interrupt enable This bit is set and cleared by software to enable/disable the end of an injected conversion interrupt. Note: The software is allowed to write this bit only when JADSTART is cleared to 0 (no injected conversion is ongoing).
$00000040 constant ADC1_ADC_IER_JEOSIE                              \ End of injected sequence of conversions interrupt enable This bit is set and cleared by software to enable/disable the end of injected sequence of conversions interrupt. Note: The software is allowed to write this bit only when JADSTART=0 (which ensures that no injected conversion is ongoing).
$00000080 constant ADC1_ADC_IER_AWD1IE                              \ Analog watchdog 1 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog 1 interrupt. Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00000100 constant ADC1_ADC_IER_AWD2IE                              \ Analog watchdog 2 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog 2 interrupt. Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00000200 constant ADC1_ADC_IER_AWD3IE                              \ Analog watchdog 3 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog 2 interrupt. Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00000400 constant ADC1_ADC_IER_JQOVFIE                             \ Injected context queue overflow interrupt enable This bit is set and cleared by software to enable/disable the Injected Context Queue Overflow interrupt. Note: The software is allowed to write this bit only when JADSTART=0 (which ensures that no injected conversion is ongoing).


\
\ @brief ADC control register
\ Address offset: 0x08
\ Reset value: 0x20000000
\

$00000001 constant ADC1_ADC_CR_ADEN                                 \ ADC enable control This bit is set by software to enable the ADC. The ADC will be effectively ready to operate once the flag ADRDY has been set. It is cleared by hardware when the ADC is disabled, after the execution of the ADDIS command. Note: The software is allowed to set ADEN only when all bits of ADC_CR registers are 0 (ADCAL=0, JADSTART=0, ADSTART=0, ADSTP=0, ADDIS=0 and ADEN=0) except for bit ADVREGEN which must be 1 (and the software must have wait for the startup time of the voltage regulator)
$00000002 constant ADC1_ADC_CR_ADDIS                                \ ADC disable command This bit is set by software to disable the ADC (ADDIS command) and put it into power-down state (OFF state). It is cleared by hardware once the ADC is effectively disabled (ADEN is also cleared by hardware at this time). Note: The software is allowed to set ADDIS only when ADEN=1 and both ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing)
$00000004 constant ADC1_ADC_CR_ADSTART                              \ ADC start of regular conversion This bit is set by software to start ADC conversion of regular channels. Depending on the configuration bits EXTEN, a conversion will start immediately (software trigger configuration) or once a regular hardware trigger event occurs (hardware trigger configuration). It is cleared by hardware: in single conversion mode (CONT=0, DISCEN=0) when software trigger is selected (EXTEN=0x0): at the assertion of the End of Regular Conversion Sequence (EOS) flag. In discontinuous conversion mode (CONT=0, DISCEN=1), when the software trigger is selected (EXTEN=0x0): at the end of conversion (EOC) flag. in all other cases: after the execution of the ADSTP command, at the same time that ADSTP is cleared by hardware. Note: The software is allowed to set ADSTART only when ADEN=1 and ADDIS=0 (ADC is enabled and there is no pending request to disable the ADC) In auto-injection mode (JAUTO=1), regular and auto-injected conversions are started by setting bit ADSTART (JADSTART must be kept cleared)
$00000008 constant ADC1_ADC_CR_JADSTART                             \ ADC start of injected conversion This bit is set by software to start ADC conversion of injected channels. Depending on the configuration bits JEXTEN, a conversion will start immediately (software trigger configuration) or once an injected hardware trigger event occurs (hardware trigger configuration). It is cleared by hardware: in single conversion mode when software trigger is selected (JEXTSEL=0x0): at the assertion of the End of Injected Conversion Sequence (JEOS) flag. in all cases: after the execution of the JADSTP command, at the same time that JADSTP is cleared by hardware. Note: The software is allowed to set JADSTART only when ADEN=1 and ADDIS=0 (ADC is enabled and there is no pending request to disable the ADC). In auto-injection mode (JAUTO=1), regular and auto-injected conversions are started by setting bit ADSTART (JADSTART must be kept cleared)
$00000010 constant ADC1_ADC_CR_ADSTP                                \ ADC stop of regular conversion command This bit is set by software to stop and discard an ongoing regular conversion (ADSTP Command). It is cleared by hardware when the conversion is effectively discarded and the ADC regular sequence and triggers can be re-configured. The ADC is then ready to accept a new start of regular conversions (ADSTART command). Note: The software is allowed to set ADSTP only when ADSTART=1 and ADDIS=0 (ADC is enabled and eventually converting a regular conversion and there is no pending request to disable the ADC). In auto-injection mode (JAUTO=1), setting ADSTP bit aborts both regular and injected conversions (do not use JADSTP). In dual ADC regular simultaneous mode and interleaved mode, the bit ADSTP of the master ADC must be used to stop regular conversions. The other ADSTP bit is inactive.
$00000020 constant ADC1_ADC_CR_JADSTP                               \ ADC stop of injected conversion command This bit is set by software to stop and discard an ongoing injected conversion (JADSTP Command). It is cleared by hardware when the conversion is effectively discarded and the ADC injected sequence and triggers can be re-configured. The ADC is then ready to accept a new start of injected conversions (JADSTART command). Note: The software is allowed to set JADSTP only when JADSTART=1 and ADDIS=0 (ADC is enabled and eventually converting an injected conversion and there is no pending request to disable the ADC). In auto-injection mode (JAUTO=1), setting ADSTP bit aborts both regular and injected conversions (do not use JADSTP)
$00000300 constant ADC1_ADC_CR_BOOST                                \ Boost mode control This bitfield is set and cleared by software to enable/disable the Boost mode. Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing). When dual mode is enabled (bits DAMDF of ADCx_CCR register are not equal to zero), the BOOST bitfield of the slave ADC is no more writable and its content must be equal to the master ADC BOOST bitfield.
$00010000 constant ADC1_ADC_CR_ADCALLIN                             \ Linearity calibration This bit is set and cleared by software to enable the Linearity calibration. Note: The software is allowed to write this bit only when the ADC is disabled and is not calibrating (ADCAL=0, JADSTART=0, JADSTP=0, ADSTART=0, ADSTP=0, ADDIS=0 and ADEN=0).
$00400000 constant ADC1_ADC_CR_LINCALRDYW1                          \ Linearity calibration ready Word 1 Refer to LINCALRDYW6 description. Note: ADC_CALFACT2[29:0] corresponds linearity correction factor bits[29:0]. The software is allowed to toggle this bit only if the LINCALRDYW6, LINCALRDYW5, LINCALRDYW4, LINCALRDYW3 and LINCALRDYW2 bits are left unchanged.
$00800000 constant ADC1_ADC_CR_LINCALRDYW2                          \ Linearity calibration ready Word 2 Refer to LINCALRDYW6 description. Note: ADC_CALFACT2[29:0] corresponds linearity correction factor bits[59:30]. The software is allowed to toggle this bit only if the LINCALRDYW6, LINCALRDYW5, LINCALRDYW4, LINCALRDYW3 and LINCALRDYW1 bits are left unchanged.
$01000000 constant ADC1_ADC_CR_LINCALRDYW3                          \ Linearity calibration ready Word 3 Refer to LINCALRDYW6 description. Note: ADC_CALFACT2[29:0] corresponds linearity correction factor bits[89:60]. The software is allowed to toggle this bit only if the LINCALRDYW6, LINCALRDYW5, LINCALRDYW4, LINCALRDYW2 and LINCALRDYW1 bits are left unchanged.
$02000000 constant ADC1_ADC_CR_LINCALRDYW4                          \ Linearity calibration ready Word 4 Refer to LINCALRDYW6 description. Note: ADC_CALFACT2[29:0] correspond linearity correction factor bits[119:90]. The software is allowed to toggle this bit only if the LINCALRDYW6, LINCALRDYW5, LINCALRDYW3, LINCALRDYW2 and LINCALRDYW1 bits are left unchanged.
$04000000 constant ADC1_ADC_CR_LINCALRDYW5                          \ Linearity calibration ready Word 5 Refer to LINCALRDYW6 description. Note: ADC_CALFACT2[29:0] corresponds linearity correction factor bits[149:120]. The software is allowed to toggle this bit only if the LINCALRDYW6, LINCALRDYW5, LINCALRDYW3, LINCALRDYW2 and LINCALRDYW1 bits are left unchanged.
$08000000 constant ADC1_ADC_CR_LINCALRDYW6                          \ Linearity calibration ready Word 6 This control / status bit allows to read/write the 6th linearity calibration factor. When the linearity calibration is complete, this bit is set. A bit clear will launch the transfer of the linearity factor 6 into the LINCALFACT[29:0] of the ADC_CALFACT2 register. The bit will be reset by hardware when the ADC_CALFACT2 register can be read (software must poll the bit until it is cleared). When the LINCALRDYW6 bit is reset, a new linearity factor 6 value can be written into the LINCALFACT[29:0] of the ADC_CALFACT2 register. A bit set will launch the linearity factor 6 update and the bit will be effectively set by hardware once the update will be done (software must poll the bit until it is set to indicate the write is effective). Note: ADC_CALFACT2[29:10] contains 0. ADC_CALFACT2[9:0] corresponds linearity correction factor bits[159:150]. The software is allowed to toggle this bit only if the LINCALRDYW5, LINCALRDYW4, LINCALRDYW3, LINCALRDYW2 and LINCALRDYW1 bits are left unchanged, see chapter for details. The software is allowed to update the linearity calibration factor by writing LINCALRDYWx only when ADEN=1 and ADSTART=0 and JADSTART=0 (ADC enabled and no conversion is ongoing)
$10000000 constant ADC1_ADC_CR_ADVREGEN                             \ ADC voltage regulator enable This bits is set by software to enable the ADC voltage regulator. Before performing any operation such as launching a calibration or enabling the ADC, the ADC voltage regulator must first be enabled and the software must wait for the regulator start-up time. For more details about the ADC voltage regulator enable and disable sequences, refer to (ADVREGEN). The software can program this bitfield only when the ADC is disabled (ADCAL=0, JADSTART=0, ADSTART=0, ADSTP=0, ADDIS=0 and ADEN=0).
$20000000 constant ADC1_ADC_CR_DEEPPWD                              \ Deep-power-down enable This bit is set and cleared by software to put the ADC in deep-power-down mode. Note: The software is allowed to write this bit only when the ADC is disabled (ADCAL=0, JADSTART=0, JADSTP=0, ADSTART=0, ADSTP=0, ADDIS=0 and ADEN=0).
$40000000 constant ADC1_ADC_CR_ADCALDIF                             \ Differential mode for calibration This bit is set and cleared by software to configure the single-ended or differential inputs mode for the calibration. Note: The software is allowed to write this bit only when the ADC is disabled and is not calibrating (ADCAL=0, JADSTART=0, JADSTP=0, ADSTART=0, ADSTP=0, ADDIS=0 and ADEN=0).
$80000000 constant ADC1_ADC_CR_ADCAL                                \ ADC calibration This bit is set by software to start the calibration of the ADC. Program first the bit ADCALDIF to determine if this calibration applies for single-ended or differential inputs mode. It is cleared by hardware after calibration is complete. Note: The software is allowed to launch a calibration by setting ADCAL only when ADEN=0. The software is allowed to update the calibration factor by writing ADC_CALFACT only when ADEN=1 and ADSTART=0 and JADSTART=0 (ADC enabled and no conversion is ongoing)


\
\ @brief ADC configuration register
\ Address offset: 0x0C
\ Reset value: 0x80000000
\

$00000003 constant ADC1_ADC_CFGR_DMNGT                              \ Data Management configuration This bit is set and cleared by software to select how ADC interface output data are managed. Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing). In dual-ADC modes, this bit is not relevant and replaced by control bit DAMDF of the ADCx_CCR register.
$0000001c constant ADC1_ADC_CFGR_RES                                \ Data resolution These bits are written by software to select the resolution of the conversion. Others: Reserved, must not be used. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$000003e0 constant ADC1_ADC_CFGR_EXTSEL                             \ External trigger selection for regular group These bits select the external event used to trigger the start of conversion of a regular group: ... Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
$00000c00 constant ADC1_ADC_CFGR_EXTEN                              \ External trigger enable and polarity selection for regular channels These bits are set and cleared by software to select the external trigger polarity and enable the trigger of a regular group. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
$00001000 constant ADC1_ADC_CFGR_OVRMOD                             \ Overrun Mode This bit is set and cleared by software and configure the way data overrun is managed. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no regular conversion is ongoing).
$00002000 constant ADC1_ADC_CFGR_CONT                               \ Single / continuous conversion mode for regular conversions This bit is set and cleared by software. If it is set, regular conversion takes place continuously until it is cleared. Note: It is not possible to have both discontinuous mode and continuous mode enabled: it is forbidden to set both DISCEN=1 and CONT=1. The software is allowed to write this bit only when ADSTART=0 (which ensures that no regular conversion is ongoing). When dual mode is enabled (DAMDF bits in ADCx_CCR register are not equal to zero), the bit CONT of the slave ADC is no more writable and its content is equal to the bit CONT of the master ADC.
$00004000 constant ADC1_ADC_CFGR_AUTDLY                             \ Delayed conversion mode This bit is set and cleared by software to enable/disable the Auto Delayed Conversion mode.. Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing). When dual mode is enabled (DAMDF bits in ADCx_CCR register are not equal to zero), the bit AUTDLY of the slave ADC is no more writable and its content is equal to the bit AUTDLY of the master ADC.
$00010000 constant ADC1_ADC_CFGR_DISCEN                             \ Discontinuous mode for regular channels This bit is set and cleared by software to enable/disable Discontinuous mode for regular channels. Note: It is not possible to have both discontinuous mode and continuous mode enabled: it is forbidden to set both DISCEN=1 and CONT=1. It is not possible to use both auto-injected mode and discontinuous mode simultaneously: the bits DISCEN and JDISCEN must be kept cleared by software when JAUTO is set. The software is allowed to write this bit only when ADSTART=0 (which ensures that no regular conversion is ongoing). When dual mode is enabled (DAMDF bits in ADCx_CCR register are not equal to zero), the bit DISCEN of the slave ADC is no more writable and its content is equal to the bit DISCEN of the master ADC.
$000e0000 constant ADC1_ADC_CFGR_DISCNUM                            \ Discontinuous mode channel count These bits are written by software to define the number of regular channels to be converted in discontinuous mode, after receiving an external trigger. ... Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing). When dual mode is enabled (DAMDF bits in ADCx_CCR register are not equal to zero), the bits DISCNUM[2:0] of the slave ADC are no more writable and their content is equal to the bits DISCNUM[2:0] of the master ADC.
$00100000 constant ADC1_ADC_CFGR_JDISCEN                            \ Discontinuous mode on injected channels This bit is set and cleared by software to enable/disable discontinuous mode on the injected channels of a group. Note: The software is allowed to write this bit only when JADSTART=0 (which ensures that no injected conversion is ongoing). It is not possible to use both auto-injected mode and discontinuous mode simultaneously: the bits DISCEN and JDISCEN must be kept cleared by software when JAUTO is set. When dual mode is enabled (bits DAMDF of ADCx_CCR register are not equal to zero), the bit JDISCEN of the slave ADC is no more writable and its content is equal to the bit JDISCEN of the master ADC.
$00200000 constant ADC1_ADC_CFGR_JQM                                \ JSQR queue mode This bit is set and cleared by software. It defines how an empty Queue is managed. Refer to for more information. Note: The software is allowed to write this bit only when JADSTART=0 (which ensures that no injected conversion is ongoing). When dual mode is enabled (DAMDF bits in ADCx_CCR register are not equal to zero), the bit JQM of the slave ADC is no more writable and its content is equal to the bit JQM of the master ADC.
$00400000 constant ADC1_ADC_CFGR_AWD1SGL                            \ Enable the watchdog 1 on a single channel or on all channels This bit is set and cleared by software to enable the analog watchdog on the channel identified by the AWD1CH[4:0] bits or on all the channels Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00800000 constant ADC1_ADC_CFGR_AWD1EN                             \ Analog watchdog 1 enable on regular channels This bit is set and cleared by software Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no regular conversion is ongoing).
$01000000 constant ADC1_ADC_CFGR_JAWD1EN                            \ Analog watchdog 1 enable on injected channels This bit is set and cleared by software Note: The software is allowed to write this bit only when JADSTART=0 (which ensures that no injected conversion is ongoing).
$02000000 constant ADC1_ADC_CFGR_JAUTO                              \ Automatic injected group conversion This bit is set and cleared by software to enable/disable automatic injected group conversion after regular group conversion. Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no regular nor injected conversion is ongoing). When dual mode is enabled (DAMDF bits in ADCx_CCR register are not equal to zero), the bit JAUTO of the slave ADC is no more writable and its content is equal to the bit JAUTO of the master ADC.
$7c000000 constant ADC1_ADC_CFGR_AWD1CH                             \ Analog watchdog 1 channel selection These bits are set and cleared by software. They select the input channel to be guarded by the analog watchdog. ..... others: Reserved, must not be used Note: The channel selected by AWD1CH must be also selected into the SQRi or JSQRi registers. The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$80000000 constant ADC1_ADC_CFGR_JQDIS                              \ Injected Queue disable These bits are set and cleared by software to disable the Injected Queue mechanism: Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no regular nor injected conversion is ongoing). A set or reset of JQDIS bit causes the injected queue to be flushed and the JSQR register is cleared.


\
\ @brief ADC configuration register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant ADC1_ADC_CFGR2_ROVSE                             \ Regular Oversampling Enable This bit is set and cleared by software to enable regular oversampling. Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing)
$00000002 constant ADC1_ADC_CFGR2_JOVSE                             \ Injected Oversampling Enable This bit is set and cleared by software to enable injected oversampling. Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing)
$000001e0 constant ADC1_ADC_CFGR2_OVSS                              \ Oversampling right shift This bitfield is set and cleared by software to define the right shifting applied to the raw oversampling result. Others: Reserved, must not be used. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no conversion is ongoing).
$00000200 constant ADC1_ADC_CFGR2_TROVS                             \ Triggered Regular Oversampling This bit is set and cleared by software to enable triggered oversampling Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
$00000400 constant ADC1_ADC_CFGR2_ROVSM                             \ Regular Oversampling mode This bit is set and cleared by software to select the regular oversampling mode. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
$00000800 constant ADC1_ADC_CFGR2_RSHIFT1                           \ Right-shift data after Offset 1 correction This bitfield is set and cleared by software to right-shift 1-bit data after offset1 correction. This bit can only be used for 8-bit and 16-bit data format (see (ADC_DR, ADC_JDRy, OFFSETy, OFFSETy_CH, OVSS, LSHIFT, RSHIFT, SSATE) for details).
$00001000 constant ADC1_ADC_CFGR2_RSHIFT2                           \ Right-shift data after Offset 2 correction Refer to RSHIFT1 description
$00002000 constant ADC1_ADC_CFGR2_RSHIFT3                           \ Right-shift data after Offset 3 correction Refer to RSHIFT1 description
$00004000 constant ADC1_ADC_CFGR2_RSHIFT4                           \ Right-shift data after Offset 4 correction Refer to RSHIFT1 description.
$03ff0000 constant ADC1_ADC_CFGR2_OSVR                              \ Oversampling ratio This bitfield is set and cleared by software to define the oversampling ratio. 2: 3x ... 1023: 1024x Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
$f0000000 constant ADC1_ADC_CFGR2_LSHIFT                            \ Left shift factor This bitfield is set and cleared by software to define the left shifting applied to the final result with or without oversampling. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).


\
\ @brief ADC sample time register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000007 constant ADC1_ADC_SMPR1_SMP0                              \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00000038 constant ADC1_ADC_SMPR1_SMP1                              \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$000001c0 constant ADC1_ADC_SMPR1_SMP2                              \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00000e00 constant ADC1_ADC_SMPR1_SMP3                              \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00007000 constant ADC1_ADC_SMPR1_SMP4                              \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00038000 constant ADC1_ADC_SMPR1_SMP5                              \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$001c0000 constant ADC1_ADC_SMPR1_SMP6                              \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00e00000 constant ADC1_ADC_SMPR1_SMP7                              \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$07000000 constant ADC1_ADC_SMPR1_SMP8                              \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$38000000 constant ADC1_ADC_SMPR1_SMP9                              \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).


\
\ @brief ADC sample time register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000007 constant ADC1_ADC_SMPR2_SMP10                             \ Channel x sampling time selection (x = 10 to 19) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00000038 constant ADC1_ADC_SMPR2_SMP11                             \ Channel x sampling time selection (x = 10 to 19) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$000001c0 constant ADC1_ADC_SMPR2_SMP12                             \ Channel x sampling time selection (x = 10 to 19) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00000e00 constant ADC1_ADC_SMPR2_SMP13                             \ Channel x sampling time selection (x = 10 to 19) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00007000 constant ADC1_ADC_SMPR2_SMP14                             \ Channel x sampling time selection (x = 10 to 19) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00038000 constant ADC1_ADC_SMPR2_SMP15                             \ Channel x sampling time selection (x = 10 to 19) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$001c0000 constant ADC1_ADC_SMPR2_SMP16                             \ Channel x sampling time selection (x = 10 to 19) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00e00000 constant ADC1_ADC_SMPR2_SMP17                             \ Channel x sampling time selection (x = 10 to 19) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$07000000 constant ADC1_ADC_SMPR2_SMP18                             \ Channel x sampling time selection (x = 10 to 19) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$38000000 constant ADC1_ADC_SMPR2_SMP19                             \ Channel x sampling time selection (x = 10 to 19) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).


\
\ @brief ADC channel preselection register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant ADC1_ADC_PCSEL_PCSEL0                            \ :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00000002 constant ADC1_ADC_PCSEL_PCSEL1                            \ :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00000004 constant ADC1_ADC_PCSEL_PCSEL2                            \ :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00000008 constant ADC1_ADC_PCSEL_PCSEL3                            \ :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00000010 constant ADC1_ADC_PCSEL_PCSEL4                            \ :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00000020 constant ADC1_ADC_PCSEL_PCSEL5                            \ :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00000040 constant ADC1_ADC_PCSEL_PCSEL6                            \ :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00000080 constant ADC1_ADC_PCSEL_PCSEL7                            \ :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00000100 constant ADC1_ADC_PCSEL_PCSEL8                            \ :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00000200 constant ADC1_ADC_PCSEL_PCSEL9                            \ :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00000400 constant ADC1_ADC_PCSEL_PCSEL10                           \ :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00000800 constant ADC1_ADC_PCSEL_PCSEL11                           \ :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00001000 constant ADC1_ADC_PCSEL_PCSEL12                           \ :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00002000 constant ADC1_ADC_PCSEL_PCSEL13                           \ :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00004000 constant ADC1_ADC_PCSEL_PCSEL14                           \ :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00008000 constant ADC1_ADC_PCSEL_PCSEL15                           \ :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00010000 constant ADC1_ADC_PCSEL_PCSEL16                           \ :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00020000 constant ADC1_ADC_PCSEL_PCSEL17                           \ :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00040000 constant ADC1_ADC_PCSEL_PCSEL18                           \ :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$00080000 constant ADC1_ADC_PCSEL_PCSEL19                           \ :Channel x (VINP[i]) pre selection (x = 0 to 19) These bits are written by software to pre select the input channel at IO instance to be converted. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).


\
\ @brief ADC watchdog threshold register 1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$03ffffff constant ADC1_ADC_LTR1_LTR1                               \ Analog watchdog 1 lower threshold These bits are written by software to define the lower threshold for the analog watchdog 1. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy) Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).


\
\ @brief ADC watchdog threshold register 1
\ Address offset: 0x24
\ Reset value: 0x03FFFFFF
\

$03ffffff constant ADC1_ADC_HTR1_HTR1                               \ Analog watchdog 1 higher threshold These bits are written by software to define the higher threshold for the analog watchdog 1. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy) Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).


\
\ @brief ADC regular sequence register 1
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000000f constant ADC1_ADC_SQR1_L                                  \ Regular channel sequence length These bits are written by software to define the total number of conversions in the regular channel conversion sequence. ... Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
$000007c0 constant ADC1_ADC_SQR1_SQ1                                \ 1st conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 1st in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
$0001f000 constant ADC1_ADC_SQR1_SQ2                                \ 2nd conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 2nd in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
$007c0000 constant ADC1_ADC_SQR1_SQ3                                \ 3rd conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 3rd in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
$1f000000 constant ADC1_ADC_SQR1_SQ4                                \ 4th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 4th in the regular conversion sequence.


\
\ @brief ADC regular sequence register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000001f constant ADC1_ADC_SQR2_SQ5                                \ 5th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 5th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
$000007c0 constant ADC1_ADC_SQR2_SQ6                                \ 6th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 6th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
$0001f000 constant ADC1_ADC_SQR2_SQ7                                \ 7th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 7th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
$007c0000 constant ADC1_ADC_SQR2_SQ8                                \ 8th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 8th in the regular conversion sequence Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
$1f000000 constant ADC1_ADC_SQR2_SQ9                                \ 9th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 9th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).


\
\ @brief ADC regular sequence register 3
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant ADC1_ADC_SQR3_SQ10                               \ 10th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 10th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
$000007c0 constant ADC1_ADC_SQR3_SQ11                               \ 11th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 11th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
$0001f000 constant ADC1_ADC_SQR3_SQ12                               \ 12th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 12th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
$007c0000 constant ADC1_ADC_SQR3_SQ13                               \ 13th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 13th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
$1f000000 constant ADC1_ADC_SQR3_SQ14                               \ 14th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 14th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).


\
\ @brief ADC regular sequence register 4
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000001f constant ADC1_ADC_SQR4_SQ15                               \ 15th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 15th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).
$000007c0 constant ADC1_ADC_SQR4_SQ16                               \ 16th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 16th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART=0 (which ensures that no regular conversion is ongoing).


\
\ @brief ADC regular Data Register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant ADC1_ADC_DR_RDATA                                \ Regular Data converted These bits are read-only. They contain the conversion result from the last converted regular channel. The data are left- or right-aligned as described in .


\
\ @brief ADC injected sequence register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000003 constant ADC1_ADC_JSQR_JL                                 \ Injected channel sequence length These bits are written by software to define the total number of conversions in the injected channel conversion sequence. Note: The software is allowed to write these bits only when JADSTART is cleared to 0 (no injected conversion is ongoing).
$0000007c constant ADC1_ADC_JSQR_JEXTSEL                            \ External trigger selection for injected group These bits select the external event used to trigger the start of conversion of an injected group: ... Note: The software is allowed to write these bits only when JADSTART is cleared to 0 (no injected conversion is ongoing).
$00000180 constant ADC1_ADC_JSQR_JEXTEN                             \ External trigger enable and polarity selection for injected channels These bits are set and cleared by software to select the external trigger polarity and enable the trigger of an injected group. If JQDIS=1 (queue disabled), Hardware trigger detection disabled (conversions can be launched by software Note: The software is allowed to write these bits only when JADSTART is cleared to 0 (no injected conversion is ongoing). If JQM=1 and if the Queue of Context becomes empty, the software and hardware triggers of the injected sequence are both internally disabled (refer to Queue of context for injected conversions)
$00003e00 constant ADC1_ADC_JSQR_JSQ1                               \ 1st conversion in the injected sequence These bits are written by software with the channel number (0..19) assigned as the 1st in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART is cleared to 0 (no injected conversion is ongoing) unless the context queue is enabled (JQDIS=0 in ADC_CFGR register).
$000f8000 constant ADC1_ADC_JSQR_JSQ2                               \ 2nd conversion in the injected sequence These bits are written by software with the channel number (0..19) assigned as the 2nd in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART is cleared to 0 (no injected conversion is ongoing) unless the context queue is enabled (JQDIS=0 in ADC_CFGR register).
$03e00000 constant ADC1_ADC_JSQR_JSQ3                               \ 3rd conversion in the injected sequence These bits are written by software with the channel number (0..19) assigned as the 3rd in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART is cleared to 0 (no injected conversion is ongoing) unless the context queue is enabled (JQDIS=0 in ADC_CFGR register).
$f8000000 constant ADC1_ADC_JSQR_JSQ4                               \ 4th conversion in the injected sequence These bits are written by software with the channel number (0..19) assigned as the 4th in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART is cleared to 0 (no injected conversion is ongoing) unless the context queue is enabled (JQDIS=0 in ADC_CFGR register).


\
\ @brief ADC injected channel 1 offset register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$03ffffff constant ADC1_ADC_OFR1_OFFSET1                            \ Data offset y for the channel programmed into bits OFFSETy_CH[4:0] These bits are written by software to define the offset y to be subtracted from the raw converted data when converting a channel (can be regular or injected). The channel to which applies the data offset y must be programmed in the bits OFFSETy_CH[4:0]. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). When OFFSETy[25:0] bitfield is reset, the offset compensation is disabled. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing). If several offset (OFFSETy) point to the same channel, only the offset with the lowest x value is considered for the subtraction. Ex: if OFFSET1_CH[4:0]=4 and OFFSET2_CH[4:0]=4, this is OFFSET1[25:0] which is subtracted when converting channel 4.
$7c000000 constant ADC1_ADC_OFR1_OFFSET1_CH                         \ Channel selection for the Data offset y These bits are written by software to define the channel to which the offset programmed into bits OFFSETy[25:0] will apply. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$80000000 constant ADC1_ADC_OFR1_SSATE                              \ Signed saturation Enable This bit is written by software to enable or disable the Signed saturation feature. This bit can be enabled only for 8-bit and 16-bit data format (see alignment and offset (ADC_DR, ADC_JDRy, OFFSETy, OFFSETy_CH, OVSS, LSHIFT, RSHIFT, SSATE) for details). Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).


\
\ @brief ADC injected channel 2 offset register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$03ffffff constant ADC1_ADC_OFR2_OFFSET2                            \ Data offset y for the channel programmed into bits OFFSETy_CH[4:0] These bits are written by software to define the offset y to be subtracted from the raw converted data when converting a channel (can be regular or injected). The channel to which applies the data offset y must be programmed in the bits OFFSETy_CH[4:0]. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). When OFFSETy[25:0] bitfield is reset, the offset compensation is disabled. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing). If several offset (OFFSETy) point to the same channel, only the offset with the lowest x value is considered for the subtraction. Ex: if OFFSET1_CH[4:0]=4 and OFFSET2_CH[4:0]=4, this is OFFSET1[25:0] which is subtracted when converting channel 4.
$7c000000 constant ADC1_ADC_OFR2_OFFSET2_CH                         \ Channel selection for the Data offset y These bits are written by software to define the channel to which the offset programmed into bits OFFSETy[25:0] will apply. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$80000000 constant ADC1_ADC_OFR2_SSATE                              \ Signed saturation Enable This bit is written by software to enable or disable the Signed saturation feature. This bit can be enabled only for 8-bit and 16-bit data format (see alignment and offset (ADC_DR, ADC_JDRy, OFFSETy, OFFSETy_CH, OVSS, LSHIFT, RSHIFT, SSATE) for details). Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).


\
\ @brief ADC injected channel 3 offset register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$03ffffff constant ADC1_ADC_OFR3_OFFSET3                            \ Data offset y for the channel programmed into bits OFFSETy_CH[4:0] These bits are written by software to define the offset y to be subtracted from the raw converted data when converting a channel (can be regular or injected). The channel to which applies the data offset y must be programmed in the bits OFFSETy_CH[4:0]. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). When OFFSETy[25:0] bitfield is reset, the offset compensation is disabled. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing). If several offset (OFFSETy) point to the same channel, only the offset with the lowest x value is considered for the subtraction. Ex: if OFFSET1_CH[4:0]=4 and OFFSET2_CH[4:0]=4, this is OFFSET1[25:0] which is subtracted when converting channel 4.
$7c000000 constant ADC1_ADC_OFR3_OFFSET3_CH                         \ Channel selection for the Data offset y These bits are written by software to define the channel to which the offset programmed into bits OFFSETy[25:0] will apply. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$80000000 constant ADC1_ADC_OFR3_SSATE                              \ Signed saturation Enable This bit is written by software to enable or disable the Signed saturation feature. This bit can be enabled only for 8-bit and 16-bit data format (see alignment and offset (ADC_DR, ADC_JDRy, OFFSETy, OFFSETy_CH, OVSS, LSHIFT, RSHIFT, SSATE) for details). Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).


\
\ @brief ADC injected channel 4 offset register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$03ffffff constant ADC1_ADC_OFR4_OFFSET4                            \ Data offset y for the channel programmed into bits OFFSETy_CH[4:0] These bits are written by software to define the offset y to be subtracted from the raw converted data when converting a channel (can be regular or injected). The channel to which applies the data offset y must be programmed in the bits OFFSETy_CH[4:0]. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). When OFFSETy[25:0] bitfield is reset, the offset compensation is disabled. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing). If several offset (OFFSETy) point to the same channel, only the offset with the lowest x value is considered for the subtraction. Ex: if OFFSET1_CH[4:0]=4 and OFFSET2_CH[4:0]=4, this is OFFSET1[25:0] which is subtracted when converting channel 4.
$7c000000 constant ADC1_ADC_OFR4_OFFSET4_CH                         \ Channel selection for the Data offset y These bits are written by software to define the channel to which the offset programmed into bits OFFSETy[25:0] will apply. Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).
$80000000 constant ADC1_ADC_OFR4_SSATE                              \ Signed saturation Enable This bit is written by software to enable or disable the Signed saturation feature. This bit can be enabled only for 8-bit and 16-bit data format (see alignment and offset (ADC_DR, ADC_JDRy, OFFSETy, OFFSETy_CH, OVSS, LSHIFT, RSHIFT, SSATE) for details). Note: The software is allowed to write this bit only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).


\
\ @brief ADC injected channel 1 data register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant ADC1_ADC_JDR1_JDATA                              \ Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in .


\
\ @brief ADC injected channel 2 data register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant ADC1_ADC_JDR2_JDATA                              \ Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in .


\
\ @brief ADC injected channel 3 data register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant ADC1_ADC_JDR3_JDATA                              \ Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in .


\
\ @brief ADC injected channel 4 data register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant ADC1_ADC_JDR4_JDATA                              \ Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in .


\
\ @brief ADC analog watchdog 2 configuration register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$000fffff constant ADC1_ADC_AWD2CR_AWD2CH                           \ Analog watchdog 2 channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by the analog watchdog 2. AWD2CH[i] = 0: ADC analog input channel-i is not monitored by AWD2 AWD2CH[i] = 1: ADC analog input channel-i is monitored by AWD2 When AWD2CH[19:0] = 000..0, the analog Watchdog 2 is disabled Note: The channels selected by AWD2CH must be also selected into the SQRi or JSQRi registers. The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).


\
\ @brief ADC analog watchdog 3 configuration register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$000fffff constant ADC1_ADC_AWD3CR_AWD3CH                           \ Analog watchdog 3 channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by the analog watchdog 3. AWD3CH[i] = 0: ADC analog input channel-i is not monitored by AWD3 AWD3CH[i] = 1: ADC analog input channel-i is monitored by AWD3 When AWD3CH[19:0] = 000..0, the analog Watchdog 3 is disabled Note: The channels selected by AWD3CH must be also selected into the SQRi or JSQRi registers. The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).


\
\ @brief ADC watchdog lower threshold register 2
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$03ffffff constant ADC1_ADC_LTR2_LTR2                               \ Analog watchdog 2 lower threshold These bits are written by software to define the lower threshold for the analog watchdog 2. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy). Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).


\
\ @brief ADC watchdog higher threshold register 2
\ Address offset: 0xB4
\ Reset value: 0x03FFFFFF
\

$03ffffff constant ADC1_ADC_HTR2_HTR2                               \ Analog watchdog 2 higher threshold These bits are written by software to define the higher threshold for the analog watchdog 2. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy). Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).


\
\ @brief ADC watchdog lower threshold register 3
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$03ffffff constant ADC1_ADC_LTR3_LTR3                               \ Analog watchdog 3 lower threshold These bits are written by software to define the lower threshold for the analog watchdog 3. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy) Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).


\
\ @brief ADC watchdog higher threshold register 3
\ Address offset: 0xBC
\ Reset value: 0x03FFFFFF
\

$03ffffff constant ADC1_ADC_HTR3_HTR3                               \ Analog watchdog 3 higher threshold These bits are written by software to define the higher threshold for the analog watchdog 3. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy) Note: The software is allowed to write these bits only when ADSTART=0 and JADSTART=0 (which ensures that no conversion is ongoing).


\
\ @brief ADC differential mode selection register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$000fffff constant ADC1_ADC_DIFSEL_DIFSEL                           \ Differential mode for channels 19 to 0 These bits are set and cleared by software. They allow to select if a channel is configured as single ended or differential mode. DIFSEL[i] = 0: ADC analog input channel-i is configured in single ended mode DIFSEL[i] = 1: ADC analog input channel-i is configured in differential mode Note: The software is allowed to write these bits only when the ADC is disabled (ADCAL=0, JADSTART=0, JADSTP=0, ADSTART=0, ADSTP=0, ADDIS=0 and ADEN=0).


\
\ @brief ADC calibration factors register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$000007ff constant ADC1_ADC_CALFACT_CALFACT_S                       \ Calibration Factors In Single-Ended mode These bits are written by hardware or by software. Once a single-ended inputs calibration is complete, they are updated by hardware with the calibration factors. Software can write these bits with a new calibration factor. If the new calibration factor is different from the current one stored into the analog ADC, it will then be applied once a new single-ended conversion is launched. Note: The software is allowed to write these bits only when ADEN=1, ADSTART=0 and JADSTART=0 (ADC is enabled and no calibration is ongoing and no conversion is ongoing).
$07ff0000 constant ADC1_ADC_CALFACT_CALFACT_D                       \ Calibration Factors in differential mode These bits are written by hardware or by software. Once a differential inputs calibration is complete, they are updated by hardware with the calibration factors. Software can write these bits with a new calibration factor. If the new calibration factor is different from the current one stored into the analog ADC, it will then be applied once a new differential conversion is launched. Note: The software is allowed to write these bits only when ADEN=1, ADSTART=0 and JADSTART=0 (ADC is enabled and no calibration is ongoing and no conversion is ongoing).


\
\ @brief ADC calibration factor register 2
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$3fffffff constant ADC1_ADC_CALFACT2_LINCALFACT                     \ Linearity Calibration Factor These bits are written by hardware or by software. They hold 30-bit out of the 160-bit linearity calibration factor. Once a single-ended inputs calibration is complete, they are updated by hardware with the calibration factors. Software can write these bits with a new calibration factor. If the new calibration factor is different from the current one stored into the analog ADC, it will then be applied once a new single-ended calibration is launched. Note: The software is allowed to write these bits only when ADEN=1, ADSTART=0 and JADSTART=0 (ADC is enabled and no calibration is ongoing and no conversion is ongoing).


\
\ @brief Analog to Digital Converter
\
$40022000 constant ADC1_ADC_ISR   \ offset: 0x00 : ADC interrupt and status register
$40022004 constant ADC1_ADC_IER   \ offset: 0x04 : ADC interrupt enable register
$40022008 constant ADC1_ADC_CR    \ offset: 0x08 : ADC control register
$4002200c constant ADC1_ADC_CFGR  \ offset: 0x0C : ADC configuration register
$40022010 constant ADC1_ADC_CFGR2  \ offset: 0x10 : ADC configuration register 2
$40022014 constant ADC1_ADC_SMPR1  \ offset: 0x14 : ADC sample time register 1
$40022018 constant ADC1_ADC_SMPR2  \ offset: 0x18 : ADC sample time register 2
$4002201c constant ADC1_ADC_PCSEL  \ offset: 0x1C : ADC channel preselection register
$40022020 constant ADC1_ADC_LTR1  \ offset: 0x20 : ADC watchdog threshold register 1
$40022024 constant ADC1_ADC_HTR1  \ offset: 0x24 : ADC watchdog threshold register 1
$40022030 constant ADC1_ADC_SQR1  \ offset: 0x30 : ADC regular sequence register 1
$40022034 constant ADC1_ADC_SQR2  \ offset: 0x34 : ADC regular sequence register 2
$40022038 constant ADC1_ADC_SQR3  \ offset: 0x38 : ADC regular sequence register 3
$4002203c constant ADC1_ADC_SQR4  \ offset: 0x3C : ADC regular sequence register 4
$40022040 constant ADC1_ADC_DR    \ offset: 0x40 : ADC regular Data Register
$4002204c constant ADC1_ADC_JSQR  \ offset: 0x4C : ADC injected sequence register
$40022060 constant ADC1_ADC_OFR1  \ offset: 0x60 : ADC injected channel 1 offset register
$40022064 constant ADC1_ADC_OFR2  \ offset: 0x64 : ADC injected channel 2 offset register
$40022068 constant ADC1_ADC_OFR3  \ offset: 0x68 : ADC injected channel 3 offset register
$4002206c constant ADC1_ADC_OFR4  \ offset: 0x6C : ADC injected channel 4 offset register
$40022080 constant ADC1_ADC_JDR1  \ offset: 0x80 : ADC injected channel 1 data register
$40022084 constant ADC1_ADC_JDR2  \ offset: 0x84 : ADC injected channel 2 data register
$40022088 constant ADC1_ADC_JDR3  \ offset: 0x88 : ADC injected channel 3 data register
$4002208c constant ADC1_ADC_JDR4  \ offset: 0x8C : ADC injected channel 4 data register
$400220a0 constant ADC1_ADC_AWD2CR  \ offset: 0xA0 : ADC analog watchdog 2 configuration register
$400220a4 constant ADC1_ADC_AWD3CR  \ offset: 0xA4 : ADC analog watchdog 3 configuration register
$400220b0 constant ADC1_ADC_LTR2  \ offset: 0xB0 : ADC watchdog lower threshold register 2
$400220b4 constant ADC1_ADC_HTR2  \ offset: 0xB4 : ADC watchdog higher threshold register 2
$400220b8 constant ADC1_ADC_LTR3  \ offset: 0xB8 : ADC watchdog lower threshold register 3
$400220bc constant ADC1_ADC_HTR3  \ offset: 0xBC : ADC watchdog higher threshold register 3
$400220c0 constant ADC1_ADC_DIFSEL  \ offset: 0xC0 : ADC differential mode selection register
$400220c4 constant ADC1_ADC_CALFACT  \ offset: 0xC4 : ADC calibration factors register
$400220c8 constant ADC1_ADC_CALFACT2  \ offset: 0xC8 : ADC calibration factor register 2

