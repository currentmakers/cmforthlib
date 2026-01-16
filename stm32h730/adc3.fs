\
\ @file adc3.fs
\ @brief Analog-to-Digital Converter
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

$00000001 constant ADC3_ADC_ISR_ADRDY                               \ ADC ready This bit is set by hardware after the ADC has been enabled (ADEN = 1) and when the ADC reaches a state where it is ready to accept conversion requests. It is cleared by software writing 1 to it.
$00000002 constant ADC3_ADC_ISR_EOSMP                               \ End of sampling flag This bit is set by hardware during the conversion of any channel (only for regular channels), at the end of the sampling phase.
$00000004 constant ADC3_ADC_ISR_EOC                                 \ End of conversion flag This bit is set by hardware at the end of each regular conversion of a channel when a new data is available in the ADC_DR register. It is cleared by software writing 1 to it or by reading the ADC_DR register
$00000008 constant ADC3_ADC_ISR_EOS                                 \ End of regular sequence flag This bit is set by hardware at the end of the conversions of a regular sequence of channels. It is cleared by software writing 1 to it.
$00000010 constant ADC3_ADC_ISR_OVR                                 \ ADC overrun This bit is set by hardware when an overrun occurs on a regular channel, meaning that a new conversion has completed while the EOC flag was already set. It is cleared by software writing 1 to it.
$00000020 constant ADC3_ADC_ISR_JEOC                                \ Injected channel end of conversion flag This bit is set by hardware at the end of each injected conversion of a channel when a new data is available in the corresponding ADC_JDRy register. It is cleared by software writing 1 to it or by reading the corresponding ADC_JDRy register
$00000040 constant ADC3_ADC_ISR_JEOS                                \ Injected channel end of sequence flag This bit is set by hardware at the end of the conversions of all injected channels in the group. It is cleared by software writing 1 to it.
$00000080 constant ADC3_ADC_ISR_AWD1                                \ Analog watchdog 1 flag This bit is set by hardware when the converted voltage crosses the values programmed in the fields LT1[11:0] and HT1[11:0] of ADC_TR1 register. It is cleared by software. writing 1 to it.
$00000100 constant ADC3_ADC_ISR_AWD2                                \ Analog watchdog 2 flag This bit is set by hardware when the converted voltage crosses the values programmed in the fields LT2[7:0] and HT2[7:0] of ADC_TR2 register. It is cleared by software writing 1 to it.
$00000200 constant ADC3_ADC_ISR_AWD3                                \ Analog watchdog 3 flag This bit is set by hardware when the converted voltage crosses the values programmed in the fields LT3[7:0] and HT3[7:0] of ADC_TR3 register. It is cleared by software writing 1 to it.
$00000400 constant ADC3_ADC_ISR_JQOVF                               \ Injected context queue overflow This bit is set by hardware when an Overflow of the Injected Queue of Context occurs. It is cleared by software writing 1 to it. Refer to for more information.


\
\ @brief ADC interrupt enable register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant ADC3_ADC_IER_ADRDYIE                             \ ADC ready interrupt enable This bit is set and cleared by software to enable/disable the ADC Ready interrupt. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000002 constant ADC3_ADC_IER_EOSMPIE                             \ End of sampling flag interrupt enable for regular conversions This bit is set and cleared by software to enable/disable the end of the sampling phase interrupt for regular conversions. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00000004 constant ADC3_ADC_IER_EOCIE                               \ End of regular conversion interrupt enable This bit is set and cleared by software to enable/disable the end of a regular conversion interrupt. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00000008 constant ADC3_ADC_IER_EOSIE                               \ End of regular sequence of conversions interrupt enable This bit is set and cleared by software to enable/disable the end of regular sequence of conversions interrupt. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00000010 constant ADC3_ADC_IER_OVRIE                               \ Overrun interrupt enable This bit is set and cleared by software to enable/disable the Overrun interrupt of a regular conversion. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00000020 constant ADC3_ADC_IER_JEOCIE                              \ End of injected conversion interrupt enable This bit is set and cleared by software to enable/disable the end of an injected conversion interrupt. Note: The software is allowed to write this bit only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
$00000040 constant ADC3_ADC_IER_JEOSIE                              \ End of injected sequence of conversions interrupt enable This bit is set and cleared by software to enable/disable the end of injected sequence of conversions interrupt. Note: The software is allowed to write this bit only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
$00000080 constant ADC3_ADC_IER_AWD1IE                              \ Analog watchdog 1 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog 1 interrupt. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000100 constant ADC3_ADC_IER_AWD2IE                              \ Analog watchdog 2 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog 2 interrupt. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000200 constant ADC3_ADC_IER_AWD3IE                              \ Analog watchdog 3 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog 2 interrupt. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000400 constant ADC3_ADC_IER_JQOVFIE                             \ Injected context queue overflow interrupt enable This bit is set and cleared by software to enable/disable the Injected Context Queue Overflow interrupt. Note: The software is allowed to write this bit only when JADSTART = 0 (which ensures that no injected conversion is ongoing).


