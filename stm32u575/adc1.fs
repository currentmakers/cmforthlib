\
\ @file adc1.fs
\ @brief ADC1
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

$00000001 constant ADC1_ADC_ISR_ADRDY                               \ ADC ready This bit is set by hardware after the ADC has been enabled (bit ADEN = 1) and when the ADC reaches a state where it is ready to accept conversion requests. It is cleared by software writing 1 to it.
$00000002 constant ADC1_ADC_ISR_EOSMP                               \ End of sampling flag This bit is set by hardware during the conversion of any channel (only for regular channels), at the end of the sampling phase.
$00000004 constant ADC1_ADC_ISR_EOC                                 \ End of conversion flag This bit is set by hardware at the end of each regular conversion of a channel when a new data is available in the ADC_DR register. It is cleared by software writing 1 to it or by reading the ADC_DR register
$00000008 constant ADC1_ADC_ISR_EOS                                 \ End of regular sequence flag This bit is set by hardware at the end of the conversions of a regular sequence of channels. It is cleared by software writing 1 to it.
$00000010 constant ADC1_ADC_ISR_OVR                                 \ ADC overrun This bit is set by hardware when an overrun occurs on a regular channel, meaning that a new conversion has completed while the EOC flag was already set. It is cleared by software writing 1 to it.
$00000020 constant ADC1_ADC_ISR_JEOC                                \ Injected channel end of conversion flag This bit is set by hardware at the end of each injected conversion of a channel when a new data is available in the corresponding ADC_JDRy register. It is cleared by software writing 1 to it or by reading the corresponding ADC_JDRy register
$00000040 constant ADC1_ADC_ISR_JEOS                                \ Injected channel end of sequence flag This bit is set by hardware at the end of the conversions of all injected channels in the group. It is cleared by software writing 1 to it.
$00000080 constant ADC1_ADC_ISR_AWD1                                \ Analog watchdog 1 flag This bit is set by hardware when the converted voltage crosses the values programmed in the fields LT1[11:0] and HT1[11:0] of ADC_LTR1, & ADC_HTR1 register. It is cleared by software. writing 1 to it.
$00000100 constant ADC1_ADC_ISR_AWD2                                \ Analog watchdog 2 flag This bit is set by hardware when the converted voltage crosses the values programmed in the fields LT2[7:0] and HT2[7:0] of ADC_LTR2 & ADC_HTR2 register. It is cleared by software writing 1 to it.
$00000200 constant ADC1_ADC_ISR_AWD3                                \ Analog watchdog 3 flag This bit is set by hardware when the converted voltage crosses the values programmed in the fields LT3[7:0] and HT3[7:0] of ADC_LTR3 & ADC_HTR3 register. It is cleared by software writing 1 to it.
$00001000 constant ADC1_ADC_ISR_LDORDY                              \ ADC voltage regulator ready This bit is set by hardware. It indicates that the ADC internal supply is ready. The ADC is available after tADCVREG_SETUP time.


\
\ @brief ADC interrupt enable register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant ADC1_ADC_IER_ADRDYIE                             \ ADC ready interrupt enable This bit is set and cleared by software to enable/disable the ADC Ready interrupt. Note: Software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000002 constant ADC1_ADC_IER_EOSMPIE                             \ End of sampling flag interrupt enable for regular conversions This bit is set and cleared by software to enable/disable the end of the sampling phase interrupt for regular conversions. Note: Software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00000004 constant ADC1_ADC_IER_EOCIE                               \ End of regular conversion interrupt enable This bit is set and cleared by software to enable/disable the end of a regular conversion interrupt. Note: Software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00000008 constant ADC1_ADC_IER_EOSIE                               \ End of regular sequence of conversions interrupt enable This bit is set and cleared by software to enable/disable the end of regular sequence of conversions interrupt. Note: Software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00000010 constant ADC1_ADC_IER_OVRIE                               \ Overrun interrupt enable This bit is set and cleared by software to enable/disable the Overrun interrupt of a regular conversion. Note: Software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00000020 constant ADC1_ADC_IER_JEOCIE                              \ End of injected conversion interrupt enable This bit is set and cleared by software to enable/disable the end of an injected conversion interrupt. Note: Software is allowed to write this bit only when JADSTART = 0 (which ensures that no regular conversion is ongoing).
$00000040 constant ADC1_ADC_IER_JEOSIE                              \ End of injected sequence of conversions interrupt enable This bit is set and cleared by software to enable/disable the end of injected sequence of conversions interrupt. Note: Software is allowed to write this bit only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
$00000080 constant ADC1_ADC_IER_AWD1IE                              \ Analog watchdog 1 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog 1 interrupt. Note: Software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000100 constant ADC1_ADC_IER_AWD2IE                              \ Analog watchdog 2 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog 2 interrupt. Note: Software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000200 constant ADC1_ADC_IER_AWD3IE                              \ Analog watchdog 3 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog 2 interrupt. Note: Software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).


\
\ @brief ADC control register
\ Address offset: 0x08
\ Reset value: 0x20000000
\

