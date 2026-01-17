\
\ @file adc.fs
\ @brief ADC address block description
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
    $00 constant ADC_ADRDY                      \ [0x00] ADC ready This bit is set by hardware after the ADC has been enabled (ADEN = 1) and when the ADC reaches a state where it is ready to accept conversion requests. It is cleared by software writing 1 to it.
    $01 constant ADC_EOSMP                      \ [0x01] End of sampling flag This bit is set by hardware during the conversion, at the end of the sampling phase.It is cleared by software by programming it to '1'.
    $02 constant ADC_EOC                        \ [0x02] End of conversion flag This bit is set by hardware at the end of each conversion of a channel when a new data result is available in the ADC_DR register. It is cleared by software writing 1 to it or by reading the ADC_DR register.
    $03 constant ADC_EOS                        \ [0x03] End of sequence flag This bit is set by hardware at the end of the conversion of a sequence of channels selected by the CHSEL bits. It is cleared by software writing 1 to it.
    $04 constant ADC_OVR                        \ [0x04] ADC overrun This bit is set by hardware when an overrun occurs, meaning that a new conversion has complete while the EOC flag was already set. It is cleared by software writing 1 to it.
    $07 constant ADC_AWD1                       \ [0x07] Analog watchdog 1 flag This bit is set by hardware when the converted voltage crosses the values programmed in ADC_TR1 and ADC_HR1 registers. It is cleared by software by programming it to 1.
    $08 constant ADC_AWD2                       \ [0x08] Analog watchdog 2 flag This bit is set by hardware when the converted voltage crosses the values programmed in ADC_AWD2TR and ADC_AWD2TR registers. It is cleared by software programming it it.
    $09 constant ADC_AWD3                       \ [0x09] Analog watchdog 3 flag This bit is set by hardware when the converted voltage crosses the values programmed in ADC_AWD3TR and ADC_AWD3TR registers. It is cleared by software by programming it to 1.
    $0b constant ADC_EOCAL                      \ [0x0b] End Of Calibration flag This bit is set by hardware when calibration is complete. It is cleared by software writing 1 to it.
    $0d constant ADC_CCRDY                      \ [0x0d] Channel Configuration Ready flag This flag bit is set by hardware when the channel configuration is applied after programming to ADC_CHSELR register or changing CHSELRMOD or SCANDIR. It is cleared by software by programming it to it. Note: When the software configures the channels (by programming ADC_CHSELR or changing CHSELRMOD or SCANDIR), it must wait until the CCRDY flag rises before configuring again or starting conversions, otherwise the new configuration (or the START bit) is ignored. Once the flag is asserted, if the software needs to configure again the channels, it must clear the CCRDY flag before proceeding with a new configuration.
  [then]


  [ifdef] ADC_ADC_IER_DEF
    \
    \ @brief ADC interrupt enable register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ADRDYIE                    \ [0x00] ADC ready interrupt enable This bit is set and cleared by software to enable/disable the ADC Ready interrupt. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $01 constant ADC_EOSMPIE                    \ [0x01] End of sampling flag interrupt enable This bit is set and cleared by software to enable/disable the end of the sampling phase interrupt. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $02 constant ADC_EOCIE                      \ [0x02] End of conversion interrupt enable This bit is set and cleared by software to enable/disable the end of conversion interrupt. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $03 constant ADC_EOSIE                      \ [0x03] End of conversion sequence interrupt enable This bit is set and cleared by software to enable/disable the end of sequence of conversions interrupt. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $04 constant ADC_OVRIE                      \ [0x04] Overrun interrupt enable This bit is set and cleared by software to enable/disable the overrun interrupt. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $07 constant ADC_AWD1IE                     \ [0x07] Analog watchdog 1 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog interrupt. Note: The Software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $08 constant ADC_AWD2IE                     \ [0x08] Analog watchdog 2 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog interrupt. Note: The Software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $09 constant ADC_AWD3IE                     \ [0x09] Analog watchdog 3 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog interrupt. Note: The Software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $0b constant ADC_EOCALIE                    \ [0x0b] End of calibration interrupt enable This bit is set and cleared by software to enable/disable the end of calibration interrupt. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $0d constant ADC_CCRDYIE                    \ [0x0d] Channel Configuration Ready Interrupt enable This bit is set and cleared by software to enable/disable the channel configuration ready interrupt. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_CR_DEF
    \
    \ @brief ADC control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ADEN                       \ [0x00] ADC enable command This bit is set by software to enable the ADC. The ADC is effectively ready to operate once the ADRDY flag has been set. It is cleared by hardware when the ADC is disabled, after the execution of the ADDIS command. Note: The software is allowed to set ADEN only when all bits of ADC_CR registers are 0 (ADCAL = 0, ADSTP=0, ADSTART=0, ADDIS=0 and ADEN=0)
    $01 constant ADC_ADDIS                      \ [0x01] ADC disable command This bit is set by software to disable the ADC (ADDIS command) and put it into power-down state (OFF state). It is cleared by hardware once the ADC is effectively disabled (ADEN is also cleared by hardware at this time). Note: Setting ADDIS to '1' is only effective when ADEN = 1 and ADSTART = 0 (which ensures that no conversion is ongoing)
    $02 constant ADC_ADSTART                    \ [0x02] ADC start conversion command This bit is set by software to start ADC conversion. Depending on the EXTEN [1:0] configuration bits, a conversion either starts immediately (software trigger configuration) or once a hardware trigger event occurs (hardware trigger configuration). It is cleared by hardware: In single conversion mode (CONT = 0, DISCEN = 0), when software trigger is selected (EXTEN = 00): at the assertion of the end of Conversion Sequence (EOS) flag. In discontinuous conversion mode(CONT = 0, DISCEN = 1), when the software trigger is selected (EXTEN = 00): at the assertion of the end of Conversion (EOC) flag. In all other cases: after the execution of the ADSTP command, at the same time as the ADSTP bit is cleared by hardware. Note: The software is allowed to set ADSTART only when ADEN = 1 and ADDIS = 0 (ADC is enabled and there is no pending request to disable the ADC). After writing to ADC_CHSELR register or changing CHSELRMOD or SCANDIRW, it is mandatory to wait until CCRDY flag is asserted before setting ADSTART, otherwise, the value written to ADSTART is ignored.
    $04 constant ADC_ADSTP                      \ [0x04] ADC stop conversion command This bit is set by software to stop and discard an ongoing conversion (ADSTP Command). It is cleared by hardware when the conversion is effectively discarded and the ADC is ready to accept a new start conversion command. Note: Setting ADSTP to '1' is only effective when ADSTART = 1 and ADDIS = 0 (ADC is enabled and may be converting and there is no pending request to disable the ADC)
    $1c constant ADC_ADVREGEN                   \ [0x1c] ADC Voltage Regulator Enable This bit is set by software, to enable the ADC internal voltage regulator. The voltage regulator output is available after tADCVREG_SETUP. It is cleared by software to disable the voltage regulator. It can be cleared only if ADEN is et to 0. Note: The software is allowed to program this bit field only when the ADC is disabled (ADCAL = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
    $1f constant ADC_ADCAL                      \ [0x1f] ADC calibration This bit is set by software to start the calibration of the ADC. It is cleared by hardware after calibration is complete. Note: The software is allowed to set ADCAL only when the ADC is disabled (ADCAL=0, ADSTART=0, ADSTP=0, ADDIS=0 and ADEN=0). The software is allowed to update the calibration factor by writing ADC_CALFACT only when ADEN=1 and ADSTART=0 (ADC enabled and no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_CFGR1_DEF
    \
    \ @brief ADC configuration register 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_DMAEN                      \ [0x00] Direct memory access enable This bit is set and cleared by software to enable the generation of DMA requests. This allows the DMA controller to be used to manage automatically the converted data. For more details, refer to . Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $01 constant ADC_DMACFG                     \ [0x01] Direct memory access configuration This bit is set and cleared by software to select between two DMA modes of operation and is effective only when DMAEN=1. For more details, refer to page391 Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $02 constant ADC_SCANDIR                    \ [0x02] Scan sequence direction This bit is set and cleared by software to select the direction in which the channels is scanned in the sequence. It is effective only if CHSELMOD bit is cleared to 0. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing). If CCRDY is not yet asserted after channel configuration (writing ADC_CHSELR register or changing CHSELRMOD or SCANDIR), the value written to this bit is ignored.
    $03 constant ADC_RES                        \ [0x03 : 2] Data resolution These bits are written by software to select the resolution of the conversion. Note: The software is allowed to write these bits only when ADEN=0.
    $05 constant ADC_ALIGN                      \ [0x05] Data alignment This bit is set and cleared by software to select right or left alignment. Refer to Data alignment and resolution (oversampling disabled: OVSE = 0) on page389 Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $06 constant ADC_EXTSEL                     \ [0x06 : 3] External trigger selection These bits select the external event used to trigger the start of conversion (refer to External triggers for details): Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $0a constant ADC_EXTEN                      \ [0x0a : 2] External trigger enable and polarity selection These bits are set and cleared by software to select the external trigger polarity and enable the trigger. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $0c constant ADC_OVRMOD                     \ [0x0c] Overrun management mode This bit is set and cleared by software and configure the way data overruns are managed. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $0d constant ADC_CONT                       \ [0x0d] Single / continuous conversion mode This bit is set and cleared by software. If it is set, conversion takes place continuously until it is cleared. Note: It is not possible to have both discontinuous mode and continuous mode enabled: it is forbidden to set both bits DISCEN=1 and CONT=1. The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $0e constant ADC_WAIT                       \ [0x0e] Wait conversion mode This bit is set and cleared by software to enable/disable wait conversion mode.. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $0f constant ADC_AUTOFF                     \ [0x0f] Auto-off mode This bit is set and cleared by software to enable/disable auto-off mode.. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $10 constant ADC_DISCEN                     \ [0x10] Discontinuous mode This bit is set and cleared by software to enable/disable discontinuous mode. Note: It is not possible to have both discontinuous mode and continuous mode enabled: it is forbidden to set both bits DISCEN=1 and CONT=1. The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $15 constant ADC_CHSELRMOD                  \ [0x15] Mode selection of the ADC_CHSELR register This bit is set and cleared by software to control the ADC_CHSELR feature: Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing). If CCRDY is not yet asserted after channel configuration (writing ADC_CHSELR register or changing CHSELRMOD or SCANDIR), the value written to this bit is ignored.
    $16 constant ADC_AWD1SGL                    \ [0x16] Enable the watchdog on a single channel or on all channels This bit is set and cleared by software to enable the analog watchdog on the channel identified by the AWDCH[4:0] bits or on all the channels Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $17 constant ADC_AWD1EN                     \ [0x17] Analog watchdog enable This bit is set and cleared by software. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $1a constant ADC_AWD1CH                     \ [0x1a : 5] Analog watchdog channel selection These bits are set and cleared by software. They select the input channel to be guarded by the analog watchdog. ..... Others: Reserved Note: The channel selected by the AWDCH[4:0] bits must be also set into the CHSELR register. The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_CFGR2_DEF
    \
    \ @brief ADC configuration register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OVSE                       \ [0x00] Oversampler Enable This bit is set and cleared by software. Note: Software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $02 constant ADC_OVSR                       \ [0x02 : 3] Oversampling ratio This bit filed defines the number of oversampling ratio. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $05 constant ADC_OVSS                       \ [0x05 : 4] Oversampling shift This bit is set and cleared by software. Others: Reserved Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $09 constant ADC_TOVS                       \ [0x09] Triggered Oversampling This bit is set and cleared by software. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $1d constant ADC_LFTRIG                     \ [0x1d] Low frequency trigger mode enable This bit is set and cleared by software. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 (this ensures that no conversion is ongoing).
    $1e constant ADC_CKMODE                     \ [0x1e : 2] ADC clock mode These bits are set and cleared by software to define how the analog ADC is clocked: In all synchronous clock modes, there is no jitter in the delay from a timer trigger to the start of a conversion. Note: The software is allowed to write these bits only when the ADC is disabled (ADCAL=0, ADSTART=0, ADSTP=0, ADDIS=0 and ADEN=0).
  [then]


  [ifdef] ADC_ADC_SMPR_DEF
    \
    \ @brief ADC sampling time register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SMP1                       \ [0x00 : 3] Sampling time selection 1 These bits are written by software to select the sampling time that applies to all channels. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $04 constant ADC_SMP2                       \ [0x04 : 3] Sampling time selection 2 These bits are written by software to select the sampling time that applies to all channels. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $08 constant ADC_SMPSEL0                    \ [0x08] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $09 constant ADC_SMPSEL1                    \ [0x09] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $0a constant ADC_SMPSEL2                    \ [0x0a] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $0b constant ADC_SMPSEL3                    \ [0x0b] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $0c constant ADC_SMPSEL4                    \ [0x0c] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $0d constant ADC_SMPSEL5                    \ [0x0d] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $0e constant ADC_SMPSEL6                    \ [0x0e] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $0f constant ADC_SMPSEL7                    \ [0x0f] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $10 constant ADC_SMPSEL8                    \ [0x10] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $11 constant ADC_SMPSEL9                    \ [0x11] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $12 constant ADC_SMPSEL10                   \ [0x12] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $13 constant ADC_SMPSEL11                   \ [0x13] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $14 constant ADC_SMPSEL12                   \ [0x14] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $15 constant ADC_SMPSEL13                   \ [0x15] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $16 constant ADC_SMPSEL14                   \ [0x16] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $17 constant ADC_SMPSEL15                   \ [0x17] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $18 constant ADC_SMPSEL16                   \ [0x18] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $19 constant ADC_SMPSEL17                   \ [0x19] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $1a constant ADC_SMPSEL18                   \ [0x1a] Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_AWD1TR_DEF
    \
    \ @brief ADC watchdog threshold register
    \ Address offset: 0x20
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC_LT1                        \ [0x00 : 12] Analog watchdog 1 lower threshold These bits are written by software to define the lower threshold for the analog watchdog. Refer to ADC_AWDxTR) on page395.
    $10 constant ADC_HT1                        \ [0x10 : 12] Analog watchdog 1 higher threshold These bits are written by software to define the higher threshold for the analog watchdog. Refer to ADC_AWDxTR) on page395.
  [then]


  [ifdef] ADC_ADC_AWD2TR_DEF
    \
    \ @brief ADC watchdog threshold register
    \ Address offset: 0x24
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC_LT2                        \ [0x00 : 12] Analog watchdog 2 lower threshold These bits are written by software to define the lower threshold for the analog watchdog. Refer to ADC_AWDxTR) on page395.
    $10 constant ADC_HT2                        \ [0x10 : 12] Analog watchdog 2 higher threshold These bits are written by software to define the higher threshold for the analog watchdog. Refer to ADC_AWDxTR) on page395.
  [then]


  [ifdef] ADC_ADC_CHSELRMOD0_DEF
    \
    \ @brief ADC channel selection register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant ADC_CHSEL0                     \ [0x00] Channel-x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing). If CCRDY is not yet asserted after channel configuration (writing ADC_CHSELR register or changing CHSELRMOD or SCANDIR), the value written to this bit is ignored.
    $01 constant ADC_CHSEL1                     \ [0x01] Channel-x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing). If CCRDY is not yet asserted after channel configuration (writing ADC_CHSELR register or changing CHSELRMOD or SCANDIR), the value written to this bit is ignored.
    $02 constant ADC_CHSEL2                     \ [0x02] Channel-x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing). If CCRDY is not yet asserted after channel configuration (writing ADC_CHSELR register or changing CHSELRMOD or SCANDIR), the value written to this bit is ignored.
    $03 constant ADC_CHSEL3                     \ [0x03] Channel-x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing). If CCRDY is not yet asserted after channel configuration (writing ADC_CHSELR register or changing CHSELRMOD or SCANDIR), the value written to this bit is ignored.
    $04 constant ADC_CHSEL4                     \ [0x04] Channel-x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing). If CCRDY is not yet asserted after channel configuration (writing ADC_CHSELR register or changing CHSELRMOD or SCANDIR), the value written to this bit is ignored.
    $05 constant ADC_CHSEL5                     \ [0x05] Channel-x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing). If CCRDY is not yet asserted after channel configuration (writing ADC_CHSELR register or changing CHSELRMOD or SCANDIR), the value written to this bit is ignored.
    $06 constant ADC_CHSEL6                     \ [0x06] Channel-x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing). If CCRDY is not yet asserted after channel configuration (writing ADC_CHSELR register or changing CHSELRMOD or SCANDIR), the value written to this bit is ignored.
    $07 constant ADC_CHSEL7                     \ [0x07] Channel-x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing). If CCRDY is not yet asserted after channel configuration (writing ADC_CHSELR register or changing CHSELRMOD or SCANDIR), the value written to this bit is ignored.
    $08 constant ADC_CHSEL8                     \ [0x08] Channel-x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing). If CCRDY is not yet asserted after channel configuration (writing ADC_CHSELR register or changing CHSELRMOD or SCANDIR), the value written to this bit is ignored.
    $09 constant ADC_CHSEL9                     \ [0x09] Channel-x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing). If CCRDY is not yet asserted after channel configuration (writing ADC_CHSELR register or changing CHSELRMOD or SCANDIR), the value written to this bit is ignored.
    $0a constant ADC_CHSEL10                    \ [0x0a] Channel-x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing). If CCRDY is not yet asserted after channel configuration (writing ADC_CHSELR register or changing CHSELRMOD or SCANDIR), the value written to this bit is ignored.
    $0b constant ADC_CHSEL11                    \ [0x0b] Channel-x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing). If CCRDY is not yet asserted after channel configuration (writing ADC_CHSELR register or changing CHSELRMOD or SCANDIR), the value written to this bit is ignored.
    $0c constant ADC_CHSEL12                    \ [0x0c] Channel-x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing). If CCRDY is not yet asserted after channel configuration (writing ADC_CHSELR register or changing CHSELRMOD or SCANDIR), the value written to this bit is ignored.
    $0d constant ADC_CHSEL13                    \ [0x0d] Channel-x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing). If CCRDY is not yet asserted after channel configuration (writing ADC_CHSELR register or changing CHSELRMOD or SCANDIR), the value written to this bit is ignored.
    $0e constant ADC_CHSEL14                    \ [0x0e] Channel-x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing). If CCRDY is not yet asserted after channel configuration (writing ADC_CHSELR register or changing CHSELRMOD or SCANDIR), the value written to this bit is ignored.
    $0f constant ADC_CHSEL15                    \ [0x0f] Channel-x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing). If CCRDY is not yet asserted after channel configuration (writing ADC_CHSELR register or changing CHSELRMOD or SCANDIR), the value written to this bit is ignored.
    $10 constant ADC_CHSEL16                    \ [0x10] Channel-x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing). If CCRDY is not yet asserted after channel configuration (writing ADC_CHSELR register or changing CHSELRMOD or SCANDIR), the value written to this bit is ignored.
    $11 constant ADC_CHSEL17                    \ [0x11] Channel-x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing). If CCRDY is not yet asserted after channel configuration (writing ADC_CHSELR register or changing CHSELRMOD or SCANDIR), the value written to this bit is ignored.
    $12 constant ADC_CHSEL18                    \ [0x12] Channel-x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing). If CCRDY is not yet asserted after channel configuration (writing ADC_CHSELR register or changing CHSELRMOD or SCANDIR), the value written to this bit is ignored.
  [then]


  [ifdef] ADC_ADC_CHSELRMOD1_DEF
    \
    \ @brief ADC channel selection register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ1                        \ [0x00 : 4] 1st conversion of the sequence These bits are programmed by software with the channel number (0...14) assigned to the 8th conversion of the sequence. 0b1111 indicates end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. Refer to SQ8[3:0] for a definition of channel selection. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $04 constant ADC_SQ2                        \ [0x04 : 4] 2nd conversion of the sequence These bits are programmed by software with the channel number (0...14) assigned to the 8th conversion of the sequence. 0b1111 indicates end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. Refer to SQ8[3:0] for a definition of channel selection. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $08 constant ADC_SQ3                        \ [0x08 : 4] 3rd conversion of the sequence These bits are programmed by software with the channel number (0...14) assigned to the 8th conversion of the sequence. 0b1111 indicates end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. Refer to SQ8[3:0] for a definition of channel selection. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $0c constant ADC_SQ4                        \ [0x0c : 4] 4th conversion of the sequence These bits are programmed by software with the channel number (0...14) assigned to the 8th conversion of the sequence. 0b1111 indicates end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. Refer to SQ8[3:0] for a definition of channel selection. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $10 constant ADC_SQ5                        \ [0x10 : 4] 5th conversion of the sequence These bits are programmed by software with the channel number (0...14) assigned to the 8th conversion of the sequence. 0b1111 indicates end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. Refer to SQ8[3:0] for a definition of channel selection. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $14 constant ADC_SQ6                        \ [0x14 : 4] 6th conversion of the sequence These bits are programmed by software with the channel number (0...14) assigned to the 8th conversion of the sequence. 0b1111 indicates end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. Refer to SQ8[3:0] for a definition of channel selection. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $18 constant ADC_SQ7                        \ [0x18 : 4] 7th conversion of the sequence These bits are programmed by software with the channel number (0...14) assigned to the 8th conversion of the sequence. 0b1111 indicates end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. Refer to SQ8[3:0] for a definition of channel selection. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $1c constant ADC_SQ8                        \ [0x1c : 4] 8th conversion of the sequence These bits are programmed by software with the channel number (0...14) assigned to the 8th conversion of the sequence. 0b1111 indicates the end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. ... Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_AWD3TR_DEF
    \
    \ @brief ADC watchdog threshold register
    \ Address offset: 0x2C
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC_LT3                        \ [0x00 : 12] Analog watchdog 3lower threshold These bits are written by software to define the lower threshold for the analog watchdog. Refer to ADC_AWDxTR) on page395.
    $10 constant ADC_HT3                        \ [0x10 : 12] Analog watchdog 3 higher threshold These bits are written by software to define the higher threshold for the analog watchdog. Refer to ADC_AWDxTR) on page395.
  [then]


  [ifdef] ADC_ADC_DR_DEF
    \
    \ @brief ADC data register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant ADC_DATA                       \ [0x00 : 16] Converted data These bits are read-only. They contain the conversion result from the last converted channel. The data are left- or right-aligned as shown in OVSE = 0) on page389. Just after a calibration is complete, DATA[6:0] contains the calibration factor.
  [then]


  [ifdef] ADC_ADC_AWD2CR_DEF
    \
    \ @brief ADC Analog Watchdog 2 Configuration register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant ADC_AWD2CH0                    \ [0x00] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $01 constant ADC_AWD2CH1                    \ [0x01] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $02 constant ADC_AWD2CH2                    \ [0x02] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $03 constant ADC_AWD2CH3                    \ [0x03] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $04 constant ADC_AWD2CH4                    \ [0x04] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $05 constant ADC_AWD2CH5                    \ [0x05] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $06 constant ADC_AWD2CH6                    \ [0x06] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $07 constant ADC_AWD2CH7                    \ [0x07] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $08 constant ADC_AWD2CH8                    \ [0x08] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $09 constant ADC_AWD2CH9                    \ [0x09] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $0a constant ADC_AWD2CH10                   \ [0x0a] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $0b constant ADC_AWD2CH11                   \ [0x0b] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $0c constant ADC_AWD2CH12                   \ [0x0c] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $0d constant ADC_AWD2CH13                   \ [0x0d] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $0e constant ADC_AWD2CH14                   \ [0x0e] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $0f constant ADC_AWD2CH15                   \ [0x0f] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $10 constant ADC_AWD2CH16                   \ [0x10] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $11 constant ADC_AWD2CH17                   \ [0x11] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $12 constant ADC_AWD2CH18                   \ [0x12] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_AWD3CR_DEF
    \
    \ @brief ADC Analog Watchdog 3 Configuration register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant ADC_AWD3CH0                    \ [0x00] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $01 constant ADC_AWD3CH1                    \ [0x01] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $02 constant ADC_AWD3CH2                    \ [0x02] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $03 constant ADC_AWD3CH3                    \ [0x03] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $04 constant ADC_AWD3CH4                    \ [0x04] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $05 constant ADC_AWD3CH5                    \ [0x05] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $06 constant ADC_AWD3CH6                    \ [0x06] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $07 constant ADC_AWD3CH7                    \ [0x07] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $08 constant ADC_AWD3CH8                    \ [0x08] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $09 constant ADC_AWD3CH9                    \ [0x09] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $0a constant ADC_AWD3CH10                   \ [0x0a] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $0b constant ADC_AWD3CH11                   \ [0x0b] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $0c constant ADC_AWD3CH12                   \ [0x0c] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $0d constant ADC_AWD3CH13                   \ [0x0d] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $0e constant ADC_AWD3CH14                   \ [0x0e] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $0f constant ADC_AWD3CH15                   \ [0x0f] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $10 constant ADC_AWD3CH16                   \ [0x10] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $11 constant ADC_AWD3CH17                   \ [0x11] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $12 constant ADC_AWD3CH18                   \ [0x12] Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
  [then]


  [ifdef] ADC_ADC_CALFACT_DEF
    \
    \ @brief ADC Calibration factor
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant ADC_CALFACT                    \ [0x00 : 7] Calibration factor These bits are written by hardware or by software. Once a calibration is complete,they are updated by hardware with the calibration factors. Software can write these bits with a new calibration factor. If the new calibration factor is different from the current one stored into the analog ADC, it is then applied once a new calibration is launched. Just after a calibration is complete, DATA[6:0] contains the calibration factor. Note: Software can write these bits only when ADEN=1 (ADC is enabled and no calibration is ongoing and no conversion is ongoing). Refer to SQ8[3:0] for a definition of channel selection.
  [then]


  [ifdef] ADC_ADC_CCR_DEF
    \
    \ @brief ADC common configuration register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $12 constant ADC_PRESC                      \ [0x12 : 4] ADC prescaler Set and cleared by software to select the frequency of the clock to the ADC. Other: Reserved Note: Software is allowed to write these bits only when the ADC is disabled (ADCAL=0, ADSTART=0, ADSTP=0, ADDIS=0 and ADEN=0).
    $16 constant ADC_VREFEN                     \ [0x16] VREFINT enable This bit is set and cleared by software to enable/disable the VREFINT. Note: Software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $17 constant ADC_TSEN                       \ [0x17] Temperature sensor enable This bit is set and cleared by software to enable/disable the temperature sensor. Note: Software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing).
    $18 constant ADC_VBATEN                     \ [0x18] VBAT enable This bit is set and cleared by software to enable/disable the VBAT channel. Note: The software is allowed to write this bit only when ADSTART=0 (which ensures that no conversion is ongoing)
  [then]

  \
  \ @brief ADC address block description
  \
  $00 constant ADC_ADC_ISR              \ ADC interrupt and status register
  $04 constant ADC_ADC_IER              \ ADC interrupt enable register
  $08 constant ADC_ADC_CR               \ ADC control register
  $0C constant ADC_ADC_CFGR1            \ ADC configuration register 1
  $10 constant ADC_ADC_CFGR2            \ ADC configuration register 2
  $14 constant ADC_ADC_SMPR             \ ADC sampling time register
  $20 constant ADC_ADC_AWD1TR           \ ADC watchdog threshold register
  $24 constant ADC_ADC_AWD2TR           \ ADC watchdog threshold register
  $28 constant ADC_ADC_CHSELRMOD0       \ ADC channel selection register
  $28 constant ADC_ADC_CHSELRMOD1       \ ADC channel selection register
  $2C constant ADC_ADC_AWD3TR           \ ADC watchdog threshold register
  $40 constant ADC_ADC_DR               \ ADC data register
  $A0 constant ADC_ADC_AWD2CR           \ ADC Analog Watchdog 2 Configuration register
  $A4 constant ADC_ADC_AWD3CR           \ ADC Analog Watchdog 3 Configuration register
  $B4 constant ADC_ADC_CALFACT          \ ADC Calibration factor
  $308 constant ADC_ADC_CCR             \ ADC common configuration register

: ADC_DEF ; [then]