\
\ @brief ADC control register
\ Address offset: 0x08
\ Reset value: 0x20000000
\

$00000001 constant ADC3_ADC_CR_ADEN                                 \ ADC enable control This bit is set by software to enable the ADC. The ADC is effectively ready to operate once the flag ADRDY has been set. It is cleared by hardware when the ADC is disabled, after the execution of the ADDIS command. Note: The software is allowed to set ADEN only when all bits of ADC_CR registers are 0 (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0) except for bit ADVREGEN which must be 1 (and the software must have wait for the startup time of the voltage regulator)
$00000002 constant ADC3_ADC_CR_ADDIS                                \ ADC disable command This bit is set by software to disable the ADC (ADDIS command) and put it into power-down state (OFF state). It is cleared by hardware once the ADC is effectively disabled (ADEN is also cleared by hardware at this time). Note: The software is allowed to set ADDIS only when ADEN = 1 and both ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing)
$00000004 constant ADC3_ADC_CR_ADSTART                              \ ADC start of regular conversion This bit is set by software to start ADC conversion of regular channels. Depending on the configuration bits EXTEN, a conversion immediately starts (software trigger configuration) or once a regular hardware trigger event occurs (hardware trigger configuration). It is cleared by hardware: in Single conversion mode when software trigger is selected (EXTSEL = 0x0): at the assertion of the End of Regular Conversion Sequence (EOS) flag. in all cases: after the execution of the ADSTP command, at the same time that ADSTP is cleared by hardware. Note: The software is allowed to set ADSTART only when ADEN = 1 and ADDIS = 0 (ADC is enabled and there is no pending request to disable the ADC) In auto-injection mode (JAUTO = 1), regular and auto-injected conversions are started by setting bit ADSTART (JADSTART must be kept cleared)
$00000008 constant ADC3_ADC_CR_JADSTART                             \ ADC start of injected conversion This bit is set by software to start ADC conversion of injected channels. Depending on the configuration bits JEXTEN, a conversion immediately starts (software trigger configuration) or once an injected hardware trigger event occurs (hardware trigger configuration). It is cleared by hardware: in Single conversion mode when software trigger is selected (JEXTSEL = 0x0): at the assertion of the End of Injected Conversion Sequence (JEOS) flag. in all cases: after the execution of the JADSTP command, at the same time that JADSTP is cleared by hardware. Note: The software is allowed to set JADSTART only when ADEN = 1 and ADDIS = 0 (ADC is enabled and there is no pending request to disable the ADC). In auto-injection mode (JAUTO = 1), regular and auto-injected conversions are started by setting bit ADSTART (JADSTART must be kept cleared)
$00000010 constant ADC3_ADC_CR_ADSTP                                \ ADC stop of regular conversion command This bit is set by software to stop and discard an ongoing regular conversion (ADSTP Command). It is cleared by hardware when the conversion is effectively discarded and the ADC regular sequence and triggers can be re-configured. The ADC is then ready to accept a new start of regular conversions (ADSTART command). Note: The software is allowed to set ADSTP only when ADSTART = 1 and ADDIS = 0 (ADC is enabled and eventually converting a regular conversion and there is no pending request to disable the ADC). In auto-injection mode (JAUTO = 1), setting ADSTP bit aborts both regular and injected conversions (do not use JADSTP).
$00000020 constant ADC3_ADC_CR_JADSTP                               \ ADC stop of injected conversion command This bit is set by software to stop and discard an ongoing injected conversion (JADSTP Command). It is cleared by hardware when the conversion is effectively discarded and the ADC injected sequence and triggers can be re-configured. The ADC is then ready to accept a new start of injected conversions (JADSTART command). Note: The software is allowed to set JADSTP only when JADSTART = 1 and ADDIS = 0 (ADC is enabled and eventually converting an injected conversion and there is no pending request to disable the ADC) In Auto-injection mode (JAUTO = 1), setting ADSTP bit aborts both regular and injected conversions (do not use JADSTP)
$10000000 constant ADC3_ADC_CR_ADVREGEN                             \ ADC voltage regulator enable This bits is set by software to enable the ADC voltage regulator. Before performing any operation such as launching a calibration or enabling the ADC, the ADC voltage regulator must first be enabled and the software must wait for the regulator start-up time. For more details about the ADC voltage regulator enable and disable sequences, refer to (ADVREGEN). The software can program this bit field only when the ADC is disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
$20000000 constant ADC3_ADC_CR_DEEPPWD                              \ Deep-power-down enable This bit is set and cleared by software to put the ADC in Deep-power-down mode. Note: The software is allowed to write this bit only when the ADC is disabled (ADCAL = 0, JADSTART = 0, JADSTP = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
$40000000 constant ADC3_ADC_CR_ADCALDIF                             \ Differential mode for calibration This bit is set and cleared by software to configure the Single-ended or Differential inputs mode for the calibration. Note: The software is allowed to write this bit only when the ADC is disabled and is not calibrating (ADCAL = 0, JADSTART = 0, JADSTP = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
$80000000 constant ADC3_ADC_CR_ADCAL                                \ ADC calibration This bit is set by software to start the calibration of the ADC. Program first the bit ADCALDIF to determine if this calibration applies for Single-ended or Differential inputs mode. It is cleared by hardware after calibration is complete. Note: The software is allowed to launch a calibration by setting ADCAL only when ADEN = 0. The software is allowed to update the calibration factor by writing ADC_CALFACT only when ADEN = 1 and ADSTART = 0 and JADSTART = 0 (ADC enabled and no conversion is ongoing)


\
\ @brief ADC configuration register
\ Address offset: 0x0C
\ Reset value: 0x80000000
\

$00000001 constant ADC3_ADC_CFGR_DMAEN                              \ Direct memory access enable This bit is set and cleared by software to enable the generation of DMA requests. This allows to use the DMA to manage automatically the converted data. For more details, refer to conversions using the DMA. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000002 constant ADC3_ADC_CFGR_DMACFG                             \ Direct memory access configuration This bit is set and cleared by software to select between two DMA modes of operation and is effective only when DMAEN = 1. For more details, refer to Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000004 constant ADC3_ADC_CFGR_DFSDMCFG                           \ DFSDM mode configuration This bit is set and cleared by software to enable the DFSDM mode. It is effective only when DMAEN = 0. Note: To make sure no conversion is ongoing, the software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0.
$00000018 constant ADC3_ADC_CFGR_RES                                \ Data resolution These bits are written by software to select the resolution of the conversion. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00000020 constant ADC3_ADC_CFGR_EXTSEL0                            \ External trigger selection for regular group These bits select the external event used to trigger the start of conversion of a regular group: ... Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00000040 constant ADC3_ADC_CFGR_EXTSEL1                            \ External trigger selection for regular group These bits select the external event used to trigger the start of conversion of a regular group: ... Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00000080 constant ADC3_ADC_CFGR_EXTSEL2                            \ External trigger selection for regular group These bits select the external event used to trigger the start of conversion of a regular group: ... Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00000100 constant ADC3_ADC_CFGR_EXTSEL3                            \ External trigger selection for regular group These bits select the external event used to trigger the start of conversion of a regular group: ... Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00000200 constant ADC3_ADC_CFGR_EXTSEL4                            \ External trigger selection for regular group These bits select the external event used to trigger the start of conversion of a regular group: ... Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00000c00 constant ADC3_ADC_CFGR_EXTEN                              \ External trigger enable and polarity selection for regular channels These bits are set and cleared by software to select the external trigger polarity and enable the trigger of a regular group. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00001000 constant ADC3_ADC_CFGR_OVRMOD                             \ Overrun mode This bit is set and cleared by software and configure the way data overrun is managed. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00002000 constant ADC3_ADC_CFGR_CONT                               \ Single / Continuous conversion mode for regular conversions This bit is set and cleared by software. If it is set, regular conversion takes place continuously until it is cleared. Note: It is not possible to have both Discontinuous mode and Continuous mode enabled: it is forbidden to set both DISCEN = 1 and CONT = 1. The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00004000 constant ADC3_ADC_CFGR_AUTDLY                             \ Delayed conversion mode This bit is set and cleared by software to enable/disable the Auto Delayed Conversion mode.. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00008000 constant ADC3_ADC_CFGR_ALIGN                              \ Data alignment This bit is set and cleared by software to select right or left alignment. Refer to register, data alignment and offset (ADC_DR, OFFSET, OFFSET_CH, ALIGN). Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00010000 constant ADC3_ADC_CFGR_DISCEN                             \ Discontinuous mode for regular channels This bit is set and cleared by software to enable/disable Discontinuous mode for regular channels. Note: It is not possible to have both Discontinuous mode and Continuous mode enabled: it is forbidden to set both DISCEN = 1 and CONT = 1. It is not possible to use both auto-injected mode and Discontinuous mode simultaneously: the bits DISCEN and JDISCEN must be kept cleared by software when JAUTO is set. The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$000e0000 constant ADC3_ADC_CFGR_DISCNUM                            \ Discontinuous mode channel count These bits are written by software to define the number of regular channels to be converted in Discontinuous mode, after receiving an external trigger. ... Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00100000 constant ADC3_ADC_CFGR_JDISCEN                            \ Discontinuous mode on injected channels This bit is set and cleared by software to enable/disable Discontinuous mode on the injected channels of a group. Note: The software is allowed to write this bit only when JADSTART = 0 (which ensures that no injected conversion is ongoing). It is not possible to use both auto-injected mode and Discontinuous mode simultaneously: the bits DISCEN and JDISCEN must be kept cleared by software when JAUTO is set.
$00200000 constant ADC3_ADC_CFGR_JQM                                \ JSQR queue mode This bit is set and cleared by software. It defines how an empty Queue is managed. Refer to for more information. Note: The software is allowed to write this bit only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
$00400000 constant ADC3_ADC_CFGR_AWD1SGL                            \ Enable the watchdog 1 on a single channel or on all channels This bit is set and cleared by software to enable the analog watchdog on the channel identified by the AWD1CH[4:0] bits or on all the channels Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00800000 constant ADC3_ADC_CFGR_AWD1EN                             \ Analog watchdog 1 enable on regular channels This bit is set and cleared by software Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$01000000 constant ADC3_ADC_CFGR_JAWD1EN                            \ Analog watchdog 1 enable on injected channels This bit is set and cleared by software Note: The software is allowed to write this bit only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
$02000000 constant ADC3_ADC_CFGR_JAUTO                              \ Automatic injected group conversion This bit is set and cleared by software to enable/disable automatic injected group conversion after regular group conversion. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no regular nor injected conversion is ongoing).
$7c000000 constant ADC3_ADC_CFGR_AWD1CH                             \ Analog watchdog 1 channel selection These bits are set and cleared by software. They select the input channel to be guarded by the analog watchdog. ..... others: reserved, must not be used Note: Some channels are not connected physically. Keep the corresponding AWD1CH[4:0] setting to the reset value. The channel selected by AWD1CH must be also selected into the SQRi or JSQRi registers. The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$80000000 constant ADC3_ADC_CFGR_JQDIS                              \ Injected Queue disable These bits are set and cleared by software to disable the Injected Queue mechanism : Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no regular nor injected conversion is ongoing). A set or reset of JQDIS bit causes the injected queue to be flushed and the JSQR register is cleared.