$00000001 constant ADC1_ADC_CR_ADEN                                 \ ADC enable control This bit is set by software to enable the ADC. The ADC is effectively ready to operate once the flag ADRDY has been set. It is cleared by hardware when the ADC is disabled, after the execution of the ADDIS command. Note: The software is allowed to set ADEN only when all bits of ADC_CR registers are 0 (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0) except for bit ADVREGEN which must be 1 (and the software must have wait for the startup time of the voltage regulator)
$00000002 constant ADC1_ADC_CR_ADDIS                                \ ADC disable command This bit is set by software to disable the ADC (ADDIS command) and put it into power-down state (OFF state). It is cleared by hardware once the ADC is effectively disabled (ADEN is also cleared by hardware at this time). Note: The software is allowed to set ADDIS only when ADEN = 1 and both ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing)
$00000004 constant ADC1_ADC_CR_ADSTART                              \ ADC start of regular conversion This bit is set by software to start ADC conversion of regular channels. Depending on the configuration bits EXTEN[1:0], a conversion starts immediately (software trigger configuration) or once a regular hardware trigger event occurs (hardware trigger configuration). It is cleared by hardware:  in Single conversion mode (CONT = 0, DISCEN = 0) when software trigger is selected (EXTEN[1:0] = 0x0): at the assertion of the end of regular conversion sequence (EOS) flag. In Discontinuous conversion mode (CONT = 0, DISCEN = 1), when the software trigger is selected (EXTEN[1:0] = 0x0): at the end of conversion (EOC) flag. in all other cases: after the execution of the ADSTP command, at the same time that ADSTP is cleared by hardware. Note: The software is allowed to set ADSTART only when ADEN = 1 and ADDIS = 0 (ADC is enabled and there is no pending request to disable the ADC) In Auto-injection mode (JAUTO = 1), regular and auto-injected conversions are started by setting bit ADSTART (JADSTART must be kept cleared)
$00000008 constant ADC1_ADC_CR_JADSTART                             \ ADC start of injected conversion This bit is set by software to start ADC conversion of injected channels. Depending on the configuration bits JEXTEN[1:0], a conversion starts immediately (software trigger configuration) or once an injected hardware trigger event occurs (hardware trigger configuration). It is cleared by hardware: in Single conversion mode when software trigger is selected (JEXTSEL = 0x0): at the assertion of the end of injected conversion sequence (JEOS) flag. in all cases: after the execution of the JADSTP command, at the same time as JADSTP is cleared by hardware. Note: The software is allowed to set JADSTART only when ADEN = 1 and ADDIS = 0 (ADC is enabled and there is no pending request to disable the ADC). In Auto-injection mode (JAUTO = 1), regular and auto-injected conversions are started by setting bit ADSTART (JADSTART must be kept cleared)
$00000010 constant ADC1_ADC_CR_ADSTP                                \ ADC stop of regular conversion command This bit is set by software to stop and discard an ongoing regular conversion (ADSTP Command). It is cleared by hardware when the conversion is effectively discarded and the ADC regular sequence and triggers can be re-configured. The ADC is then ready to accept a new start of regular conversions (ADSTART command). Note: The software is allowed to set ADSTP only when ADSTART = 1 and ADDIS = 0 (ADC is enabled and eventually converting a regular conversion and there is no pending request to disable the ADC). In Auto-injection mode (JAUTO = 1), setting ADSTP bit aborts both regular and injected conversions (do not use JADSTP).
$00000020 constant ADC1_ADC_CR_JADSTP                               \ ADC stop of injected conversion command This bit is set by software to stop and discard an ongoing injected conversion (JADSTP Command). It is cleared by hardware when the conversion is effectively discarded and the ADC injected sequence and triggers can be re-configured. The ADC is then ready to accept a new start of injected conversions (JADSTART command). Note: The software is allowed to set JADSTP only when JADSTART = 1 and ADDIS = 0 (ADC is enabled and eventually converting an injected conversion and there is no pending request to disable the ADC). In Auto-injection mode (JAUTO = 1), setting ADSTP bit aborts both regular and injected conversions (do not use JADSTP)
$00010000 constant ADC1_ADC_CR_ADCALLIN                             \ Linearity calibration This bit is set and cleared by software to enable the linearity calibration. Note: The software is allowed to write this bit only when the ADC is disabled and is not calibrating (ADCAL = 0, JADSTART = 0, JADSTP = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
$0f000000 constant ADC1_ADC_CR_CALINDEX                             \ Calibration factor This bitfield controls the calibration factor to be read or written. Calibration index 0 is dedicated to single-ended and differential offsets, calibration index 1 to 7 to the linearity calibration factors, and index 8 to the internal offset: Others: Reserved, must not be used Note: ADC_CALFACT2[31:0] correspond to the location of CALINDEX[3:0] calibration factor data (see for details).
$10000000 constant ADC1_ADC_CR_ADVREGEN                             \ ADC voltage regulator enable This bits is set by software to enable the ADC voltage regulator. Before performing any operation such as launching a calibration or enabling the ADC, the ADC voltage regulator must first be enabled and the software must wait for the regulator start-up time. For more details about the ADC voltage regulator enable and disable sequences, refer to (ADVREGEN). The software can program this bit field only when the ADC is disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
$20000000 constant ADC1_ADC_CR_DEEPPWD                              \ Deep-power-down enable This bit is set and cleared by software to put the ADC in Deep-power-down mode. Note: The software is allowed to write this bit only when the ADC is disabled (ADCAL = 0, JADSTART = 0, JADSTP = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
$80000000 constant ADC1_ADC_CR_ADCAL                                \ ADC calibration This bit is set by software to start the ADC calibration. It is cleared by hardware after calibration is complete. Note: The software is allowed to launch a calibration by setting ADCAL only when ADEN = 0.


\
\ @brief ADC configuration register
\ Address offset: 0x0C
\ Reset value: 0x80000000
\

$00000003 constant ADC1_ADC_CFGR1_DMNGT                             \ Data management configuration This bit is set and cleared by software to select how the ADC interface output data are managed. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$0000000c constant ADC1_ADC_CFGR1_RES                               \ Data resolution These bits are written by software to select the resolution of the conversion. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$000003e0 constant ADC1_ADC_CFGR1_EXTSEL                            \ External trigger selection for regular group These bits select the external event used to trigger the start of conversion of a regular group: ... Refer to the ADC external trigger for regular channels in signals for details on trigger mapping. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00000c00 constant ADC1_ADC_CFGR1_EXTEN                             \ External trigger enable and polarity selection for regular channels These bits are set and cleared by software to select the external trigger polarity and enable the trigger of a regular group. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00001000 constant ADC1_ADC_CFGR1_OVRMOD                            \ Overrun Mode This bit is set and cleared by software and configure the way data overrun is managed. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00002000 constant ADC1_ADC_CFGR1_CONT                              \ Single / continuous conversion mode for regular conversions This bit is set and cleared by software. If it is set, regular conversion takes place continuously until it is cleared. Note: It is not possible to have both discontinuous mode and continuous mode enabled: it is forbidden to set both DISCEN = 1 and CONT = 1. The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00004000 constant ADC1_ADC_CFGR1_AUTDLY                            \ Delayed conversion mode This bit is set and cleared by software to enable/disable the Auto Delayed Conversion mode.. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00010000 constant ADC1_ADC_CFGR1_DISCEN                            \ Discontinuous mode for regular channels This bit is set and cleared by software to enable/disable Discontinuous mode for regular channels. Note: It is not possible to have both discontinuous mode and continuous mode enabled: it is forbidden to set both DISCEN = 1 and CONT = 1. It is not possible to use both auto-injected mode and discontinuous mode simultaneously: the bits DISCEN and JDISCEN must be kept cleared by software when JAUTO is set. The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$000e0000 constant ADC1_ADC_CFGR1_DISCNUM                           \ Discontinuous mode channel count These bits are written by software to define the number of regular channels to be converted in discontinuous mode, after receiving an external trigger. ... Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00100000 constant ADC1_ADC_CFGR1_JDISCEN                           \ Discontinuous mode on injected channels This bit is set and cleared by software to enable/disable discontinuous mode on the injected channels of a group. Note: The software is allowed to write this bit only when JADSTART = 0 (which ensures that no injected conversion is ongoing). It is not possible to use both auto-injected mode and discontinuous mode simultaneously: the bits DISCEN and JDISCEN must be kept cleared by software when JAUTO is set.
$00400000 constant ADC1_ADC_CFGR1_AWD1SGL                           \ Enable the watchdog 1 on a single channel or on all channels This bit is set and cleared by software to enable the analog watchdog on the channel identified by the AWD1CH[4:0] bits or on all the channels Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00800000 constant ADC1_ADC_CFGR1_AWD1EN                            \ Analog watchdog 1 enable on regular channels This bit is set and cleared by software Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$01000000 constant ADC1_ADC_CFGR1_JAWD1EN                           \ Analog watchdog 1 enable on injected channels This bit is set and cleared by software Note: The software is allowed to write this bit only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
$02000000 constant ADC1_ADC_CFGR1_JAUTO                             \ Automatic injected group conversion This bit is set and cleared by software to enable/disable automatic injected group conversion after regular group conversion. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no regular nor injected conversion is ongoing).
$7c000000 constant ADC1_ADC_CFGR1_AWD1CH                            \ Analog watchdog 1 channel selection These bits are set and cleared by software. They select the input channel to be guarded by the analog watchdog. ..... Others: Reserved, must not be used Note: The channel selected by AWD1CH must be also selected into the SQRi or JSQRi registers. Software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).


