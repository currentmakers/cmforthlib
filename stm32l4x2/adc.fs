\
\ @file adc.fs
\ @brief Analog-to-Digital Converter
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
    $00 constant ADC_ADRDY                      \ [0x00] ADC ready This bit is set by hardware after the ADC has been enabled (bit ADEN = 1) and when the ADC reaches a state where it is ready to accept conversion requests. It is cleared by software writing 1 to it.
    $01 constant ADC_EOSMP                      \ [0x01] End of sampling flag This bit is set by hardware during the conversion of any channel (only for regular channels), at the end of the sampling phase.
    $02 constant ADC_EOC                        \ [0x02] End of conversion flag This bit is set by hardware at the end of each regular conversion of a channel when a new data is available in the ADC_DR register. It is cleared by software writing 1 to it or by reading the ADC_DR register
    $03 constant ADC_EOS                        \ [0x03] End of regular sequence flag This bit is set by hardware at the end of the conversions of a regular sequence of channels. It is cleared by software writing 1 to it.
    $04 constant ADC_OVR                        \ [0x04] ADC overrun This bit is set by hardware when an overrun occurs on a regular channel, meaning that a new conversion has completed while the EOC flag was already set. It is cleared by software writing 1 to it.
    $05 constant ADC_JEOC                       \ [0x05] Injected channel end of conversion flag This bit is set by hardware at the end of each injected conversion of a channel when a new data is available in the corresponding ADC_JDRy register. It is cleared by software writing 1 to it or by reading the corresponding ADC_JDRy register
    $06 constant ADC_JEOS                       \ [0x06] Injected channel end of sequence flag This bit is set by hardware at the end of the conversions of all injected channels in the group. It is cleared by software writing 1 to it.
    $07 constant ADC_AWD1                       \ [0x07] Analog watchdog 1 flag This bit is set by hardware when the converted voltage crosses the values programmed in the fields LT1[11:0] and HT1[11:0] of ADC_TR1 register. It is cleared by software. writing 1 to it.
    $08 constant ADC_AWD2                       \ [0x08] Analog watchdog 2 flag This bit is set by hardware when the converted voltage crosses the values programmed in the fields LT2[7:0] and HT2[7:0] of ADC_TR2 register. It is cleared by software writing 1 to it.
    $09 constant ADC_AWD3                       \ [0x09] Analog watchdog 3 flag This bit is set by hardware when the converted voltage crosses the values programmed in the fields LT3[7:0] and HT3[7:0] of ADC_TR3 register. It is cleared by software writing 1 to it.
    $0a constant ADC_JQOVF                      \ [0x0a] Injected context queue overflow This bit is set by hardware when an Overflow of the Injected Queue of Context occurs. It is cleared by software writing 1 to it. Refer to Section 16.4.21: Queue of context for injected conversions for more information.
  [then]


  [ifdef] ADC_ADC_IER_DEF
    \
    \ @brief ADC interrupt enable register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ADRDYIE                    \ [0x00] ADC ready interrupt enable This bit is set and cleared by software to enable/disable the ADC Ready interrupt. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $01 constant ADC_EOSMPIE                    \ [0x01] End of sampling flag interrupt enable for regular conversions This bit is set and cleared by software to enable/disable the end of the sampling phase interrupt for regular conversions. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $02 constant ADC_EOCIE                      \ [0x02] End of regular conversion interrupt enable This bit is set and cleared by software to enable/disable the end of a regular conversion interrupt. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $03 constant ADC_EOSIE                      \ [0x03] End of regular sequence of conversions interrupt enable This bit is set and cleared by software to enable/disable the end of regular sequence of conversions interrupt. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $04 constant ADC_OVRIE                      \ [0x04] Overrun interrupt enable This bit is set and cleared by software to enable/disable the Overrun interrupt of a regular conversion. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $05 constant ADC_JEOCIE                     \ [0x05] End of injected conversion interrupt enable This bit is set and cleared by software to enable/disable the end of an injected conversion interrupt. Note: The software is allowed to write this bit only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
    $06 constant ADC_JEOSIE                     \ [0x06] End of injected sequence of conversions interrupt enable This bit is set and cleared by software to enable/disable the end of injected sequence of conversions interrupt. Note: The software is allowed to write this bit only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
    $07 constant ADC_AWD1IE                     \ [0x07] Analog watchdog 1 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog 1 interrupt. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $08 constant ADC_AWD2IE                     \ [0x08] Analog watchdog 2 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog 2 interrupt. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $09 constant ADC_AWD3IE                     \ [0x09] Analog watchdog 3 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog 2 interrupt. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $0a constant ADC_JQOVFIE                    \ [0x0a] Injected context queue overflow interrupt enable This bit is set and cleared by software to enable/disable the Injected Context Queue Overflow interrupt. Note: The software is allowed to write this bit only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_CR_DEF
    \
    \ @brief ADC control register
    \ Address offset: 0x08
    \ Reset value: 0x20000000
    \
    $00 constant ADC_ADEN                       \ [0x00] ADC enable control This bit is set by software to enable the ADC. The ADC is effectively ready to operate once the flag ADRDY has been set. It is cleared by hardware when the ADC is disabled, after the execution of the ADDIS command. Note: The software is allowed to set ADEN only when all bits of ADC_CR registers are 0 (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0) except for bit ADVREGEN which must be 1 (and the software must have wait for the startup time of the voltage regulator)
    $01 constant ADC_ADDIS                      \ [0x01] ADC disable command This bit is set by software to disable the ADC (ADDIS command) and put it into power-down state (OFF state). It is cleared by hardware once the ADC is effectively disabled (ADEN is also cleared by hardware at this time). Note: The software is allowed to set ADDIS only when ADEN = 1 and both ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing)
    $02 constant ADC_ADSTART                    \ [0x02] ADC start of regular conversion This bit is set by software to start ADC conversion of regular channels. Depending on the configuration bits EXTEN[1:0], a conversion starts immediately (software trigger configuration) or once a regular hardware trigger event occurs (hardware trigger configuration). It is cleared by hardware: in single conversion mode when software trigger is selected (EXTSEL = 0x0): at the assertion of the End of Regular Conversion Sequence (EOS) flag. in all cases: after the execution of the ADSTP command, at the same time that ADSTP is cleared by hardware. Note: The software is allowed to set ADSTART only when ADEN = 1 and ADDIS = 0 (ADC is enabled and there is no pending request to disable the ADC) Note: In auto-injection mode (JAUTO = 1), regular and auto-injected conversions are started by setting bit ADSTART (JADSTART must be kept cleared)
    $03 constant ADC_JADSTART                   \ [0x03] ADC start of injected conversion This bit is set by software to start ADC conversion of injected channels. Depending on the configuration bits JEXTEN[1:0], a conversion starts immediately (software trigger configuration) or once an injected hardware trigger event occurs (hardware trigger configuration). It is cleared by hardware: in single conversion mode when software trigger is selected (JEXTSEL = 0x0): at the assertion of the End of Injected Conversion Sequence (JEOS) flag. in all cases: after the execution of the JADSTP command, at the same time that JADSTP is cleared by hardware. Note: The software is allowed to set JADSTART only when ADEN = 1 and ADDIS = 0 (ADC is enabled and there is no pending request to disable the ADC). Note: In auto-injection mode (JAUTO = 1), regular and auto-injected conversions are started by setting bit ADSTART (JADSTART must be kept cleared)
    $04 constant ADC_ADSTP                      \ [0x04] ADC stop of regular conversion command This bit is set by software to stop and discard an ongoing regular conversion (ADSTP Command). It is cleared by hardware when the conversion is effectively discarded and the ADC regular sequence and triggers can be re-configured. The ADC is then ready to accept a new start of regular conversions (ADSTART command). Note: The software is allowed to set ADSTP only when ADSTART = 1 and ADDIS = 0 (ADC is enabled and eventually converting a regular conversion and there is no pending request to disable the ADC). In auto-injection mode (JAUTO = 1), setting ADSTP bit aborts both regular and injected conversions (do not use JADSTP).
    $05 constant ADC_JADSTP                     \ [0x05] ADC stop of injected conversion command This bit is set by software to stop and discard an ongoing injected conversion (JADSTP Command). It is cleared by hardware when the conversion is effectively discarded and the ADC injected sequence and triggers can be re-configured. The ADC is then ready to accept a new start of injected conversions (JADSTART command). Note: The software is allowed to set JADSTP only when JADSTART = 1 and ADDIS = 0 (ADC is enabled and eventually converting an injected conversion and there is no pending request to disable the ADC) Note: In Auto-injection mode (JAUTO = 1), setting ADSTP bit aborts both regular and injected conversions (do not use JADSTP)
    $1c constant ADC_ADVREGEN                   \ [0x1c] ADC voltage regulator enable This bits is set by software to enable the ADC voltage regulator. Before performing any operation such as launching a calibration or enabling the ADC, the ADC voltage regulator must first be enabled and the software must wait for the regulator start-up time. For more details about the ADC voltage regulator enable and disable sequences, refer to Section 16.4.6: ADC Deep-power-down mode (DEEPPWD) and ADC voltage regulator (ADVREGEN). The software can program this bit field only when the ADC is disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
    $1d constant ADC_DEEPPWD                    \ [0x1d] Deep-power-down enable This bit is set and cleared by software to put the ADC in Deep-power-down mode. Note: The software is allowed to write this bit only when the ADC is disabled (ADCAL = 0, JADSTART = 0, JADSTP = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
    $1e constant ADC_ADCALDIF                   \ [0x1e] Differential mode for calibration This bit is set and cleared by software to configure the single-ended or differential inputs mode for the calibration. Note: The software is allowed to write this bit only when the ADC is disabled and is not calibrating (ADCAL = 0, JADSTART = 0, JADSTP = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
    $1f constant ADC_ADCAL                      \ [0x1f] ADC calibration This bit is set by software to start the calibration of the ADC. Program first the bit ADCALDIF to determine if this calibration applies for single-ended or differential inputs mode. It is cleared by hardware after calibration is complete. Note: The software is allowed to launch a calibration by setting ADCAL only when ADEN = 0. Note: The software is allowed to update the calibration factor by writing ADC_CALFACT only when ADEN = 1 and ADSTART = 0 and JADSTART = 0 (ADC enabled and no conversion is ongoing)
  [then]


  [ifdef] ADC_ADC_CFGR_DEF
    \
    \ @brief ADC configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x80000000
    \
    $00 constant ADC_DMAEN                      \ [0x00] Direct memory access enable This bit is set and cleared by software to enable the generation of DMA requests. This allows to use the DMA to manage automatically the converted data. For more details, refer to Section : Managing conversions using the DMA. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: In dual-ADC modes, this bit is not relevant and replaced by control bits MDMA[1:0] of the ADCx_CCR register.
    $01 constant ADC_DMACFG                     \ [0x01] Direct memory access configuration This bit is set and cleared by software to select between two DMA modes of operation and is effective only when DMAEN = 1. For more details, refer to Section : Managing conversions using the DMA Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: In dual-ADC modes, this bit is not relevant and replaced by control bit DMACFG of the ADCx_CCR register.
    $02 constant ADC_DFSDMCFG                   \ [0x02] DFSDM mode configuration This bit is set and cleared by software to enable the DFSDM mode. It is effective only when DMAEN = 0. Note: To make sure no conversion is ongoing, the software is allowed to write this bit only when ADSTART= 0 and JADSTART= 0.
    $03 constant ADC_RES                        \ [0x03 : 2] Data resolution These bits are written by software to select the resolution of the conversion. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $05 constant ADC_ALIGN                      \ [0x05] Data alignment This bit is set and cleared by software to select right or left alignment. Refer to Section : Data register, data alignment and offset (ADC_DR, OFFSETy, OFFSETy_CH, ALIGN) Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $06 constant ADC_EXTSEL0                    \ [0x06] External trigger selection for regular group These bits select the external event used to trigger the start of conversion of a regular group: ... Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $07 constant ADC_EXTSEL1                    \ [0x07] External trigger selection for regular group These bits select the external event used to trigger the start of conversion of a regular group: ... Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $08 constant ADC_EXTSEL2                    \ [0x08] External trigger selection for regular group These bits select the external event used to trigger the start of conversion of a regular group: ... Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $09 constant ADC_EXTSEL3                    \ [0x09] External trigger selection for regular group These bits select the external event used to trigger the start of conversion of a regular group: ... Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $0a constant ADC_EXTEN                      \ [0x0a : 2] External trigger enable and polarity selection for regular channels These bits are set and cleared by software to select the external trigger polarity and enable the trigger of a regular group. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $0c constant ADC_OVRMOD                     \ [0x0c] Overrun mode This bit is set and cleared by software and configure the way data overrun is managed. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $0d constant ADC_CONT                       \ [0x0d] Single / continuous conversion mode for regular conversions This bit is set and cleared by software. If it is set, regular conversion takes place continuously until it is cleared. Note: It is not possible to have both discontinuous mode and continuous mode enabled: it is forbidden to set both DISCEN = 1 and CONT = 1. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing). Note: When dual mode is enabled (DUAL bits in ADCx_CCR register are not equal to zero), the bit CONT of the slave ADC is no more writable and its content is equal to the bit CONT of the master ADC.
    $0e constant ADC_AUTDLY                     \ [0x0e] Delayed conversion mode This bit is set and cleared by software to enable/disable the Auto Delayed Conversion mode. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: When dual mode is enabled (DUAL bits in ADCx_CCR register are not equal to zero), the bit AUTDLY of the slave ADC is no more writable and its content is equal to the bit AUTDLY of the master ADC.
    $10 constant ADC_DISCEN                     \ [0x10] Discontinuous mode for regular channels This bit is set and cleared by software to enable/disable Discontinuous mode for regular channels. Note: It is not possible to have both discontinuous mode and continuous mode enabled: it is forbidden to set both DISCEN = 1 and CONT = 1. Note: It is not possible to use both auto-injected mode and discontinuous mode simultaneously: the bits DISCEN and JDISCEN must be kept cleared by software when JAUTO is set. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing). Note: When dual mode is enabled (DUAL bits in ADCx_CCR register are not equal to zero), the bit DISCEN of the slave ADC is no more writable and its content is equal to the bit DISCEN of the master ADC.
    $11 constant ADC_DISCNUM                    \ [0x11 : 3] Discontinuous mode channel count These bits are written by software to define the number of regular channels to be converted in discontinuous mode, after receiving an external trigger. ... Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing). Note: When dual mode is enabled (DUAL bits in ADCx_CCR register are not equal to zero), the bits DISCNUM[2:0] of the slave ADC are no more writable and their content is equal to the bits DISCNUM[2:0] of the master ADC.
    $14 constant ADC_JDISCEN                    \ [0x14] Discontinuous mode on injected channels This bit is set and cleared by software to enable/disable discontinuous mode on the injected channels of a group. Note: The software is allowed to write this bit only when JADSTART = 0 (which ensures that no injected conversion is ongoing). Note: It is not possible to use both auto-injected mode and discontinuous mode simultaneously: the bits DISCEN and JDISCEN must be kept cleared by software when JAUTO is set. Note: When dual mode is enabled (bits DUAL of ADCx_CCR register are not equal to zero), the bit JDISCEN of the slave ADC is no more writable and its content is equal to the bit JDISCEN of the master ADC.
    $15 constant ADC_JQM                        \ [0x15] JSQR queue mode This bit is set and cleared by software. It defines how an empty Queue is managed. Refer to Section 16.4.21: Queue of context for injected conversions for more information. Note: The software is allowed to write this bit only when JADSTART = 0 (which ensures that no injected conversion is ongoing). Note: When dual mode is enabled (DUAL bits in ADCx_CCR register are not equal to zero), the bit JQM of the slave ADC is no more writable and its content is equal to the bit JQM of the master ADC.
    $16 constant ADC_AWD1SGL                    \ [0x16] Enable the watchdog 1 on a single channel or on all channels This bit is set and cleared by software to enable the analog watchdog on the channel identified by the AWD1CH[4:0] bits or on all the channels Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $17 constant ADC_AWD1EN                     \ [0x17] Analog watchdog 1 enable on regular channels This bit is set and cleared by software Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $18 constant ADC_JAWD1EN                    \ [0x18] Analog watchdog 1 enable on injected channels This bit is set and cleared by software Note: The software is allowed to write this bit only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
    $19 constant ADC_JAUTO                      \ [0x19] Automatic injected group conversion This bit is set and cleared by software to enable/disable automatic injected group conversion after regular group conversion. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no regular nor injected conversion is ongoing). Note: When dual mode is enabled (DUAL bits in ADCx_CCR register are not equal to zero), the bit JAUTO of the slave ADC is no more writable and its content is equal to the bit JAUTO of the master ADC.
    $1a constant ADC_AWD1CH                     \ [0x1a : 5] Analog watchdog 1 channel selection These bits are set and cleared by software. They select the input channel to be guarded by the analog watchdog. ..... others: reserved, must not be used Note: Some channels are not connected physically. Keep the corresponding AWD1CH[4:0] setting to the reset value. Note: The channel selected by AWD1CH must be also selected into the SQRi or JSQRi registers. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $1f constant ADC_JQDIS                      \ [0x1f] Injected Queue disable These bits are set and cleared by software to disable the Injected Queue mechanism : Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no regular nor injected conversion is ongoing). Note: A set or reset of JQDIS bit causes the injected queue to be flushed and the JSQR register is cleared.
  [then]


  [ifdef] ADC_ADC_CFGR2_DEF
    \
    \ @brief ADC configuration register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ROVSE                      \ [0x00] Regular Oversampling Enable This bit is set and cleared by software to enable regular oversampling. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing)
    $01 constant ADC_JOVSE                      \ [0x01] Injected Oversampling Enable This bit is set and cleared by software to enable injected oversampling. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing)
    $02 constant ADC_OVSR                       \ [0x02 : 3] Oversampling ratio This bitfield is set and cleared by software to define the oversampling ratio. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no conversion is ongoing).
    $05 constant ADC_OVSS                       \ [0x05 : 4] Oversampling shift This bitfield is set and cleared by software to define the right shifting applied to the raw oversampling result. Other codes reserved Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no conversion is ongoing).
    $09 constant ADC_TROVS                      \ [0x09] Triggered Regular Oversampling This bit is set and cleared by software to enable triggered oversampling Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
    $0a constant ADC_ROVSM                      \ [0x0a] Regular Oversampling mode This bit is set and cleared by software to select the regular oversampling mode. Note: The software is allowed to write this bit only when ADSTART = 0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_SMPR1_DEF
    \
    \ @brief ADC sample time register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SMP0                       \ [0x00 : 3] Channel x sampling time selection (x = 9 to 0) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
    $03 constant ADC_SMP1                       \ [0x03 : 3] Channel x sampling time selection (x = 9 to 0) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
    $06 constant ADC_SMP2                       \ [0x06 : 3] Channel x sampling time selection (x = 9 to 0) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
    $09 constant ADC_SMP3                       \ [0x09 : 3] Channel x sampling time selection (x = 9 to 0) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
    $0c constant ADC_SMP4                       \ [0x0c : 3] Channel x sampling time selection (x = 9 to 0) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
    $0f constant ADC_SMP5                       \ [0x0f : 3] Channel x sampling time selection (x = 9 to 0) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
    $12 constant ADC_SMP6                       \ [0x12 : 3] Channel x sampling time selection (x = 9 to 0) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
    $15 constant ADC_SMP7                       \ [0x15 : 3] Channel x sampling time selection (x = 9 to 0) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
    $18 constant ADC_SMP8                       \ [0x18 : 3] Channel x sampling time selection (x = 9 to 0) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
    $1b constant ADC_SMP9                       \ [0x1b : 3] Channel x sampling time selection (x = 9 to 0) These bits are written by software to select the sampling time individually for each channel. During sample cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
    $1f constant ADC_SMPPLUS                    \ [0x1f] Addition of one clock cycle to the sampling time To make sure no conversion is ongoing, the software is allowed to write this bit only when ADSTART= 0 and JADSTART= 0.
  [then]


  [ifdef] ADC_ADC_SMPR2_DEF
    \
    \ @brief ADC sample time register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SMP10                      \ [0x00 : 3] Channel x sampling time selection (x = 18 to 10) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
    $03 constant ADC_SMP11                      \ [0x03 : 3] Channel x sampling time selection (x = 18 to 10) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
    $06 constant ADC_SMP12                      \ [0x06 : 3] Channel x sampling time selection (x = 18 to 10) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
    $09 constant ADC_SMP13                      \ [0x09 : 3] Channel x sampling time selection (x = 18 to 10) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
    $0c constant ADC_SMP14                      \ [0x0c : 3] Channel x sampling time selection (x = 18 to 10) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
    $0f constant ADC_SMP15                      \ [0x0f : 3] Channel x sampling time selection (x = 18 to 10) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
    $12 constant ADC_SMP16                      \ [0x12 : 3] Channel x sampling time selection (x = 18 to 10) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
    $15 constant ADC_SMP17                      \ [0x15 : 3] Channel x sampling time selection (x = 18 to 10) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
    $18 constant ADC_SMP18                      \ [0x18 : 3] Channel x sampling time selection (x = 18 to 10) These bits are written by software to select the sampling time individually for each channel. During sampling cycles, the channel selection bits must remain unchanged. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically. Keep the corresponding SMPx[2:0] setting to the reset value.
  [then]


  [ifdef] ADC_ADC_TR1_DEF
    \
    \ @brief ADC watchdog threshold register 1
    \ Address offset: 0x20
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC_LT1                        \ [0x00 : 12] Analog watchdog 1 lower threshold These bits are written by software to define the lower threshold for the analog watchdog 1. Refer to Section 16.4.28: Analog window watchdog (AWD1EN, JAWD1EN, AWD1SGL, AWD1CH, AWD2CH, AWD3CH, AWD_HTx, AWD_LTx, AWDx) Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $10 constant ADC_HT1                        \ [0x10 : 12] Analog watchdog 1 higher threshold These bits are written by software to define the higher threshold for the analog watchdog 1. Refer to Section 16.4.28: Analog window watchdog (AWD1EN, JAWD1EN, AWD1SGL, AWD1CH, AWD2CH, AWD3CH, AWD_HTx, AWD_LTx, AWDx) Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_TR2_DEF
    \
    \ @brief ADC watchdog threshold register 2
    \ Address offset: 0x24
    \ Reset value: 0x00FF0000
    \
    $00 constant ADC_LT2                        \ [0x00 : 8] Analog watchdog 2 lower threshold These bits are written by software to define the lower threshold for the analog watchdog 2. Refer to Section 16.4.28: Analog window watchdog (AWD1EN, JAWD1EN, AWD1SGL, AWD1CH, AWD2CH, AWD3CH, AWD_HTx, AWD_LTx, AWDx) Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $10 constant ADC_HT2                        \ [0x10 : 8] Analog watchdog 2 higher threshold These bits are written by software to define the higher threshold for the analog watchdog 2. Refer to Section 16.4.28: Analog window watchdog (AWD1EN, JAWD1EN, AWD1SGL, AWD1CH, AWD2CH, AWD3CH, AWD_HTx, AWD_LTx, AWDx) Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_TR3_DEF
    \
    \ @brief ADC watchdog threshold register 3
    \ Address offset: 0x28
    \ Reset value: 0x00FF0000
    \
    $00 constant ADC_LT3                        \ [0x00 : 8] Analog watchdog 3 lower threshold These bits are written by software to define the lower threshold for the analog watchdog 3. This watchdog compares the 8-bit of LT3 with the 8 MSB of the converted data. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
    $10 constant ADC_HT3                        \ [0x10 : 8] Analog watchdog 3 higher threshold These bits are written by software to define the higher threshold for the analog watchdog 3. Refer to Section 16.4.28: Analog window watchdog (AWD1EN, JAWD1EN, AWD1SGL, AWD1CH, AWD2CH, AWD3CH, AWD_HTx, AWD_LTx, AWDx) Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_SQR1_DEF
    \
    \ @brief ADC regular sequence register 1
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant ADC_L                          \ [0x00 : 4] Regular channel sequence length These bits are written by software to define the total number of conversions in the regular channel conversion sequence. ... Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $06 constant ADC_SQ1                        \ [0x06 : 5] 1st conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 1st in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $0c constant ADC_SQ2                        \ [0x0c : 5] 2nd conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 2nd in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $12 constant ADC_SQ3                        \ [0x12 : 5] 3rd conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 3rd in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $18 constant ADC_SQ4                        \ [0x18 : 5] 4th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 4th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_SQR2_DEF
    \
    \ @brief ADC regular sequence register 2
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ5                        \ [0x00 : 5] 5th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 5th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $06 constant ADC_SQ6                        \ [0x06 : 5] 6th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 6th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $0c constant ADC_SQ7                        \ [0x0c : 5] 7th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 7th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $12 constant ADC_SQ8                        \ [0x12 : 5] 8th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 8th in the regular conversion sequence Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $18 constant ADC_SQ9                        \ [0x18 : 5] 9th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 9th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_SQR3_DEF
    \
    \ @brief ADC regular sequence register 3
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ10                       \ [0x00 : 5] 10th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 10th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $06 constant ADC_SQ11                       \ [0x06 : 5] 11th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 11th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $0c constant ADC_SQ12                       \ [0x0c : 5] 12th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 12th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $12 constant ADC_SQ13                       \ [0x12 : 5] 13th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 13th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $18 constant ADC_SQ14                       \ [0x18 : 5] 14th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 14th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_SQR4_DEF
    \
    \ @brief ADC regular sequence register 4
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ15                       \ [0x00 : 5] 15th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 15th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $06 constant ADC_SQ16                       \ [0x06 : 5] 16th conversion in regular sequence These bits are written by software with the channel number (0 to 18) assigned as the 16th in the regular conversion sequence. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_DR_DEF
    \
    \ @brief ADC regular data register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant ADC_RDATA                      \ [0x00 : 16] Regular data converted These bits are read-only. They contain the conversion result from the last converted regular channel. The data are left- or right-aligned as described in Section 16.4.26: Data management.
  [then]


  [ifdef] ADC_ADC_JSQR_DEF
    \
    \ @brief ADC injected sequence register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JL                         \ [0x00 : 2] Injected channel sequence length These bits are written by software to define the total number of conversions in the injected channel conversion sequence. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
    $02 constant ADC_JEXTSEL                    \ [0x02 : 4] External Trigger Selection for injected group These bits select the external event used to trigger the start of conversion of an injected group: ... Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
    $06 constant ADC_JEXTEN                     \ [0x06 : 2] External Trigger Enable and Polarity Selection for injected channels These bits are set and cleared by software to select the external trigger polarity and enable the trigger of an injected group. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing). Note: If JQM = 1 and if the Queue of Context becomes empty, the software and hardware triggers of the injected sequence are both internally disabled (refer to Section 16.4.21: Queue of context for injected conversions)
    $08 constant ADC_JSQ1                       \ [0x08 : 5] 1st conversion in the injected sequence These bits are written by software with the channel number (0 to 18) assigned as the 1st in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
    $0e constant ADC_JSQ2                       \ [0x0e : 5] 2nd conversion in the injected sequence These bits are written by software with the channel number (0 to 18) assigned as the 2nd in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
    $14 constant ADC_JSQ3                       \ [0x14 : 5] 3rd conversion in the injected sequence These bits are written by software with the channel number (0 to 18) assigned as the 3rd in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
    $1a constant ADC_JSQ4                       \ [0x1a : 5] 4th conversion in the injected sequence These bits are written by software with the channel number (0 to 18) assigned as the 4th in the injected conversion sequence. Note: The software is allowed to write these bits only when JADSTART = 0 (which ensures that no injected conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_OFR1_DEF
    \
    \ @brief ADC offset 1 register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET                     \ [0x00 : 12] Data offset y for the channel programmed into bits OFFSETy_CH[4:0] These bits are written by software to define the offset y to be subtracted from the raw converted data when converting a channel (can be regular or injected). The channel to which applies the data offset y must be programmed in the bits OFFSETy_CH[4:0]. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If several offset (OFFSETy) point to the same channel, only the offset with the lowest x value is considered for the subtraction. Note: Ex: if OFFSET1_CH[4:0]=4 and OFFSET2_CH[4:0]=4, this is OFFSET1[11:0] which is subtracted when converting channel 4.
    $1a constant ADC_OFFSET_CH                  \ [0x1a : 5] Channel selection for the data offset y These bits are written by software to define the channel to which the offset programmed into bits OFFSETy[11:0] applies. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically and must not be selected for the data offset y.
    $1f constant ADC_OFFSET_EN                  \ [0x1f] Offset y enable This bit is written by software to enable or disable the offset programmed into bits OFFSETy[11:0]. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_OFR2_DEF
    \
    \ @brief ADC offset 2 register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET                     \ [0x00 : 12] Data offset y for the channel programmed into bits OFFSETy_CH[4:0] These bits are written by software to define the offset y to be subtracted from the raw converted data when converting a channel (can be regular or injected). The channel to which applies the data offset y must be programmed in the bits OFFSETy_CH[4:0]. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If several offset (OFFSETy) point to the same channel, only the offset with the lowest x value is considered for the subtraction. Note: Ex: if OFFSET1_CH[4:0]=4 and OFFSET2_CH[4:0]=4, this is OFFSET1[11:0] which is subtracted when converting channel 4.
    $1a constant ADC_OFFSET_CH                  \ [0x1a : 5] Channel selection for the data offset y These bits are written by software to define the channel to which the offset programmed into bits OFFSETy[11:0] applies. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically and must not be selected for the data offset y.
    $1f constant ADC_OFFSET_EN                  \ [0x1f] Offset y enable This bit is written by software to enable or disable the offset programmed into bits OFFSETy[11:0]. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_OFR3_DEF
    \
    \ @brief ADC offset 3 register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET                     \ [0x00 : 12] Data offset y for the channel programmed into bits OFFSETy_CH[4:0] These bits are written by software to define the offset y to be subtracted from the raw converted data when converting a channel (can be regular or injected). The channel to which applies the data offset y must be programmed in the bits OFFSETy_CH[4:0]. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If several offset (OFFSETy) point to the same channel, only the offset with the lowest x value is considered for the subtraction. Note: Ex: if OFFSET1_CH[4:0]=4 and OFFSET2_CH[4:0]=4, this is OFFSET1[11:0] which is subtracted when converting channel 4.
    $1a constant ADC_OFFSET_CH                  \ [0x1a : 5] Channel selection for the data offset y These bits are written by software to define the channel to which the offset programmed into bits OFFSETy[11:0] applies. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically and must not be selected for the data offset y.
    $1f constant ADC_OFFSET_EN                  \ [0x1f] Offset y enable This bit is written by software to enable or disable the offset programmed into bits OFFSETy[11:0]. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_OFR4_DEF
    \
    \ @brief ADC offset 4 register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET                     \ [0x00 : 12] Data offset y for the channel programmed into bits OFFSETy_CH[4:0] These bits are written by software to define the offset y to be subtracted from the raw converted data when converting a channel (can be regular or injected). The channel to which applies the data offset y must be programmed in the bits OFFSETy_CH[4:0]. The conversion result can be read from in the ADC_DR (regular conversion) or from in the ADC_JDRyi registers (injected conversion). Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). If several offset (OFFSETy) point to the same channel, only the offset with the lowest x value is considered for the subtraction. Note: Ex: if OFFSET1_CH[4:0]=4 and OFFSET2_CH[4:0]=4, this is OFFSET1[11:0] which is subtracted when converting channel 4.
    $1a constant ADC_OFFSET_CH                  \ [0x1a : 5] Channel selection for the data offset y These bits are written by software to define the channel to which the offset programmed into bits OFFSETy[11:0] applies. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically and must not be selected for the data offset y.
    $1f constant ADC_OFFSET_EN                  \ [0x1f] Offset y enable This bit is written by software to enable or disable the offset programmed into bits OFFSETy[11:0]. Note: The software is allowed to write this bit only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_JDR1_DEF
    \
    \ @brief ADC injected channel 1 data register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 16] Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in Section 16.4.26: Data management.
  [then]


  [ifdef] ADC_ADC_JDR2_DEF
    \
    \ @brief ADC injected channel 2 data register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 16] Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in Section 16.4.26: Data management.
  [then]


  [ifdef] ADC_ADC_JDR3_DEF
    \
    \ @brief ADC injected channel 3 data register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 16] Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in Section 16.4.26: Data management.
  [then]


  [ifdef] ADC_ADC_JDR4_DEF
    \
    \ @brief ADC injected channel 4 data register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 16] Injected data These bits are read-only. They contain the conversion result from injected channel y. The data are left -or right-aligned as described in Section 16.4.26: Data management.
  [then]


  [ifdef] ADC_ADC_AWD2CR_DEF
    \
    \ @brief ADC analog watchdog 2 configuration register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant ADC_AWD2CH                     \ [0x00 : 19] Analog watchdog 2 channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by the analog watchdog 2. AWD2CH[i] = 0: ADC analog input channel i is not monitored by AWD2 AWD2CH[i] = 1: ADC analog input channel i is monitored by AWD2 When AWD2CH[18:0] = 000..0, the analog watchdog 2 is disabled Note: The channels selected by AWD2CH must be also selected into the SQRi or JSQRi registers. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically and must not be selected for the analog watchdog.
  [then]


  [ifdef] ADC_ADC_AWD3CR_DEF
    \
    \ @brief ADC analog watchdog 3 configuration register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant ADC_AWD3CH                     \ [0x00 : 19] Analog watchdog 3 channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by the analog watchdog 3. AWD3CH[i] = 0: ADC analog input channel i is not monitored by AWD3 AWD3CH[i] = 1: ADC analog input channel i is monitored by AWD3 When AWD3CH[18:0] = 000..0, the analog watchdog 3 is disabled Note: The channels selected by AWD3CH must be also selected into the SQRi or JSQRi registers. Note: The software is allowed to write these bits only when ADSTART = 0 and JADSTART = 0 (which ensures that no conversion is ongoing). Note: Some channels are not connected physically and must not be selected for the analog watchdog.
  [then]


  [ifdef] ADC_ADC_DIFSEL_DEF
    \
    \ @brief ADC differential mode selection register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant ADC_DIFSEL                     \ [0x00 : 19] Differential mode for channels 18 to 0. These bits are set and cleared by software. They allow to select if a channel is configured as single-ended or differential mode. DIFSEL[i] = 0: ADC analog input channel is configured in single ended mode DIFSEL[i] = 1: ADC analog input channel i is configured in differential mode Note: The DIFSEL bits corresponding to channels that are either connected to a single-ended I/O port or to an internal channel must be kept their reset value (single-ended input mode). Note: The software is allowed to write these bits only when the ADC is disabled (ADCAL = 0, JADSTART = 0, JADSTP = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
  [then]


  [ifdef] ADC_ADC_CALFACT_DEF
    \
    \ @brief ADC calibration factors
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant ADC_CALFACT_S                  \ [0x00 : 7] Calibration Factors In single-ended mode These bits are written by hardware or by software. Once a single-ended inputs calibration is complete, they are updated by hardware with the calibration factors. Software can write these bits with a new calibration factor. If the new calibration factor is different from the current one stored into the analog ADC, it is then applied once a new single-ended calibration is launched. Note: The software is allowed to write these bits only when ADEN = 1, ADSTART = 0 and JADSTART = 0 (ADC is enabled and no calibration is ongoing and no conversion is ongoing).
    $10 constant ADC_CALFACT_D                  \ [0x10 : 7] Calibration Factors in differential mode These bits are written by hardware or by software. Once a differential inputs calibration is complete, they are updated by hardware with the calibration factors. Software can write these bits with a new calibration factor. If the new calibration factor is different from the current one stored into the analog ADC, it is then applied once a new differential calibration is launched. Note: The software is allowed to write these bits only when ADEN = 1, ADSTART = 0 and JADSTART = 0 (ADC is enabled and no calibration is ongoing and no conversion is ongoing).
  [then]

  \
  \ @brief Analog-to-Digital Converter
  \
  $00 constant ADC_ADC_ISR              \ ADC interrupt and status register
  $04 constant ADC_ADC_IER              \ ADC interrupt enable register
  $08 constant ADC_ADC_CR               \ ADC control register
  $0C constant ADC_ADC_CFGR             \ ADC configuration register
  $10 constant ADC_ADC_CFGR2            \ ADC configuration register 2
  $14 constant ADC_ADC_SMPR1            \ ADC sample time register 1
  $18 constant ADC_ADC_SMPR2            \ ADC sample time register 2
  $20 constant ADC_ADC_TR1              \ ADC watchdog threshold register 1
  $24 constant ADC_ADC_TR2              \ ADC watchdog threshold register 2
  $28 constant ADC_ADC_TR3              \ ADC watchdog threshold register 3
  $30 constant ADC_ADC_SQR1             \ ADC regular sequence register 1
  $34 constant ADC_ADC_SQR2             \ ADC regular sequence register 2
  $38 constant ADC_ADC_SQR3             \ ADC regular sequence register 3
  $3C constant ADC_ADC_SQR4             \ ADC regular sequence register 4
  $40 constant ADC_ADC_DR               \ ADC regular data register
  $4C constant ADC_ADC_JSQR             \ ADC injected sequence register
  $60 constant ADC_ADC_OFR1             \ ADC offset 1 register
  $64 constant ADC_ADC_OFR2             \ ADC offset 2 register
  $68 constant ADC_ADC_OFR3             \ ADC offset 3 register
  $6C constant ADC_ADC_OFR4             \ ADC offset 4 register
  $80 constant ADC_ADC_JDR1             \ ADC injected channel 1 data register
  $84 constant ADC_ADC_JDR2             \ ADC injected channel 2 data register
  $88 constant ADC_ADC_JDR3             \ ADC injected channel 3 data register
  $8C constant ADC_ADC_JDR4             \ ADC injected channel 4 data register
  $A0 constant ADC_ADC_AWD2CR           \ ADC analog watchdog 2 configuration register
  $A4 constant ADC_ADC_AWD3CR           \ ADC analog watchdog 3 configuration register
  $B0 constant ADC_ADC_DIFSEL           \ ADC differential mode selection register
  $B4 constant ADC_ADC_CALFACT          \ ADC calibration factors

: ADC_DEF ; [then]