\
\ @brief ADC configuration register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant ADC3_ADC_CFGR2_ROVSE                             \ Regular Oversampling Enable This bit is set and cleared by software to enable regular oversampling. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing)
$00000002 constant ADC3_ADC_CFGR2_JOVSE                             \ Injected Oversampling Enable This bit is set and cleared by software to enable injected oversampling. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing)
$0000001c constant ADC3_ADC_CFGR2_OVSR                              \ Oversampling ratio This bitfield is set and cleared by software to define the oversampling ratio. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no conversion is ongoing).
$000001e0 constant ADC3_ADC_CFGR2_OVSS                              \ Oversampling shift This bitfield is set and cleared by software to define the right shifting applied to the raw oversampling result. Other codes reserved Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no conversion is ongoing).
$00000200 constant ADC3_ADC_CFGR2_TROVS                             \ Triggered Regular Oversampling This bit is set and cleared by software to enable triggered oversampling Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
$00000400 constant ADC3_ADC_CFGR2_ROVSM                             \ Regular Oversampling mode This bit is set and cleared by software to select the regular oversampling mode. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
$02000000 constant ADC3_ADC_CFGR2_SWTRIG                            \ Software trigger bit for sampling time control trigger mode This bit is set and cleared by software to enable the bulb sampling mode. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
$04000000 constant ADC3_ADC_CFGR2_BULB                              \ Bulb sampling mode This bit is set and cleared by software to enable the bulb sampling mode. SAMPTRIG bit must not be set when the BULB bit is set. The very first ADC conversion is performed with the sampling time specified in SMPx bits. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
$08000000 constant ADC3_ADC_CFGR2_SMPTRIG                           \ Sampling time control trigger mode This bit is set and cleared by software to enable the sampling time control trigger mode. The sampling time starts on the trigger rising edge, and the conversion on the trigger falling edge. EXTEN bit should be set to 01. BULB bit must not be set when the SMPTRIG bit is set. When EXTEN bit is set to 00, set SWTRIG to start the sampling and clear SWTRIG bit to start the conversion. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).