\
\ @brief ADC configuration register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant ADC1_ADC_CFGR2_ROVSE                             \ Regular Oversampling Enable This bit is set and cleared by software to enable regular oversampling. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing)
$00000002 constant ADC1_ADC_CFGR2_JOVSE                             \ Injected Oversampling Enable This bit is set and cleared by software to enable injected oversampling. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing)
$000001e0 constant ADC1_ADC_CFGR2_OVSS                              \ Oversampling right shift This bit field is set and cleared by software to define the right shifting applied to the raw oversampling result. Others: Reserved, must not be used. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no conversion is ongoing).
$00000200 constant ADC1_ADC_CFGR2_TROVS                             \ Triggered Regular Oversampling This bit is set and cleared by software to enable triggered oversampling Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
$00000400 constant ADC1_ADC_CFGR2_ROVSM                             \ Regular Oversampling mode This bit is set and cleared by software to select the regular oversampling mode. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
$00002000 constant ADC1_ADC_CFGR2_BULB                              \ Bulb sampling mode This bit is set and cleared by software to select the bulb sampling mode. SMPTRIG bit must not be set when the BULB bit is set. The very first ADC conversion is performed with the sampling time specified in SMPx bits. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
$00004000 constant ADC1_ADC_CFGR2_SWTRIG                            \ Software trigger bit for sampling time control trigger mode This bit is set and cleared by software to enable the bulb sampling mode. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
$00008000 constant ADC1_ADC_CFGR2_SMPTRIG                           \ Sampling time control trigger mode This bit is set and cleared by software to enable the sampling time control trigger mode. The sampling time starts on the trigger rising edge, and the conversion on the trigger falling edge. EXTEN[1:0] bits must be set to 01. BULB bit must not be set when the SMPTRIG bit is set. When EXTEN[1:0] bits is set to 00, set SWTRIG to start the sampling and clear SWTRIG bit to start the conversion. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
$03ff0000 constant ADC1_ADC_CFGR2_OSR                               \ Oversampling ratio This bitfield is set and cleared by software to define the oversampling ratio. 2: 3x ... 1023: 1024x Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
$08000000 constant ADC1_ADC_CFGR2_LFTRIG                            \ Low-frequency trigger This bit is set and cleared by software Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
$f0000000 constant ADC1_ADC_CFGR2_LSHIFT                            \ Left shift factor This bitfield is set and cleared by software to define the left shifting applied to the final result with or without oversampling. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).


