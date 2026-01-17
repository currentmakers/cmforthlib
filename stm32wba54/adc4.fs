\
\ @file adc4.fs
\ @brief ADC register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC4_DEF

  [ifdef] ADC4_ADC_ISR_DEF
    \
    \ @brief ADC interrupt and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_ADRDY                     \ [0x00] ADC ready This bit is set by hardware after the ADC has been enabled (ADEN = 1) and when the ADC reaches a state where it is ready to accept conversion requests. It is cleared by software writing 1 to it.
    $01 constant ADC4_EOSMP                     \ [0x01] End of sampling flag This bit is set by hardware during the conversion, at the end of the sampling phase.It is cleared by software by writing 1 to it.
    $02 constant ADC4_EOC                       \ [0x02] End of conversion flag This bit is set by hardware at the end of each conversion of a channel when a new data result is available in the ADC_DR register. It is cleared by software writing 1 to it or by reading the ADC_DR register.
    $03 constant ADC4_EOS                       \ [0x03] End of sequence flag This bit is set by hardware at the end of the conversion of a sequence of channels selected by the CHSEL bits. It is cleared by software writing 1 to it.
    $04 constant ADC4_OVR                       \ [0x04] ADC overrun This bit is set by hardware when an overrun occurs, meaning that a new conversion has complete while the EOC flag was already set. It is cleared by software writing 1 to it.
    $07 constant ADC4_AWD1                      \ [0x07] Analog watchdog 1 flag This bit is set by hardware when the converted voltage crosses the values programmed in ADC_TR1 and ADC_HR1 registers. It is cleared by software by writing 1 to it.
    $08 constant ADC4_AWD2                      \ [0x08] Analog watchdog 2 flag This bit is set by hardware when the converted voltage crosses the values programmed in ADC_AWD2TR and ADC_AWD2TR registers. It is cleared by software writing 1 to it.
    $09 constant ADC4_AWD3                      \ [0x09] Analog watchdog 3 flag This bit is set by hardware when the converted voltage crosses the values programmed in ADC_AWD3TR and ADC_AWD3TR registers. It is cleared by software by writing 1 to it.
    $0b constant ADC4_EOCAL                     \ [0x0b] End of calibration flag This bit is set by hardware when calibration is complete. It is cleared by software writing 1 to it.
    $0c constant ADC4_LDORDY                    \ [0x0c] LDO ready This bit is set by hardware. It indicates that the ADC internal LDO output is ready. It is cleared by software by writing 1 to it.
  [then]


  [ifdef] ADC4_ADC_IER_DEF
    \
    \ @brief ADC interrupt enable register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_ADRDYIE                   \ [0x00] ADC ready interrupt enable This bit is set and cleared by software to enable/disable the ADC Ready interrupt. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $01 constant ADC4_EOSMPIE                   \ [0x01] End of sampling flag interrupt enable This bit is set and cleared by software to enable/disable the end of the sampling phase interrupt. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $02 constant ADC4_EOCIE                     \ [0x02] End of conversion interrupt enable This bit is set and cleared by software to enable/disable the end of conversion interrupt. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $03 constant ADC4_EOSIE                     \ [0x03] End of conversion sequence interrupt enable This bit is set and cleared by software to enable/disable the end of sequence of conversions interrupt. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $04 constant ADC4_OVRIE                     \ [0x04] Overrun interrupt enable This bit is set and cleared by software to enable/disable the overrun interrupt. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $07 constant ADC4_AWD1IE                    \ [0x07] Analog watchdog 1 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog interrupt. Note: The Software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $08 constant ADC4_AWD2IE                    \ [0x08] Analog watchdog 2 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog interrupt. Note: The Software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $09 constant ADC4_AWD3IE                    \ [0x09] Analog watchdog 3 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog interrupt. Note: The Software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $0b constant ADC4_EOCALIE                   \ [0x0b] End of calibration interrupt enable This bit is set and cleared by software to enable/disable the end of calibration interrupt. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $0c constant ADC4_LDORDYIE                  \ [0x0c] LDO ready interrupt enable This bit is set and cleared by software. It is used to enable/disable the LDORDY interrupt. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensure that no conversion is ongoing).
  [then]


  [ifdef] ADC4_ADC_CR_DEF
    \
    \ @brief ADC control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_ADEN                      \ [0x00] ADC enable command This bit is set by software to enable the ADC. The ADC is effectively ready to operate once the ADRDY flag has been set. It is cleared by hardware when the ADC is disabled, after the execution of the ADDIS command. Note: The software is allowed to set ADEN only when all bits of ADC_CR registers are 0 (ADCAL = 0, ADSTP = 0, ADSTART = 0, ADDIS = 0 and ADEN = 0)
    $01 constant ADC4_ADDIS                     \ [0x01] ADC disable command This bit is set by software to disable the ADC (ADDIS command) and put it into power-down state (OFF state). It is cleared by hardware once the ADC is effectively disabled (ADEN is also cleared by hardware at this time). Note: Setting ADDIS to 1 is only effective when ADEN = 1 and ADSTART = 0 (which ensures that no conversion is ongoing)
    $02 constant ADC4_ADSTART                   \ [0x02] ADC start conversion command This bit is set by software to start ADC conversion. Depending on the EXTEN [1:0] configuration bits, a conversion either starts immediately (software trigger configuration) or once a hardware trigger event occurs (hardware trigger configuration). It is cleared by hardware: In single conversion mode (CONT = 0, DISCEN = 0), when software trigger is selected (EXTEN = 00): at the assertion of the end of Conversion Sequence (EOS) flag. In discontinuous conversion mode(CONT=0, DISCEN = 1), when the software trigger is selected (EXTEN = 00): at the assertion of the end of Conversion (EOC) flag. In all other cases: after the execution of the ADSTP command, at the same time as the ADSTP bit is cleared by hardware. Note: The software is allowed to set ADSTART only when ADEN = 1 and ADDIS = 0 (ADC is enabled and there is no pending request to disable the ADC).
    $04 constant ADC4_ADSTP                     \ [0x04] ADC stop conversion command This bit is set by software to stop and discard an ongoing conversion (ADSTP Command). It is cleared by hardware when the conversion is effectively discarded and the ADC is ready to accept a new start conversion command. Note: To clear the A/D converter state, ADSTP must be set to 1 even if ADSTART is cleared to 0 after the software trigger A/D conversion. It is recommended to set ADSTP to 1 whenever the configuration needs to be modified.
    $1c constant ADC4_ADVREGEN                  \ [0x1c] ADC voltage regulator enable This bit is set by software, to enable the ADC internal voltage regulator. The voltage regulator output is available after tsubADCVREG_SETUP/sub. It is cleared by software to disable the voltage regulator. It can be cleared only if ADEN is et to 0. Note: The software is allowed to program this bit field only when the ADC is disabled (ADCAL = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
    $1f constant ADC4_ADCAL                     \ [0x1f] ADC calibration This bit is set by software to start the calibration of the ADC. It is cleared by hardware after calibration is complete. Note: The software is allowed to set ADCAL only when the ADC is disabled (ADCAL = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0, AUTOFF = 0, and ADEN = 0). Note: The software is allowed to update the calibration factor by writing ADC_CALFACT only when ADEN is set to 1 and ADSTART is cleared to 0 by writing ADSTP to 1 (ADC enabled and no conversion is ongoing).
  [then]


  [ifdef] ADC4_ADC_CFGR1_DEF
    \
    \ @brief ADC configuration register 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_DMAEN                     \ [0x00] Direct memory access enable This bit is set and cleared by software to enable the generation of DMA requests. This allows the automatic management of the converted data by the DMA controller. For more details, refer to Section : Managing converted data using the DMA on page 632. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $01 constant ADC4_DMACFG                    \ [0x01] Direct memory access configuration This bit is set and cleared by software to select between two DMA modes of operation and is effective only when DMAEN = 1. For more details, refer to Section : Managing converted data using the DMA on page 632 Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $02 constant ADC4_RES                       \ [0x02 : 2] Data resolution These bits are written by software to select the resolution of the conversion. Note: The software is allowed to write these bits only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $04 constant ADC4_SCANDIR                   \ [0x04] Scan sequence direction This bit is set and cleared by software to select the direction in which the channels is scanned in the sequence. It is effective only if CHSELRMOD bit is cleared to 0. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $05 constant ADC4_ALIGN                     \ [0x05] Data alignment This bit is set and cleared by software to select right or left alignment. Refer to Figure 78: Data alignment and resolution (oversampling disabled: OVSE = 0) on page 631 Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $06 constant ADC4_EXTSEL                    \ [0x06 : 3] External trigger selection These bits select the external event used to trigger the start of conversion (refer to table ADC interconnection in Section 20.4.2: ADC pins and internal signals for details): Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $0a constant ADC4_EXTEN                     \ [0x0a : 2] External trigger enable and polarity selection These bits are set and cleared by software to select the external trigger polarity and enable the trigger. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $0c constant ADC4_OVRMOD                    \ [0x0c] Overrun management mode This bit is set and cleared by software and configure the way data overruns are managed. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $0d constant ADC4_CONT                      \ [0x0d] Single / continuous conversion mode This bit is set and cleared by software. If it is set, conversion takes place continuously until it is cleared. Note: It is not possible to have both discontinuous mode and continuous mode enabled: it is forbidden to set both bits DISCEN = 1 and CONT = 1. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $0e constant ADC4_WAIT                      \ [0x0e] Wait conversion mode This bit is set and cleared by software to enable/disable wait conversion mode.sup./sup Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $10 constant ADC4_DISCEN                    \ [0x10] Discontinuous mode This bit is set and cleared by software to enable/disable discontinuous mode. Note: It is not possible to have both discontinuous mode and continuous mode enabled: it is forbidden to set both bits DISCEN = 1 and CONT = 1. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $15 constant ADC4_CHSELRMOD                 \ [0x15] Mode selection of the ADC_CHSELR register This bit is set and cleared by software to control the ADC_CHSELR feature: Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $16 constant ADC4_AWD1SGL                   \ [0x16] Enable the watchdog on a single channel or on all channels This bit is set and cleared by software to enable the analog watchdog on the channel identified by the AWDCH[4:0] bits or on all the channels Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $17 constant ADC4_AWD1EN                    \ [0x17] Analog watchdog enable This bit is set and cleared by software. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
    $1a constant ADC4_AWD1CH                    \ [0x1a : 5] Analog watchdog channel selection These bits are set and cleared by software. They select the input channel to be guarded by the analog watchdog. ..... Others: Reserved The channel selected by the AWDCH[4:0] bits must be also set into the CHSELR register. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC4_ADC_CFGR2_DEF
    \
    \ @brief ADC configuration register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_OVSE                      \ [0x00] Oversampler Enable This bit is set and cleared by software. Note: Software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $02 constant ADC4_OVSR                      \ [0x02 : 3] Oversampling ratio This bit filed defines the number of oversampling ratio. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $05 constant ADC4_OVSS                      \ [0x05 : 4] Oversampling shift This bit is set and cleared by software. Others: Reserved Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1(which ensures that no conversion is ongoing).
    $09 constant ADC4_TOVS                      \ [0x09] Triggered Oversampling This bit is set and cleared by software. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $1d constant ADC4_LFTRIG                    \ [0x1d] Low frequency trigger mode enable This bit must be set by software. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC4_ADC_SMPR_DEF
    \
    \ @brief ADC sampling time register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_SMP1                      \ [0x00 : 3] Sampling time selection 1 These bits are written by software to select the sampling time that applies to all channels. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $04 constant ADC4_SMP2                      \ [0x04 : 3] Sampling time selection 2 These bits are written by software to select the sampling time that applies to all channels. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $08 constant ADC4_SMPSEL0                   \ [0x08] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $09 constant ADC4_SMPSEL1                   \ [0x09] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $0a constant ADC4_SMPSEL2                   \ [0x0a] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $0b constant ADC4_SMPSEL3                   \ [0x0b] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $0c constant ADC4_SMPSEL4                   \ [0x0c] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $0d constant ADC4_SMPSEL5                   \ [0x0d] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $0e constant ADC4_SMPSEL6                   \ [0x0e] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $0f constant ADC4_SMPSEL7                   \ [0x0f] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $10 constant ADC4_SMPSEL8                   \ [0x10] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $11 constant ADC4_SMPSEL9                   \ [0x11] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $12 constant ADC4_SMPSEL10                  \ [0x12] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $13 constant ADC4_SMPSEL11                  \ [0x13] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $14 constant ADC4_SMPSEL12                  \ [0x14] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $15 constant ADC4_SMPSEL13                  \ [0x15] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC4_ADC_AWD1TR_DEF
    \
    \ @brief ADC watchdog threshold register
    \ Address offset: 0x20
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC4_LT1                       \ [0x00 : 12] Analog watchdog 1 lower threshold These bits are written by software to define the lower threshold for the analog watchdog. Refer to Section 20.4.25: Analog window watchdog on page 638.
    $10 constant ADC4_HT1                       \ [0x10 : 12] Analog watchdog 1 higher threshold These bits are written by software to define the higher threshold for the analog watchdog. Refer to Section 20.4.25: Analog window watchdog on page 638.
  [then]


  [ifdef] ADC4_ADC_AWD2TR_DEF
    \
    \ @brief ADC watchdog threshold register
    \ Address offset: 0x24
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC4_LT2                       \ [0x00 : 12] Analog watchdog 2 lower threshold These bits are written by software to define the lower threshold for the analog watchdog. Refer to Section 20.4.25: Analog window watchdog on page 638.
    $10 constant ADC4_HT2                       \ [0x10 : 12] Analog watchdog 2 higher threshold These bits are written by software to define the higher threshold for the analog watchdog. Refer to Section 20.4.25: Analog window watchdog on page 638.
  [then]


  [ifdef] ADC4_ADC_CHSELR_DEF
    \
    \ @brief ADC channel selection register [alternate]
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_CHSEL0                    \ [0x00] Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $01 constant ADC4_CHSEL1                    \ [0x01] Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $02 constant ADC4_CHSEL2                    \ [0x02] Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $03 constant ADC4_CHSEL3                    \ [0x03] Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $04 constant ADC4_CHSEL4                    \ [0x04] Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $05 constant ADC4_CHSEL5                    \ [0x05] Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $06 constant ADC4_CHSEL6                    \ [0x06] Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $07 constant ADC4_CHSEL7                    \ [0x07] Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $08 constant ADC4_CHSEL8                    \ [0x08] Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $09 constant ADC4_CHSEL9                    \ [0x09] Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $0a constant ADC4_CHSEL10                   \ [0x0a] Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $0b constant ADC4_CHSEL11                   \ [0x0b] Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $0c constant ADC4_CHSEL12                   \ [0x0c] Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $0d constant ADC4_CHSEL13                   \ [0x0d] Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC4_ADC_CHSELR_ALTERNATE_DEF
    \
    \ @brief ADC channel selection register [alternate]
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_SQ1                       \ [0x00 : 4] 1st conversion of the sequence These bits are programmed by software with the channel number assigned to the 1st conversion of the sequence. 0b1111 indicates end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. Refer to SQ8[3:0] for a definition of channel selection. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $04 constant ADC4_SQ2                       \ [0x04 : 4] 2nd conversion of the sequence These bits are programmed by software with the channel number assigned to the 2nd conversion of the sequence. 0b1111 indicates end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. Refer to SQ8[3:0] for a definition of channel selection. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $08 constant ADC4_SQ3                       \ [0x08 : 4] 3rd conversion of the sequence These bits are programmed by software with the channel number assigned to the 3rd conversion of the sequence. 0b1111 indicates end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. Refer to SQ8[3:0] for a definition of channel selection. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $0c constant ADC4_SQ4                       \ [0x0c : 4] 4th conversion of the sequence These bits are programmed by software with the channel number assigned to the 4th conversion of the sequence. 0b1111 indicates end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. Refer to SQ8[3:0] for a definition of channel selection. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1(which ensures that no conversion is ongoing).
    $10 constant ADC4_SQ5                       \ [0x10 : 4] 5th conversion of the sequence These bits are programmed by software with the channel number assigned to the 5th conversion of the sequence. 0b1111 indicates end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. Refer to SQ8[3:0] for a definition of channel selection. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $14 constant ADC4_SQ6                       \ [0x14 : 4] 6th conversion of the sequence These bits are programmed by software with the channel number assigned to the 6th conversion of the sequence. 0b1111 indicates end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. Refer to SQ8[3:0] for a definition of channel selection. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $18 constant ADC4_SQ7                       \ [0x18 : 4] 7th conversion of the sequence These bits are programmed by software with the channel number assigned to the 7th conversion of the sequence. 0b1111 indicates end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. Refer to SQ8[3:0] for a definition of channel selection. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $1c constant ADC4_SQ8                       \ [0x1c : 4] 8th conversion of the sequence These bits are programmed by software with the channel number assigned to the 8th conversion of the sequence. 0b1111 indicates the end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. ... Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC4_ADC_AWD3TR_DEF
    \
    \ @brief ADC watchdog threshold register
    \ Address offset: 0x2C
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC4_LT3                       \ [0x00 : 12] Analog watchdog 3lower threshold These bits are written by software to define the lower threshold for the analog watchdog. Refer to Section 20.4.25: Analog window watchdog on page 638.
    $10 constant ADC4_HT3                       \ [0x10 : 12] Analog watchdog 3 higher threshold These bits are written by software to define the higher threshold for the analog watchdog. Refer to Section 20.4.25: Analog window watchdog on page 638.
  [then]


  [ifdef] ADC4_ADC_DR_DEF
    \
    \ @brief ADC data register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_DATA                      \ [0x00 : 16] Converted data These bits are read-only. They contain the conversion result from the last converted channel. The data are left- or right-aligned as shown in Figure 78: Data alignment and resolution (oversampling disabled: OVSE = 0) on page 631. Just after a calibration is complete, DATA[6:0] contains the calibration factor.
  [then]


  [ifdef] ADC4_ADC_PWR_DEF
    \
    \ @brief ADC data register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_AUTOFF                    \ [0x00] Auto-off mode bit This bit is set and cleared by software. it is used to enable/disable the Auto-off mode. Note: The software is allowed to write this bit only when ADEN bit is cleared to 0 (this ensures that no conversion is ongoing).
    $01 constant ADC4_DPD                       \ [0x01] Deep-power-down mode bit This bit is set and cleared by software. It is used to enable/disable Deep-power-down mode in Autonomous mode when the ADC is not used. Note: The software is allowed to write this bit only when ADEN bit is cleared to 0 (this ensures that no conversion is ongoing). Note: Setting DPD in Auto-off mode automatically disables the LDO.
  [then]


  [ifdef] ADC4_ADC_AWD2CR_DEF
    \
    \ @brief ADC Analog Watchdog 2 Configuration register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_AWD2CH0                   \ [0x00] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $01 constant ADC4_AWD2CH1                   \ [0x01] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $02 constant ADC4_AWD2CH2                   \ [0x02] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $03 constant ADC4_AWD2CH3                   \ [0x03] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $04 constant ADC4_AWD2CH4                   \ [0x04] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $05 constant ADC4_AWD2CH5                   \ [0x05] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $06 constant ADC4_AWD2CH6                   \ [0x06] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $07 constant ADC4_AWD2CH7                   \ [0x07] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $08 constant ADC4_AWD2CH8                   \ [0x08] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $09 constant ADC4_AWD2CH9                   \ [0x09] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $0a constant ADC4_AWD2CH10                  \ [0x0a] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $0b constant ADC4_AWD2CH11                  \ [0x0b] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $0c constant ADC4_AWD2CH12                  \ [0x0c] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $0d constant ADC4_AWD2CH13                  \ [0x0d] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC4_ADC_AWD3CR_DEF
    \
    \ @brief ADC Analog Watchdog 3 Configuration register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_AWD3CH0                   \ [0x00] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $01 constant ADC4_AWD3CH1                   \ [0x01] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $02 constant ADC4_AWD3CH2                   \ [0x02] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $03 constant ADC4_AWD3CH3                   \ [0x03] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $04 constant ADC4_AWD3CH4                   \ [0x04] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $05 constant ADC4_AWD3CH5                   \ [0x05] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $06 constant ADC4_AWD3CH6                   \ [0x06] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $07 constant ADC4_AWD3CH7                   \ [0x07] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $08 constant ADC4_AWD3CH8                   \ [0x08] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $09 constant ADC4_AWD3CH9                   \ [0x09] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $0a constant ADC4_AWD3CH10                  \ [0x0a] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $0b constant ADC4_AWD3CH11                  \ [0x0b] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $0c constant ADC4_AWD3CH12                  \ [0x0c] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $0d constant ADC4_AWD3CH13                  \ [0x0d] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC4_ADC_CALFACT_DEF
    \
    \ @brief ADC Calibration factor
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_CALFACT                   \ [0x00 : 7] Calibration factor These bits are written by hardware or by software. Once a calibration is complete, they are updated by hardware with the calibration factors. Software can write these bits with a new calibration factor. If the new calibration factor is different from the current one stored into the analog ADC, it is then applied once a new calibration is launched. Just after a calibration is complete, DATA[6:0] contains the calibration factor. Note: Software can write these bits only when ADEN = 1 (ADC is enabled and no calibration is ongoing and no conversion is ongoing).
  [then]


  [ifdef] ADC4_ADC_CCR_DEF
    \
    \ @brief ADC common configuration register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $12 constant ADC4_PRESC                     \ [0x12 : 4] ADC prescaler Set and cleared by software to select the frequency of the clock to the ADC. Other: Reserved Note: Software is allowed to write these bits only when the ADC is disabled (ADCAL = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
    $16 constant ADC4_VREFEN                    \ [0x16] VsubREFINT/sub enable This bit is set and cleared by software to enable/disable the VsubREFINT/sub buffer. Note: Software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
    $17 constant ADC4_VSENSESEL                 \ [0x17] Temperature sensor selection This bit is set and cleared by software to enable/disable the temperature sensor. Note: Software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
  [then]

  \
  \ @brief ADC register block
  \
  $00 constant ADC4_ADC_ISR             \ ADC interrupt and status register
  $04 constant ADC4_ADC_IER             \ ADC interrupt enable register
  $08 constant ADC4_ADC_CR              \ ADC control register
  $0C constant ADC4_ADC_CFGR1           \ ADC configuration register 1
  $10 constant ADC4_ADC_CFGR2           \ ADC configuration register 2
  $14 constant ADC4_ADC_SMPR            \ ADC sampling time register
  $20 constant ADC4_ADC_AWD1TR          \ ADC watchdog threshold register
  $24 constant ADC4_ADC_AWD2TR          \ ADC watchdog threshold register
  $28 constant ADC4_ADC_CHSELR          \ ADC channel selection register [alternate]
  $28 constant ADC4_ADC_CHSELR_ALTERNATE    \ ADC channel selection register [alternate]
  $2C constant ADC4_ADC_AWD3TR          \ ADC watchdog threshold register
  $40 constant ADC4_ADC_DR              \ ADC data register
  $44 constant ADC4_ADC_PWR             \ ADC data register
  $A0 constant ADC4_ADC_AWD2CR          \ ADC Analog Watchdog 2 Configuration register
  $A4 constant ADC4_ADC_AWD3CR          \ ADC Analog Watchdog 3 Configuration register
  $C4 constant ADC4_ADC_CALFACT         \ ADC Calibration factor
  $308 constant ADC4_ADC_CCR            \ ADC common configuration register

: ADC4_DEF ; [then]