\
\ @brief ADC sample time register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000007 constant ADC3_ADC_SMPR1_SMP0                              \ Channel x sampling time selection These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
$00000038 constant ADC3_ADC_SMPR1_SMP1                              \ Channel x sampling time selection These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
$000001c0 constant ADC3_ADC_SMPR1_SMP2                              \ Channel x sampling time selection These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
$00000e00 constant ADC3_ADC_SMPR1_SMP3                              \ Channel x sampling time selection These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
$00007000 constant ADC3_ADC_SMPR1_SMP4                              \ Channel x sampling time selection These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
$00038000 constant ADC3_ADC_SMPR1_SMP5                              \ Channel x sampling time selection These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
$001c0000 constant ADC3_ADC_SMPR1_SMP6                              \ Channel x sampling time selection These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
$00e00000 constant ADC3_ADC_SMPR1_SMP7                              \ Channel x sampling time selection These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
$07000000 constant ADC3_ADC_SMPR1_SMP8                              \ Channel x sampling time selection These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
$38000000 constant ADC3_ADC_SMPR1_SMP9                              \ Channel x sampling time selection These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
$80000000 constant ADC3_ADC_SMPR1_SMPPLUS                           \ Addition of one clock cycle to the sampling time. To make sure no conversion is ongoing, the software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0.