\
\ @brief ADC sample time register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000007 constant ADC1_ADC_SMPR1_SMP0                              \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000038 constant ADC1_ADC_SMPR1_SMP1                              \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$000001c0 constant ADC1_ADC_SMPR1_SMP2                              \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000e00 constant ADC1_ADC_SMPR1_SMP3                              \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00007000 constant ADC1_ADC_SMPR1_SMP4                              \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00038000 constant ADC1_ADC_SMPR1_SMP5                              \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$001c0000 constant ADC1_ADC_SMPR1_SMP6                              \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00e00000 constant ADC1_ADC_SMPR1_SMP7                              \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$07000000 constant ADC1_ADC_SMPR1_SMP8                              \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$38000000 constant ADC1_ADC_SMPR1_SMP9                              \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).


\
\ @brief ADC sample time register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000007 constant ADC1_ADC_SMPR2_SMP10                             \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000038 constant ADC1_ADC_SMPR2_SMP11                             \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$000001c0 constant ADC1_ADC_SMPR2_SMP12                             \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000e00 constant ADC1_ADC_SMPR2_SMP13                             \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00007000 constant ADC1_ADC_SMPR2_SMP14                             \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00038000 constant ADC1_ADC_SMPR2_SMP15                             \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$001c0000 constant ADC1_ADC_SMPR2_SMP16                             \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00e00000 constant ADC1_ADC_SMPR2_SMP17                             \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$07000000 constant ADC1_ADC_SMPR2_SMP18                             \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$38000000 constant ADC1_ADC_SMPR2_SMP19                             \ Channel x sampling time selection (x = 0 to 9) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).


\
\ @brief ADC channel preselection register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant ADC1_ADC_PCSEL_PCSEL0                            \ Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000002 constant ADC1_ADC_PCSEL_PCSEL1                            \ Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000004 constant ADC1_ADC_PCSEL_PCSEL2                            \ Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000008 constant ADC1_ADC_PCSEL_PCSEL3                            \ Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000010 constant ADC1_ADC_PCSEL_PCSEL4                            \ Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000020 constant ADC1_ADC_PCSEL_PCSEL5                            \ Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000040 constant ADC1_ADC_PCSEL_PCSEL6                            \ Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000080 constant ADC1_ADC_PCSEL_PCSEL7                            \ Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000100 constant ADC1_ADC_PCSEL_PCSEL8                            \ Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000200 constant ADC1_ADC_PCSEL_PCSEL9                            \ Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000400 constant ADC1_ADC_PCSEL_PCSEL10                           \ Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000800 constant ADC1_ADC_PCSEL_PCSEL11                           \ Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00001000 constant ADC1_ADC_PCSEL_PCSEL12                           \ Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00002000 constant ADC1_ADC_PCSEL_PCSEL13                           \ Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00004000 constant ADC1_ADC_PCSEL_PCSEL14                           \ Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00008000 constant ADC1_ADC_PCSEL_PCSEL15                           \ Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00010000 constant ADC1_ADC_PCSEL_PCSEL16                           \ Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00020000 constant ADC1_ADC_PCSEL_PCSEL17                           \ Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00040000 constant ADC1_ADC_PCSEL_PCSEL18                           \ Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00080000 constant ADC1_ADC_PCSEL_PCSEL19                           \ Channel i (VINP[i]) preselection These bits are written by software to preselect the input channel I/O instance to be converted. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).


\
\ @brief ADC regular sequence register 1
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000000f constant ADC1_ADC_SQR1_L                                  \ Regular channel sequence length These bits are written by software to define the total number of conversions in the regular channel conversion sequence. ... Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$000007c0 constant ADC1_ADC_SQR1_SQ1                                \ 1st conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 1st in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$0001f000 constant ADC1_ADC_SQR1_SQ2                                \ 2nd conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 2nd in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$007c0000 constant ADC1_ADC_SQR1_SQ3                                \ 3rd conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 3rd in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$1f000000 constant ADC1_ADC_SQR1_SQ4                                \ 4th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 4th in the regular conversion sequence.


\
\ @brief ADC regular sequence register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000001f constant ADC1_ADC_SQR2_SQ5                                \ 5th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 5th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$000007c0 constant ADC1_ADC_SQR2_SQ6                                \ 6th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 6th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$0001f000 constant ADC1_ADC_SQR2_SQ7                                \ 7th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 7th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$007c0000 constant ADC1_ADC_SQR2_SQ8                                \ 8th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 8th in the regular conversion sequence Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$1f000000 constant ADC1_ADC_SQR2_SQ9                                \ 9th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 9th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).


\
\ @brief ADC regular sequence register 3
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant ADC1_ADC_SQR3_SQ10                               \ 10th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 10th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$000007c0 constant ADC1_ADC_SQR3_SQ11                               \ 11th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 11th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$0001f000 constant ADC1_ADC_SQR3_SQ12                               \ 12th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 12th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$007c0000 constant ADC1_ADC_SQR3_SQ13                               \ 13th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 13th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$1f000000 constant ADC1_ADC_SQR3_SQ14                               \ 14th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 14th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).


\
\ @brief ADC regular sequence register 4
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000001f constant ADC1_ADC_SQR4_SQ15                               \ 15th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 15th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$000007c0 constant ADC1_ADC_SQR4_SQ16                               \ 16th conversion in regular sequence These bits are written by software with the channel number (0..19) assigned as the 16th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).


\
\ @brief ADC regular Data Register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant ADC1_ADC_DR_RDATA                                \ Regular data converted These bits are read-only. They contain the conversion result from the last converted regular channel. The data are left- or right-aligned as described in .


\
\ @brief ADC injected sequence register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000003 constant ADC1_ADC_JSQR_JL                                 \ Injected channel sequence length These bits are written by software to define the total number of conversions in the injected channel conversion sequence. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing.
$0000007c constant ADC1_ADC_JSQR_JEXTSEL                            \ External trigger selection for injected group These bits select the external event used to trigger the start of conversion of an injected group: ... Refer to the ADC external trigger for injected channels in internal signals for details on trigger mapping. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing.
$00000180 constant ADC1_ADC_JSQR_JEXTEN                             \ External trigger enable and polarity selection for injected channels These bits are set and cleared by software to select the external trigger polarity and enable the trigger of an injected group. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing.
$00003e00 constant ADC1_ADC_JSQR_JSQ1                               \ 1st conversion in the injected sequence These bits are written by software with the channel number (0..19) assigned as the 1st in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing.
$000f8000 constant ADC1_ADC_JSQR_JSQ2                               \ 2nd conversion in the injected sequence These bits are written by software with the channel number (0..19) assigned as the 2nd in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing.
$03e00000 constant ADC1_ADC_JSQR_JSQ3                               \ 3rd conversion in the injected sequence These bits are written by software with the channel number (0..19) assigned as the 3rd in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing.
$f8000000 constant ADC1_ADC_JSQR_JSQ4                               \ 4th conversion in the injected sequence These bits are written by software with the channel number (0..19) assigned as the 4th in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing.


\
\ @brief ADC offset register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00ffffff constant ADC1_ADC_OFR1_OFFSET                             \ Data offset y for the channel programmed into OFFSETy_CH[4:0] bits These bits are written by software to define the offset y to be subtracted from the raw converted data when converting a channel (regular or injected). The channel to which the data offset y applies must be programmed to the OFFSETy_CH[4:0] bits. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). When OFFSETy[21:0] bitfield is reset, the offset compensation is disabled. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If several offsets (OFFSETy) point to the same channel, only the offset with the lowest y value is considered for the subtraction. For example, if OFFSET1_CH[4:0] = 4 and OFFSET2_CH[4:0] = 4, this is OFFSET1[25:0] that is subtracted when converting channel 4.
$01000000 constant ADC1_ADC_OFR1_POSOFF                             \ offset sign This bit is set and cleared by software to enable the positive offset. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$02000000 constant ADC1_ADC_OFR1_USAT                               \ Unsigned saturation enable This bit is written by software to enable or disable the unsigned saturation feature. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$04000000 constant ADC1_ADC_OFR1_SSAT                               \ Signed saturation enable This bit is written by software to enable or disable the Signed saturation feature. (see OFFSETy_CH, OVSS, LSHIFT, USAT, SSAT) for details). Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$f8000000 constant ADC1_ADC_OFR1_OFFSET_CH                          \ Channel selection for the data offset y These bits are written by software to define the channel to which the offset programmed into OFFSETy[25:0] bits applies. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If OFFSETy_EN bit is set, it is not allowed to select the same channel in different ADC_OFRy registers.