\
\ @brief ADC sample time register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000007 constant ADC3_ADC_SMPR2_SMP10                             \ Channel x sampling time selection These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
$00000038 constant ADC3_ADC_SMPR2_SMP11                             \ Channel x sampling time selection These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
$000001c0 constant ADC3_ADC_SMPR2_SMP12                             \ Channel x sampling time selection These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
$00000e00 constant ADC3_ADC_SMPR2_SMP13                             \ Channel x sampling time selection These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
$00007000 constant ADC3_ADC_SMPR2_SMP14                             \ Channel x sampling time selection These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
$00038000 constant ADC3_ADC_SMPR2_SMP15                             \ Channel x sampling time selection These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
$001c0000 constant ADC3_ADC_SMPR2_SMP16                             \ Channel x sampling time selection These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
$00e00000 constant ADC3_ADC_SMPR2_SMP17                             \ Channel x sampling time selection These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
$07000000 constant ADC3_ADC_SMPR2_SMP18                             \ Channel x sampling time selection These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.


\
\ @brief ADC watchdog threshold register 1
\ Address offset: 0x20
\ Reset value: 0x0FFF0000
\

$00000fff constant ADC3_ADC_TR1_LT1                                 \ Analog watchdog 1 lower threshold These bits are written by software to define the lower threshold for the analog watchdog 1. Refer to AWD2CH, AWD3CH, AWD_HTx, AWD_LTx, AWDx) Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00007000 constant ADC3_ADC_TR1_AWDFILT                             \ Analog watchdog filtering parameter This bit is set and cleared by software. ... Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
$0fff0000 constant ADC3_ADC_TR1_HT1                                 \ Analog watchdog 1 higher threshold These bits are written by software to define the higher threshold for the analog watchdog 1. Refer to AWD2CH, AWD3CH, AWD_HTx, AWD_LTx, AWDx) Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).


\
\ @brief ADC watchdog threshold register 2
\ Address offset: 0x24
\ Reset value: 0x00FF0000
\

$000000ff constant ADC3_ADC_TR2_LT2                                 \ Analog watchdog 2 lower threshold These bits are written by software to define the lower threshold for the analog watchdog 2. Refer to AWD2CH, AWD3CH, AWD_HTx, AWD_LTx, AWDx) Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00ff0000 constant ADC3_ADC_TR2_HT2                                 \ Analog watchdog 2 higher threshold These bits are written by software to define the higher threshold for the analog watchdog 2. Refer to AWD2CH, AWD3CH, AWD_HTx, AWD_LTx, AWDx) Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).


\
\ @brief ADC watchdog threshold register 3
\ Address offset: 0x28
\ Reset value: 0x00FF0000
\

$000000ff constant ADC3_ADC_TR3_LT3                                 \ Analog watchdog 3 lower threshold These bits are written by software to define the lower threshold for the analog watchdog 3. This watchdog compares the 8-bit of LT3 with the 8 MSB of the converted data. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$00ff0000 constant ADC3_ADC_TR3_HT3                                 \ Analog watchdog 3 higher threshold These bits are written by software to define the higher threshold for the analog watchdog 3. Refer to AWD2CH, AWD3CH, AWD_HTx, AWD_LTx, AWDx) Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).


\
\ @brief ADC regular sequence register 1
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000000f constant ADC3_ADC_SQR1_L                                  \ Regular channel sequence length These bits are written by software to define the total number of conversions in the regular channel conversion sequence. ... Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$000007c0 constant ADC3_ADC_SQR1_SQ1                                \ 1st conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 1st in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$0001f000 constant ADC3_ADC_SQR1_SQ2                                \ 2nd conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 2nd in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$007c0000 constant ADC3_ADC_SQR1_SQ3                                \ 3rd conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 3rd in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$1f000000 constant ADC3_ADC_SQR1_SQ4                                \ 4th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 4th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).


\
\ @brief ADC regular sequence register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000001f constant ADC3_ADC_SQR2_SQ5                                \ 5th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 5th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$000007c0 constant ADC3_ADC_SQR2_SQ6                                \ 6th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 6th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$0001f000 constant ADC3_ADC_SQR2_SQ7                                \ 7th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 7th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$007c0000 constant ADC3_ADC_SQR2_SQ8                                \ 8th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 8th in the regular conversion sequence Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$1f000000 constant ADC3_ADC_SQR2_SQ9                                \ 9th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 9th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).


\
\ @brief ADC regular sequence register 3
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant ADC3_ADC_SQR3_SQ10                               \ 10th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 10th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$000007c0 constant ADC3_ADC_SQR3_SQ11                               \ 11th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 11th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$0001f000 constant ADC3_ADC_SQR3_SQ12                               \ 12th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 12th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$007c0000 constant ADC3_ADC_SQR3_SQ13                               \ 13th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 13th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$1f000000 constant ADC3_ADC_SQR3_SQ14                               \ 14th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 14th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).