\
\ @brief ADC offset register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00ffffff constant ADC1_ADC_OFR2_OFFSET                             \ Data offset y for the channel programmed into OFFSETy_CH[4:0] bits These bits are written by software to define the offset y to be subtracted from the raw converted data when converting a channel (regular or injected). The channel to which the data offset y applies must be programmed to the OFFSETy_CH[4:0] bits. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). When OFFSETy[21:0] bitfield is reset, the offset compensation is disabled. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If several offsets (OFFSETy) point to the same channel, only the offset with the lowest y value is considered for the subtraction. For example, if OFFSET1_CH[4:0] = 4 and OFFSET2_CH[4:0] = 4, this is OFFSET1[25:0] that is subtracted when converting channel 4.
$01000000 constant ADC1_ADC_OFR2_POSOFF                             \ offset sign This bit is set and cleared by software to enable the positive offset. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$02000000 constant ADC1_ADC_OFR2_USAT                               \ Unsigned saturation enable This bit is written by software to enable or disable the unsigned saturation feature. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$04000000 constant ADC1_ADC_OFR2_SSAT                               \ Signed saturation enable This bit is written by software to enable or disable the Signed saturation feature. (see OFFSETy_CH, OVSS, LSHIFT, USAT, SSAT) for details). Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$f8000000 constant ADC1_ADC_OFR2_OFFSET_CH                          \ Channel selection for the data offset y These bits are written by software to define the channel to which the offset programmed into OFFSETy[25:0] bits applies. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If OFFSETy_EN bit is set, it is not allowed to select the same channel in different ADC_OFRy registers.


\
\ @brief ADC offset register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00ffffff constant ADC1_ADC_OFR3_OFFSET                             \ Data offset y for the channel programmed into OFFSETy_CH[4:0] bits These bits are written by software to define the offset y to be subtracted from the raw converted data when converting a channel (regular or injected). The channel to which the data offset y applies must be programmed to the OFFSETy_CH[4:0] bits. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). When OFFSETy[21:0] bitfield is reset, the offset compensation is disabled. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If several offsets (OFFSETy) point to the same channel, only the offset with the lowest y value is considered for the subtraction. For example, if OFFSET1_CH[4:0] = 4 and OFFSET2_CH[4:0] = 4, this is OFFSET1[25:0] that is subtracted when converting channel 4.
$01000000 constant ADC1_ADC_OFR3_POSOFF                             \ offset sign This bit is set and cleared by software to enable the positive offset. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$02000000 constant ADC1_ADC_OFR3_USAT                               \ Unsigned saturation enable This bit is written by software to enable or disable the unsigned saturation feature. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$04000000 constant ADC1_ADC_OFR3_SSAT                               \ Signed saturation enable This bit is written by software to enable or disable the Signed saturation feature. (see OFFSETy_CH, OVSS, LSHIFT, USAT, SSAT) for details). Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$f8000000 constant ADC1_ADC_OFR3_OFFSET_CH                          \ Channel selection for the data offset y These bits are written by software to define the channel to which the offset programmed into OFFSETy[25:0] bits applies. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If OFFSETy_EN bit is set, it is not allowed to select the same channel in different ADC_OFRy registers.


\
\ @brief ADC offset register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00ffffff constant ADC1_ADC_OFR4_OFFSET                             \ Data offset y for the channel programmed into OFFSETy_CH[4:0] bits These bits are written by software to define the offset y to be subtracted from the raw converted data when converting a channel (regular or injected). The channel to which the data offset y applies must be programmed to the OFFSETy_CH[4:0] bits. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). When OFFSETy[21:0] bitfield is reset, the offset compensation is disabled. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If several offsets (OFFSETy) point to the same channel, only the offset with the lowest y value is considered for the subtraction. For example, if OFFSET1_CH[4:0] = 4 and OFFSET2_CH[4:0] = 4, this is OFFSET1[25:0] that is subtracted when converting channel 4.
$01000000 constant ADC1_ADC_OFR4_POSOFF                             \ offset sign This bit is set and cleared by software to enable the positive offset. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$02000000 constant ADC1_ADC_OFR4_USAT                               \ Unsigned saturation enable This bit is written by software to enable or disable the unsigned saturation feature. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$04000000 constant ADC1_ADC_OFR4_SSAT                               \ Signed saturation enable This bit is written by software to enable or disable the Signed saturation feature. (see OFFSETy_CH, OVSS, LSHIFT, USAT, SSAT) for details). Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$f8000000 constant ADC1_ADC_OFR4_OFFSET_CH                          \ Channel selection for the data offset y These bits are written by software to define the channel to which the offset programmed into OFFSETy[25:0] bits applies. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If OFFSETy_EN bit is set, it is not allowed to select the same channel in different ADC_OFRy registers.