\
\ @brief ADC regular sequence register 4
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000001f constant ADC3_ADC_SQR4_SQ15                               \ 15th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 15th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$000007c0 constant ADC3_ADC_SQR4_SQ16                               \ 16th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 16th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).


\
\ @brief ADC regular data register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant ADC3_ADC_DR_RDATA                                \ Regular data converted These bits are read-only. They contain the conversion result from the last converted regular channel. The data are left- or right-aligned as described in .


\
\ @brief ADC injected sequence register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000003 constant ADC3_ADC_JSQR_JL                                 \ Injected channel sequence length These bits are written by software to define the total number of conversions in the injected channel conversion sequence. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
$0000007c constant ADC3_ADC_JSQR_JEXTSEL                            \ External Trigger Selection for injected group These bits select the external event used to trigger the start of conversion of an injected group: ... Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
$00000180 constant ADC3_ADC_JSQR_JEXTEN                             \ External trigger enable and polarity selection for injected channels These bits are set and cleared by software to select the external trigger polarity and enable the trigger of an injected group. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing). If JQM = 1 and if the Queue of Context becomes empty, the software and hardware triggers of the injected sequence are both internally disabled (refer to Queue of context for injected conversions)
$00003e00 constant ADC3_ADC_JSQR_JSQ1                               \ 1st conversion in the injected sequence These bits are written by software with the channel number (0 to 18) assigned as the 1st in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
$000f8000 constant ADC3_ADC_JSQR_JSQ2                               \ 2nd conversion in the injected sequence These bits are written by software with the channel number (0 to 18) assigned as the 2nd in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
$03e00000 constant ADC3_ADC_JSQR_JSQ3                               \ 3rd conversion in the injected sequence These bits are written by software with the channel number (0 to 18) assigned as the 3rd in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
$f8000000 constant ADC3_ADC_JSQR_JSQ4                               \ 4th conversion in the injected sequence These bits are written by software with the channel number (0 to 18) assigned as the 4th in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing).


\
\ @brief ADC offset 1 register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000fff constant ADC3_ADC_OFR1_OFFSET                             \ Data offset y for the channel programmed into bits OFFSET_CH[4:0] These bits are written by software to define the offset to be subtracted from the raw converted data when converting a channel (can be regular or injected). The channel to which applies the data offset must be programmed in the bits OFFSET_CH[4:0]. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If several offset (OFFSET) point to the same channel, only the offset with the lowest x value is considered for the subtraction. Ex: if OFFSET1_CH[4:0] = 4 and OFFSET2_CH[4:0] = 4, this is OFFSET1[11:0] which is subtracted when converting channel 4.
$01000000 constant ADC3_ADC_OFR1_OFFSETPOS                          \ Positive offset This bit is set and cleared by software to enable the positive offset. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$02000000 constant ADC3_ADC_OFR1_SATEN                              \ Saturation enable This bit is set and cleared by software to enable the saturation at 0x000 and 0xFFF for the offset function. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$7c000000 constant ADC3_ADC_OFR1_OFFSET_CH                          \ Channel selection for the data offset y These bits are written by software to define the channel to which the offset programmed into bits OFFSET[11:0] applies. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically and must not be selected for the data offset y. If OFFSET_EN is set, it is not allowed to select the same channel for different ADC_OFRy registers.
$80000000 constant ADC3_ADC_OFR1_OFFSET_EN                          \ Offset y enable This bit is written by software to enable or disable the offset programmed into bits OFFSET[11:0]. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).


\
\ @brief ADC offset 2 register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000fff constant ADC3_ADC_OFR2_OFFSET                             \ Data offset y for the channel programmed into bits OFFSET_CH[4:0] These bits are written by software to define the offset to be subtracted from the raw converted data when converting a channel (can be regular or injected). The channel to which applies the data offset must be programmed in the bits OFFSET_CH[4:0]. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If several offset (OFFSET) point to the same channel, only the offset with the lowest x value is considered for the subtraction. Ex: if OFFSET1_CH[4:0] = 4 and OFFSET2_CH[4:0] = 4, this is OFFSET1[11:0] which is subtracted when converting channel 4.
$01000000 constant ADC3_ADC_OFR2_OFFSETPOS                          \ Positive offset This bit is set and cleared by software to enable the positive offset. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$02000000 constant ADC3_ADC_OFR2_SATEN                              \ Saturation enable This bit is set and cleared by software to enable the saturation at 0x000 and 0xFFF for the offset function. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$7c000000 constant ADC3_ADC_OFR2_OFFSET_CH                          \ Channel selection for the data offset y These bits are written by software to define the channel to which the offset programmed into bits OFFSET[11:0] applies. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically and must not be selected for the data offset y. If OFFSET_EN is set, it is not allowed to select the same channel for different ADC_OFRy registers.
$80000000 constant ADC3_ADC_OFR2_OFFSET_EN                          \ Offset y enable This bit is written by software to enable or disable the offset programmed into bits OFFSET[11:0]. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).