\
\ @brief ADC gain compensation register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00003fff constant ADC1_ADC_GCOMP_GCOMPCOEFF                        \ Gain compensation coefficient These bits are set and cleared by software to program the gain compensation coefficient. ... ... The coefficient is divided by 4096 to get the gain factor ranging from 0 to 3.999756. Note: This gain compensation is only applied when GCOMP bit of ADCx_CFGR2 register is 1.
$80000000 constant ADC1_ADC_GCOMP_GCOMP                             \ Gain compensation mode This bit is set and cleared by software to enable the gain compensation mode. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).


\
\ @brief ADC injected data register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant ADC1_ADC_JDR1_JDATA                              \ Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in .


\
\ @brief ADC injected data register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant ADC1_ADC_JDR2_JDATA                              \ Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in .


\
\ @brief ADC injected data register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant ADC1_ADC_JDR3_JDATA                              \ Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in .


\
\ @brief ADC injected data register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant ADC1_ADC_JDR4_JDATA                              \ Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in .


\
\ @brief ADC analog watchdog 2 configuration register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$000fffff constant ADC1_ADC_AWD2CR_AWD2CH                           \ Analog watchdog 2 channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by the analog watchdog 2. AWD2CH[i] = 0: ADC analog input channel-i is not monitored by AWD2 AWD2CH[i] = 1: ADC analog input channel-i is monitored by AWD2 When AWD2CH[19:0] = 000..0, the analog Watchdog 2 is disabled Note: The channels selected by AWD2CH must be also selected into the SQRi or JSQRi registers. Software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).


\
\ @brief ADC analog watchdog 3 configuration register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$000fffff constant ADC1_ADC_AWD3CR_AWD3CH                           \ Analog watchdog 3 channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by the analog watchdog 3. AWD3CH[i] = 0: ADC analog input channel-i is not monitored by AWD3 AWD3CH[i] = 1: ADC analog input channel-i is monitored by AWD3 When AWD3CH[19:0] = 000..0, the analog Watchdog 3 is disabled Note: The channels selected by AWD3CH must be also selected into the SQRi or JSQRi registers. The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).


\
\ @brief ADC watchdog threshold register 1
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$01ffffff constant ADC1_ADC_LTR1_LTR1                               \ Analog watchdog 1 lower threshold These bits are written by software to define the lower threshold for the analog watchdog 1. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy).


\
\ @brief ADC watchdog threshold register 1
\ Address offset: 0xAC
\ Reset value: 0x01FFFFFF
\

$01ffffff constant ADC1_ADC_HTR1_HTR1                               \ Analog watchdog 1 higher threshold These bits are written by software to define the higher threshold for the analog watchdog 1. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy).
$e0000000 constant ADC1_ADC_HTR1_AWDFILT1                           \ Analog watchdog filtering parameter This bit is set and cleared by software. ... Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).


\
\ @brief ADC watchdog lower threshold register 2
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$01ffffff constant ADC1_ADC_LTR2_LTR2                               \ Analog watchdog 2 lower threshold These bits are written by software to define the lower threshold for the analog watchdog 2. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy).


\
\ @brief ADC watchdog higher threshold register 2
\ Address offset: 0xB4
\ Reset value: 0x01FFFFFF
\

$01ffffff constant ADC1_ADC_HTR2_HTR2                               \ Analog watchdog 2 higher threshold These bits are written by software to define the higher threshold for the analog watchdog 2. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy).


\
\ @brief ADC watchdog lower threshold register 3
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$01ffffff constant ADC1_ADC_LTR3_LTR3                               \ Analog watchdog 3 lower threshold These bits are written by software to define the lower threshold for the analog watchdog 3. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy).


\
\ @brief ADC watchdog higher threshold register 3
\ Address offset: 0xBC
\ Reset value: 0x01FFFFFF
\

$01ffffff constant ADC1_ADC_HTR3_HTR3                               \ Analog watchdog 3 higher threshold These bits are written by software to define the higher threshold for the analog watchdog 3. Refer to AWD2CH, AWD3CH, AWD_HTRy, AWD_LTRy, AWDy).


\
\ @brief ADC differential mode selection register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$000fffff constant ADC1_ADC_DIFSEL_DIFSEL                           \ Differential mode for channels 19 to 0 These bits are set and cleared by software. They allow selecting if a channel is configured as single ended or differential mode. DIFSEL[i] = 0: ADC analog input channel-i is configured in single ended mode DIFSEL[i] = 1: ADC analog input channel-i is configured in differential mode Note: The software is allowed to write these bits only when the ADC is disabled (ADCAL = 0, JADSTART = 0, JADSTP = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).


\
\ @brief ADC user control register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$000000ff constant ADC1_ADC_CALFACT_I_APB_ADDR                      \ Delayed write access address This bitfield contains the address that is being written during delayed write accesses.
$0000ff00 constant ADC1_ADC_CALFACT_I_APB_DATA                      \ Delayed write access data This bitfield contains the data that are being written during delayed write accesses.
$00010000 constant ADC1_ADC_CALFACT_VALIDITY                        \ Delayed write access status bit This bit indicates the communication status between the ADC digital and analog blocks.
$01000000 constant ADC1_ADC_CALFACT_LATCH_COEF                      \ Calibration factor latch enable bit This bit latches the calibration factor in the CALFACT[31:0] bits.
$02000000 constant ADC1_ADC_CALFACT_CAPTURE_COEF                    \ Calibration factor capture enable bit This bit enables the internal calibration factor capture.