\
\ @brief ADC offset 3 register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000fff constant ADC3_ADC_OFR3_OFFSET                             \ Data offset y for the channel programmed into bits OFFSET_CH[4:0] These bits are written by software to define the offset to be subtracted from the raw converted data when converting a channel (can be regular or injected). The channel to which applies the data offset must be programmed in the bits OFFSET_CH[4:0]. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If several offset (OFFSET) point to the same channel, only the offset with the lowest x value is considered for the subtraction. Ex: if OFFSET1_CH[4:0] = 4 and OFFSET2_CH[4:0] = 4, this is OFFSET1[11:0] which is subtracted when converting channel 4.
$01000000 constant ADC3_ADC_OFR3_OFFSETPOS                          \ Positive offset This bit is set and cleared by software to enable the positive offset. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$02000000 constant ADC3_ADC_OFR3_SATEN                              \ Saturation enable This bit is set and cleared by software to enable the saturation at 0x000 and 0xFFF for the offset function. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$7c000000 constant ADC3_ADC_OFR3_OFFSET_CH                          \ Channel selection for the data offset y These bits are written by software to define the channel to which the offset programmed into bits OFFSET[11:0] applies. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically and must not be selected for the data offset y. If OFFSET_EN is set, it is not allowed to select the same channel for different ADC_OFRy registers.
$80000000 constant ADC3_ADC_OFR3_OFFSET_EN                          \ Offset y enable This bit is written by software to enable or disable the offset programmed into bits OFFSET[11:0]. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).


\
\ @brief ADC offset 4 register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000fff constant ADC3_ADC_OFR4_OFFSET                             \ Data offset y for the channel programmed into bits OFFSET_CH[4:0] These bits are written by software to define the offset to be subtracted from the raw converted data when converting a channel (can be regular or injected). The channel to which applies the data offset must be programmed in the bits OFFSET_CH[4:0]. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If several offset (OFFSET) point to the same channel, only the offset with the lowest x value is considered for the subtraction. Ex: if OFFSET1_CH[4:0] = 4 and OFFSET2_CH[4:0] = 4, this is OFFSET1[11:0] which is subtracted when converting channel 4.
$01000000 constant ADC3_ADC_OFR4_OFFSETPOS                          \ Positive offset This bit is set and cleared by software to enable the positive offset. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$02000000 constant ADC3_ADC_OFR4_SATEN                              \ Saturation enable This bit is set and cleared by software to enable the saturation at 0x000 and 0xFFF for the offset function. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
$7c000000 constant ADC3_ADC_OFR4_OFFSET_CH                          \ Channel selection for the data offset y These bits are written by software to define the channel to which the offset programmed into bits OFFSET[11:0] applies. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically and must not be selected for the data offset y. If OFFSET_EN is set, it is not allowed to select the same channel for different ADC_OFRy registers.
$80000000 constant ADC3_ADC_OFR4_OFFSET_EN                          \ Offset y enable This bit is written by software to enable or disable the offset programmed into bits OFFSET[11:0]. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).


\
\ @brief ADC injected channel 1 data register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$0000ffff constant ADC3_ADC_JDR1_JDATA                              \ Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in .


\
\ @brief ADC injected channel 2 data register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000ffff constant ADC3_ADC_JDR2_JDATA                              \ Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in .


\
\ @brief ADC injected channel 3 data register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$0000ffff constant ADC3_ADC_JDR3_JDATA                              \ Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in .


\
\ @brief ADC injected channel 4 data register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000ffff constant ADC3_ADC_JDR4_JDATA                              \ Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in .


\
\ @brief ADC Analog Watchdog 2 Configuration Register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$0007ffff constant ADC3_ADC_AWD2CR_AWD2CH                           \ Analog watchdog 2 channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by the analog watchdog 2. AWD2CH[i] = 0: ADC analog input channel i is not monitored by AWD2 AWD2CH[i] = 1: ADC analog input channel i is monitored by AWD2 When AWD2CH[18:0] = 000..0, the analog Watchdog 2 is disabled Note: The channels selected by AWD2CH must be also selected into the SQRi or JSQRi registers. The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically and must not be selected for the analog watchdog.


\
\ @brief ADC Analog Watchdog 3 Configuration Register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$0007ffff constant ADC3_ADC_AWD3CR_AWD3CH                           \ Analog watchdog 3 channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by the analog watchdog 3. AWD3CH[i] = 0: ADC analog input channel i is not monitored by AWD3 AWD3CH[i] = 1: ADC analog input channel i is monitored by AWD3 When AWD3CH[18:0] = 000..0, the analog Watchdog 3 is disabled Note: The channels selected by AWD3CH must be also selected into the SQRi or JSQRi registers. The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Some channels are not connected physically and must not be selected for the analog watchdog.


\
\ @brief ADC Differential mode Selection Register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$0007ffff constant ADC3_ADC_DIFSEL_DIFSEL                           \ Differential mode for channels 18 to 0. These bits are set and cleared by software. They allow to select if a channel is configured as Single-ended or Differential mode. DIFSEL[i] = 0: ADC analog input channel is configured in Single-ended mode DIFSEL[i] = 1: ADC analog input channel i is configured in Differential mode Note: The DIFSEL bits corresponding to channels that are either connected to a single-ended I/O port or to an internal channel must be kept their reset value (Single-ended input mode). The software is allowed to write these bits only when the ADC is disabled (ADCAL = 0, JADSTART = 0, JADSTP = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).


\
\ @brief ADC Calibration Factors
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$0000007f constant ADC3_ADC_CALFACT_CALFACT_S                       \ Calibration Factors In Single-ended mode These bits are written by hardware or by software. Once a single-ended inputs calibration is complete, they are updated by hardware with the calibration factors. Software can write these bits with a new calibration factor. If the new calibration factor is different from the current one stored into the analog ADC, it is then applied once a new single-ended calibration is launched. Note: The software is allowed to write these bits only when ADEN = 1, ADSTART = 0 and JADSTART = 0 (ADC is enabled and no calibration is ongoing and no conversion is ongoing).
$007f0000 constant ADC3_ADC_CALFACT_CALFACT_D                       \ Calibration Factors in differential mode These bits are written by hardware or by software. Once a differential inputs calibration is complete, they are updated by hardware with the calibration factors. Software can write these bits with a new calibration factor. If the new calibration factor is different from the current one stored into the analog ADC, it is then applied once a new differential calibration is launched. Note: The software is allowed to write these bits only when ADEN = 1, ADSTART = 0 and JADSTART = 0 (ADC is enabled and no calibration is ongoing and no conversion is ongoing).


\
\ @brief Analog-to-Digital Converter
\
$58026000 constant ADC3_ADC_ISR   \ offset: 0x00 : ADC interrupt and status register
$58026004 constant ADC3_ADC_IER   \ offset: 0x04 : ADC interrupt enable register
$58026008 constant ADC3_ADC_CR    \ offset: 0x08 : ADC control register
$5802600c constant ADC3_ADC_CFGR  \ offset: 0x0C : ADC configuration register
$58026010 constant ADC3_ADC_CFGR2  \ offset: 0x10 : ADC configuration register 2
$58026014 constant ADC3_ADC_SMPR1  \ offset: 0x14 : ADC sample time register 1
$58026018 constant ADC3_ADC_SMPR2  \ offset: 0x18 : ADC sample time register 2
$58026020 constant ADC3_ADC_TR1   \ offset: 0x20 : ADC watchdog threshold register 1
$58026024 constant ADC3_ADC_TR2   \ offset: 0x24 : ADC watchdog threshold register 2
$58026028 constant ADC3_ADC_TR3   \ offset: 0x28 : ADC watchdog threshold register 3
$58026030 constant ADC3_ADC_SQR1  \ offset: 0x30 : ADC regular sequence register 1
$58026034 constant ADC3_ADC_SQR2  \ offset: 0x34 : ADC regular sequence register 2
$58026038 constant ADC3_ADC_SQR3  \ offset: 0x38 : ADC regular sequence register 3
$5802603c constant ADC3_ADC_SQR4  \ offset: 0x3C : ADC regular sequence register 4
$58026040 constant ADC3_ADC_DR    \ offset: 0x40 : ADC regular data register
$5802604c constant ADC3_ADC_JSQR  \ offset: 0x4C : ADC injected sequence register
$58026060 constant ADC3_ADC_OFR1  \ offset: 0x60 : ADC offset 1 register
$58026064 constant ADC3_ADC_OFR2  \ offset: 0x64 : ADC offset 2 register
$58026068 constant ADC3_ADC_OFR3  \ offset: 0x68 : ADC offset 3 register
$5802606c constant ADC3_ADC_OFR4  \ offset: 0x6C : ADC offset 4 register
$58026080 constant ADC3_ADC_JDR1  \ offset: 0x80 : ADC injected channel 1 data register
$58026084 constant ADC3_ADC_JDR2  \ offset: 0x84 : ADC injected channel 2 data register
$58026088 constant ADC3_ADC_JDR3  \ offset: 0x88 : ADC injected channel 3 data register
$5802608c constant ADC3_ADC_JDR4  \ offset: 0x8C : ADC injected channel 4 data register
$580260a0 constant ADC3_ADC_AWD2CR  \ offset: 0xA0 : ADC Analog Watchdog 2 Configuration Register
$580260a4 constant ADC3_ADC_AWD3CR  \ offset: 0xA4 : ADC Analog Watchdog 3 Configuration Register
$580260b0 constant ADC3_ADC_DIFSEL  \ offset: 0xB0 : ADC Differential mode Selection Register
$580260b4 constant ADC3_ADC_CALFACT  \ offset: 0xB4 : ADC Calibration Factors