\
\ @brief ADC calibration factor register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000000 constant ADC1_ADC_CALFACT2_CALFACT                        \ Linearity or offset calibration factor These bits can be written either by hardware or by software. They contain the 32-bit offset or linearity calibration factor. When CAPTURE_COEF is set to 1, the calibration factor of the analog block is read back and stored in CALFACT[31:0], indexed by CALINDEX[3:0] bits. When LATCH_COEF is set to 1, the calibration factor of the analog block is updated with the value programmed in CALFACT[31:0], indexed by CALINDEX[3:0] bits. To read all calibration factors, perform nine accesses to the ADC_CALFACT2 register. To write all calibration factors, perform eight accesses to the ADC_CALFACT2 register. Note: The software is allowed to write these bits only when ADEN = 1, ADSTART = 0 and JADSTART = 0 (ADC is enabled and no calibration is ongoing and no conversion is ongoing).


\
\ @brief ADC1
\
$42028000 constant ADC1_ADC_ISR   \ offset: 0x00 : ADC interrupt and status register
$42028004 constant ADC1_ADC_IER   \ offset: 0x04 : ADC interrupt enable register
$42028008 constant ADC1_ADC_CR    \ offset: 0x08 : ADC control register
$4202800c constant ADC1_ADC_CFGR1  \ offset: 0x0C : ADC configuration register
$42028010 constant ADC1_ADC_CFGR2  \ offset: 0x10 : ADC configuration register 2
$42028014 constant ADC1_ADC_SMPR1  \ offset: 0x14 : ADC sample time register 1
$42028018 constant ADC1_ADC_SMPR2  \ offset: 0x18 : ADC sample time register 2
$4202801c constant ADC1_ADC_PCSEL  \ offset: 0x1C : ADC channel preselection register
$42028030 constant ADC1_ADC_SQR1  \ offset: 0x30 : ADC regular sequence register 1
$42028034 constant ADC1_ADC_SQR2  \ offset: 0x34 : ADC regular sequence register 2
$42028038 constant ADC1_ADC_SQR3  \ offset: 0x38 : ADC regular sequence register 3
$4202803c constant ADC1_ADC_SQR4  \ offset: 0x3C : ADC regular sequence register 4
$42028040 constant ADC1_ADC_DR    \ offset: 0x40 : ADC regular Data Register
$4202804c constant ADC1_ADC_JSQR  \ offset: 0x4C : ADC injected sequence register
$42028060 constant ADC1_ADC_OFR1  \ offset: 0x60 : ADC offset register
$42028064 constant ADC1_ADC_OFR2  \ offset: 0x64 : ADC offset register
$42028068 constant ADC1_ADC_OFR3  \ offset: 0x68 : ADC offset register
$4202806c constant ADC1_ADC_OFR4  \ offset: 0x6C : ADC offset register
$42028070 constant ADC1_ADC_GCOMP  \ offset: 0x70 : ADC gain compensation register
$42028080 constant ADC1_ADC_JDR1  \ offset: 0x80 : ADC injected data register
$42028084 constant ADC1_ADC_JDR2  \ offset: 0x84 : ADC injected data register
$42028088 constant ADC1_ADC_JDR3  \ offset: 0x88 : ADC injected data register
$4202808c constant ADC1_ADC_JDR4  \ offset: 0x8C : ADC injected data register
$420280a0 constant ADC1_ADC_AWD2CR  \ offset: 0xA0 : ADC analog watchdog 2 configuration register
$420280a4 constant ADC1_ADC_AWD3CR  \ offset: 0xA4 : ADC analog watchdog 3 configuration register
$420280a8 constant ADC1_ADC_LTR1  \ offset: 0xA8 : ADC watchdog threshold register 1
$420280ac constant ADC1_ADC_HTR1  \ offset: 0xAC : ADC watchdog threshold register 1
$420280b0 constant ADC1_ADC_LTR2  \ offset: 0xB0 : ADC watchdog lower threshold register 2
$420280b4 constant ADC1_ADC_HTR2  \ offset: 0xB4 : ADC watchdog higher threshold register 2
$420280b8 constant ADC1_ADC_LTR3  \ offset: 0xB8 : ADC watchdog lower threshold register 3
$420280bc constant ADC1_ADC_HTR3  \ offset: 0xBC : ADC watchdog higher threshold register 3
$420280c0 constant ADC1_ADC_DIFSEL  \ offset: 0xC0 : ADC differential mode selection register
$420280c4 constant ADC1_ADC_CALFACT  \ offset: 0xC4 : ADC user control register
$420280c8 constant ADC1_ADC_CALFACT2  \ offset: 0xC8 : ADC calibration factor register

