\
\ @file sec_adc4.fs
\ @brief ADC register block
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

$00000001 constant SEC_ADC4_ADC_ISR_ADRDY                           \ ADC ready This bit is set by hardware after the ADC has been enabled (ADEN = 1) and when the ADC reaches a state where it is ready to accept conversion requests. It is cleared by software writing 1 to it.
$00000002 constant SEC_ADC4_ADC_ISR_EOSMP                           \ End of sampling flag This bit is set by hardware during the conversion, at the end of the sampling phase.It is cleared by software by writing 1 to it.
$00000004 constant SEC_ADC4_ADC_ISR_EOC                             \ End of conversion flag This bit is set by hardware at the end of each conversion of a channel when a new data result is available in the ADC_DR register. It is cleared by software writing 1 to it or by reading the ADC_DR register.
$00000008 constant SEC_ADC4_ADC_ISR_EOS                             \ End of sequence flag This bit is set by hardware at the end of the conversion of a sequence of channels selected by the CHSEL bits. It is cleared by software writing 1 to it.
$00000010 constant SEC_ADC4_ADC_ISR_OVR                             \ ADC overrun This bit is set by hardware when an overrun occurs, meaning that a new conversion has complete while the EOC flag was already set. It is cleared by software writing 1 to it.
$00000080 constant SEC_ADC4_ADC_ISR_AWD1                            \ Analog watchdog 1 flag This bit is set by hardware when the converted voltage crosses the values programmed in ADC_TR1 and ADC_HR1 registers. It is cleared by software by writing 1 to it.
$00000100 constant SEC_ADC4_ADC_ISR_AWD2                            \ Analog watchdog 2 flag This bit is set by hardware when the converted voltage crosses the values programmed in ADC_AWD2TR and ADC_AWD2TR registers. It is cleared by software writing 1 to it.
$00000200 constant SEC_ADC4_ADC_ISR_AWD3                            \ Analog watchdog 3 flag This bit is set by hardware when the converted voltage crosses the values programmed in ADC_AWD3TR and ADC_AWD3TR registers. It is cleared by software by writing 1 to it.
$00000800 constant SEC_ADC4_ADC_ISR_EOCAL                           \ End of calibration flag This bit is set by hardware when calibration is complete. It is cleared by software writing 1 to it.
$00001000 constant SEC_ADC4_ADC_ISR_LDORDY                          \ LDO ready This bit is set by hardware. It indicates that the ADC internal LDO output is ready. It is cleared by software by writing 1 to it.


\
\ @brief ADC interrupt enable register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_ADC4_ADC_IER_ADRDYIE                         \ ADC ready interrupt enable This bit is set and cleared by software to enable/disable the ADC Ready interrupt. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$00000002 constant SEC_ADC4_ADC_IER_EOSMPIE                         \ End of sampling flag interrupt enable This bit is set and cleared by software to enable/disable the end of the sampling phase interrupt. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$00000004 constant SEC_ADC4_ADC_IER_EOCIE                           \ End of conversion interrupt enable This bit is set and cleared by software to enable/disable the end of conversion interrupt. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$00000008 constant SEC_ADC4_ADC_IER_EOSIE                           \ End of conversion sequence interrupt enable This bit is set and cleared by software to enable/disable the end of sequence of conversions interrupt. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$00000010 constant SEC_ADC4_ADC_IER_OVRIE                           \ Overrun interrupt enable This bit is set and cleared by software to enable/disable the overrun interrupt. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$00000080 constant SEC_ADC4_ADC_IER_AWD1IE                          \ Analog watchdog 1 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog interrupt. Note: The Software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$00000100 constant SEC_ADC4_ADC_IER_AWD2IE                          \ Analog watchdog 2 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog interrupt. Note: The Software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$00000200 constant SEC_ADC4_ADC_IER_AWD3IE                          \ Analog watchdog 3 interrupt enable This bit is set and cleared by software to enable/disable the analog watchdog interrupt. Note: The Software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$00000800 constant SEC_ADC4_ADC_IER_EOCALIE                         \ End of calibration interrupt enable This bit is set and cleared by software to enable/disable the end of calibration interrupt. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$00001000 constant SEC_ADC4_ADC_IER_LDORDYIE                        \ LDO ready interrupt enable This bit is set and cleared by software. It is used to enable/disable the LDORDY interrupt. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensure that no conversion is ongoing).


\
\ @brief ADC control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_ADC4_ADC_CR_ADEN                             \ ADC enable command This bit is set by software to enable the ADC. The ADC is effectively ready to operate once the ADRDY flag has been set. It is cleared by hardware when the ADC is disabled, after the execution of the ADDIS command. Note: The software is allowed to set ADEN only when all bits of ADC_CR registers are 0 (ADCAL = 0, ADSTP = 0, ADSTART = 0, ADDIS = 0 and ADEN = 0)
$00000002 constant SEC_ADC4_ADC_CR_ADDIS                            \ ADC disable command This bit is set by software to disable the ADC (ADDIS command) and put it into power-down state (OFF state). It is cleared by hardware once the ADC is effectively disabled (ADEN is also cleared by hardware at this time). Note: Setting ADDIS to 1 is only effective when ADEN = 1 and ADSTART = 0 (which ensures that no conversion is ongoing)
$00000004 constant SEC_ADC4_ADC_CR_ADSTART                          \ ADC start conversion command This bit is set by software to start ADC conversion. Depending on the EXTEN [1:0] configuration bits, a conversion either starts immediately (software trigger configuration) or once a hardware trigger event occurs (hardware trigger configuration). It is cleared by hardware: In single conversion mode (CONT = 0, DISCEN = 0), when software trigger is selected (EXTEN = 00): at the assertion of the end of Conversion Sequence (EOS) flag. In discontinuous conversion mode(CONT=0, DISCEN = 1), when the software trigger is selected (EXTEN = 00): at the assertion of the end of Conversion (EOC) flag. In all other cases: after the execution of the ADSTP command, at the same time as the ADSTP bit is cleared by hardware. Note: The software is allowed to set ADSTART only when ADEN = 1 and ADDIS = 0 (ADC is enabled and there is no pending request to disable the ADC).
$00000010 constant SEC_ADC4_ADC_CR_ADSTP                            \ ADC stop conversion command This bit is set by software to stop and discard an ongoing conversion (ADSTP Command). It is cleared by hardware when the conversion is effectively discarded and the ADC is ready to accept a new start conversion command. Note: To clear the A/D converter state, ADSTP must be set to 1 even if ADSTART is cleared to 0 after the software trigger A/D conversion. It is recommended to set ADSTP to 1 whenever the configuration needs to be modified.
$10000000 constant SEC_ADC4_ADC_CR_ADVREGEN                         \ ADC voltage regulator enable This bit is set by software, to enable the ADC internal voltage regulator. The voltage regulator output is available after tsubADCVREG_SETUP/sub. It is cleared by software to disable the voltage regulator. It can be cleared only if ADEN is et to 0. Note: The software is allowed to program this bit field only when the ADC is disabled (ADCAL = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
$80000000 constant SEC_ADC4_ADC_CR_ADCAL                            \ ADC calibration This bit is set by software to start the calibration of the ADC. It is cleared by hardware after calibration is complete. Note: The software is allowed to set ADCAL only when the ADC is disabled (ADCAL = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0, AUTOFF = 0, and ADEN = 0). Note: The software is allowed to update the calibration factor by writing ADC_CALFACT only when ADEN is set to 1 and ADSTART is cleared to 0 by writing ADSTP to 1 (ADC enabled and no conversion is ongoing).


\
\ @brief ADC configuration register 1
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SEC_ADC4_ADC_CFGR1_DMAEN                         \ Direct memory access enable This bit is set and cleared by software to enable the generation of DMA requests. This allows the automatic management of the converted data by the DMA controller. For more details, refer to Section : Managing converted data using the DMA on page 632. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$00000002 constant SEC_ADC4_ADC_CFGR1_DMACFG                        \ Direct memory access configuration This bit is set and cleared by software to select between two DMA modes of operation and is effective only when DMAEN = 1. For more details, refer to Section : Managing converted data using the DMA on page 632 Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$0000000c constant SEC_ADC4_ADC_CFGR1_RES                           \ Data resolution These bits are written by software to select the resolution of the conversion. Note: The software is allowed to write these bits only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$00000010 constant SEC_ADC4_ADC_CFGR1_SCANDIR                       \ Scan sequence direction This bit is set and cleared by software to select the direction in which the channels is scanned in the sequence. It is effective only if CHSELRMOD bit is cleared to 0. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$00000020 constant SEC_ADC4_ADC_CFGR1_ALIGN                         \ Data alignment This bit is set and cleared by software to select right or left alignment. Refer to Figure 78: Data alignment and resolution (oversampling disabled: OVSE = 0) on page 631 Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$000001c0 constant SEC_ADC4_ADC_CFGR1_EXTSEL                        \ External trigger selection These bits select the external event used to trigger the start of conversion (refer to table ADC interconnection in Section 20.4.2: ADC pins and internal signals for details): Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$00000c00 constant SEC_ADC4_ADC_CFGR1_EXTEN                         \ External trigger enable and polarity selection These bits are set and cleared by software to select the external trigger polarity and enable the trigger. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$00001000 constant SEC_ADC4_ADC_CFGR1_OVRMOD                        \ Overrun management mode This bit is set and cleared by software and configure the way data overruns are managed. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$00002000 constant SEC_ADC4_ADC_CFGR1_CONT                          \ Single / continuous conversion mode This bit is set and cleared by software. If it is set, conversion takes place continuously until it is cleared. Note: It is not possible to have both discontinuous mode and continuous mode enabled: it is forbidden to set both bits DISCEN = 1 and CONT = 1. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$00004000 constant SEC_ADC4_ADC_CFGR1_WAIT                          \ Wait conversion mode This bit is set and cleared by software to enable/disable wait conversion mode.sup./sup Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$00010000 constant SEC_ADC4_ADC_CFGR1_DISCEN                        \ Discontinuous mode This bit is set and cleared by software to enable/disable discontinuous mode. Note: It is not possible to have both discontinuous mode and continuous mode enabled: it is forbidden to set both bits DISCEN = 1 and CONT = 1. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$00200000 constant SEC_ADC4_ADC_CFGR1_CHSELRMOD                     \ Mode selection of the ADC_CHSELR register This bit is set and cleared by software to control the ADC_CHSELR feature: Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$00400000 constant SEC_ADC4_ADC_CFGR1_AWD1SGL                       \ Enable the watchdog on a single channel or on all channels This bit is set and cleared by software to enable the analog watchdog on the channel identified by the AWDCH[4:0] bits or on all the channels Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$00800000 constant SEC_ADC4_ADC_CFGR1_AWD1EN                        \ Analog watchdog enable This bit is set and cleared by software. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).
$7c000000 constant SEC_ADC4_ADC_CFGR1_AWD1CH                        \ Analog watchdog channel selection These bits are set and cleared by software. They select the input channel to be guarded by the analog watchdog. ..... Others: Reserved The channel selected by the AWDCH[4:0] bits must be also set into the CHSELR register. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).


\
\ @brief ADC configuration register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_ADC4_ADC_CFGR2_OVSE                          \ Oversampler Enable This bit is set and cleared by software. Note: Software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$0000001c constant SEC_ADC4_ADC_CFGR2_OVSR                          \ Oversampling ratio This bit filed defines the number of oversampling ratio. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$000001e0 constant SEC_ADC4_ADC_CFGR2_OVSS                          \ Oversampling shift This bit is set and cleared by software. Others: Reserved Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1(which ensures that no conversion is ongoing).
$00000200 constant SEC_ADC4_ADC_CFGR2_TOVS                          \ Triggered Oversampling This bit is set and cleared by software. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$20000000 constant SEC_ADC4_ADC_CFGR2_LFTRIG                        \ Low frequency trigger mode enable This bit must be set by software. Note: The software is allowed to write this bit only when ADSTART bit is cleared to 0 by writing ADSTP to 1 (this ensures that no conversion is ongoing).


\
\ @brief ADC sampling time register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000007 constant SEC_ADC4_ADC_SMPR_SMP1                           \ Sampling time selection 1 These bits are written by software to select the sampling time that applies to all channels. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000070 constant SEC_ADC4_ADC_SMPR_SMP2                           \ Sampling time selection 2 These bits are written by software to select the sampling time that applies to all channels. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000100 constant SEC_ADC4_ADC_SMPR_SMPSEL0                        \ Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000200 constant SEC_ADC4_ADC_SMPR_SMPSEL1                        \ Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000400 constant SEC_ADC4_ADC_SMPR_SMPSEL2                        \ Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000800 constant SEC_ADC4_ADC_SMPR_SMPSEL3                        \ Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00001000 constant SEC_ADC4_ADC_SMPR_SMPSEL4                        \ Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00002000 constant SEC_ADC4_ADC_SMPR_SMPSEL5                        \ Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00004000 constant SEC_ADC4_ADC_SMPR_SMPSEL6                        \ Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00008000 constant SEC_ADC4_ADC_SMPR_SMPSEL7                        \ Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00010000 constant SEC_ADC4_ADC_SMPR_SMPSEL8                        \ Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00020000 constant SEC_ADC4_ADC_SMPR_SMPSEL9                        \ Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00040000 constant SEC_ADC4_ADC_SMPR_SMPSEL10                       \ Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00080000 constant SEC_ADC4_ADC_SMPR_SMPSEL11                       \ Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00100000 constant SEC_ADC4_ADC_SMPR_SMPSEL12                       \ Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00200000 constant SEC_ADC4_ADC_SMPR_SMPSEL13                       \ Channel-x sampling time selection These bits are written by software to define which sampling time is used. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).


\
\ @brief ADC watchdog threshold register
\ Address offset: 0x20
\ Reset value: 0x0FFF0000
\

$00000fff constant SEC_ADC4_ADC_AWD1TR_LT1                          \ Analog watchdog 1 lower threshold These bits are written by software to define the lower threshold for the analog watchdog. Refer to Section 20.4.25: Analog window watchdog on page 638.
$0fff0000 constant SEC_ADC4_ADC_AWD1TR_HT1                          \ Analog watchdog 1 higher threshold These bits are written by software to define the higher threshold for the analog watchdog. Refer to Section 20.4.25: Analog window watchdog on page 638.


\
\ @brief ADC watchdog threshold register
\ Address offset: 0x24
\ Reset value: 0x0FFF0000
\

$00000fff constant SEC_ADC4_ADC_AWD2TR_LT2                          \ Analog watchdog 2 lower threshold These bits are written by software to define the lower threshold for the analog watchdog. Refer to Section 20.4.25: Analog window watchdog on page 638.
$0fff0000 constant SEC_ADC4_ADC_AWD2TR_HT2                          \ Analog watchdog 2 higher threshold These bits are written by software to define the higher threshold for the analog watchdog. Refer to Section 20.4.25: Analog window watchdog on page 638.


\
\ @brief ADC channel selection register [alternate]
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant SEC_ADC4_ADC_CHSELR_CHSEL0                       \ Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000002 constant SEC_ADC4_ADC_CHSELR_CHSEL1                       \ Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000004 constant SEC_ADC4_ADC_CHSELR_CHSEL2                       \ Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000008 constant SEC_ADC4_ADC_CHSELR_CHSEL3                       \ Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000010 constant SEC_ADC4_ADC_CHSELR_CHSEL4                       \ Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000020 constant SEC_ADC4_ADC_CHSELR_CHSEL5                       \ Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000040 constant SEC_ADC4_ADC_CHSELR_CHSEL6                       \ Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000080 constant SEC_ADC4_ADC_CHSELR_CHSEL7                       \ Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000100 constant SEC_ADC4_ADC_CHSELR_CHSEL8                       \ Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000200 constant SEC_ADC4_ADC_CHSELR_CHSEL9                       \ Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000400 constant SEC_ADC4_ADC_CHSELR_CHSEL10                      \ Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000800 constant SEC_ADC4_ADC_CHSELR_CHSEL11                      \ Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00001000 constant SEC_ADC4_ADC_CHSELR_CHSEL12                      \ Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00002000 constant SEC_ADC4_ADC_CHSELR_CHSEL13                      \ Channel x selection These bits are written by software and define which channels are part of the sequence of channels to be converted. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).


\
\ @brief ADC channel selection register [alternate]
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000000f constant SEC_ADC4_ADC_CHSELR_ALTERNATE_SQ1                \ 1st conversion of the sequence These bits are programmed by software with the channel number assigned to the 1st conversion of the sequence. 0b1111 indicates end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. Refer to SQ8[3:0] for a definition of channel selection. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$000000f0 constant SEC_ADC4_ADC_CHSELR_ALTERNATE_SQ2                \ 2nd conversion of the sequence These bits are programmed by software with the channel number assigned to the 2nd conversion of the sequence. 0b1111 indicates end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. Refer to SQ8[3:0] for a definition of channel selection. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000f00 constant SEC_ADC4_ADC_CHSELR_ALTERNATE_SQ3                \ 3rd conversion of the sequence These bits are programmed by software with the channel number assigned to the 3rd conversion of the sequence. 0b1111 indicates end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. Refer to SQ8[3:0] for a definition of channel selection. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$0000f000 constant SEC_ADC4_ADC_CHSELR_ALTERNATE_SQ4                \ 4th conversion of the sequence These bits are programmed by software with the channel number assigned to the 4th conversion of the sequence. 0b1111 indicates end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. Refer to SQ8[3:0] for a definition of channel selection. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1(which ensures that no conversion is ongoing).
$000f0000 constant SEC_ADC4_ADC_CHSELR_ALTERNATE_SQ5                \ 5th conversion of the sequence These bits are programmed by software with the channel number assigned to the 5th conversion of the sequence. 0b1111 indicates end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. Refer to SQ8[3:0] for a definition of channel selection. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00f00000 constant SEC_ADC4_ADC_CHSELR_ALTERNATE_SQ6                \ 6th conversion of the sequence These bits are programmed by software with the channel number assigned to the 6th conversion of the sequence. 0b1111 indicates end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. Refer to SQ8[3:0] for a definition of channel selection. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$0f000000 constant SEC_ADC4_ADC_CHSELR_ALTERNATE_SQ7                \ 7th conversion of the sequence These bits are programmed by software with the channel number assigned to the 7th conversion of the sequence. 0b1111 indicates end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. Refer to SQ8[3:0] for a definition of channel selection. Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$f0000000 constant SEC_ADC4_ADC_CHSELR_ALTERNATE_SQ8                \ 8th conversion of the sequence These bits are programmed by software with the channel number assigned to the 8th conversion of the sequence. 0b1111 indicates the end of the sequence. When 0b1111 (end of sequence) is programmed to the lower sequence channels, these bits are ignored. ... Note: The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).


\
\ @brief ADC watchdog threshold register
\ Address offset: 0x2C
\ Reset value: 0x0FFF0000
\

$00000fff constant SEC_ADC4_ADC_AWD3TR_LT3                          \ Analog watchdog 3lower threshold These bits are written by software to define the lower threshold for the analog watchdog. Refer to Section 20.4.25: Analog window watchdog on page 638.
$0fff0000 constant SEC_ADC4_ADC_AWD3TR_HT3                          \ Analog watchdog 3 higher threshold These bits are written by software to define the higher threshold for the analog watchdog. Refer to Section 20.4.25: Analog window watchdog on page 638.


\
\ @brief ADC data register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant SEC_ADC4_ADC_DR_DATA                             \ Converted data These bits are read-only. They contain the conversion result from the last converted channel. The data are left- or right-aligned as shown in Figure 78: Data alignment and resolution (oversampling disabled: OVSE = 0) on page 631. Just after a calibration is complete, DATA[6:0] contains the calibration factor.


\
\ @brief ADC data register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant SEC_ADC4_ADC_PWR_AUTOFF                          \ Auto-off mode bit This bit is set and cleared by software. it is used to enable/disable the Auto-off mode. Note: The software is allowed to write this bit only when ADEN bit is cleared to 0 (this ensures that no conversion is ongoing).
$00000002 constant SEC_ADC4_ADC_PWR_DPD                             \ Deep-power-down mode bit This bit is set and cleared by software. It is used to enable/disable Deep-power-down mode in Autonomous mode when the ADC is not used. Note: The software is allowed to write this bit only when ADEN bit is cleared to 0 (this ensures that no conversion is ongoing). Note: Setting DPD in Auto-off mode automatically disables the LDO.


\
\ @brief ADC Analog Watchdog 2 Configuration register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000001 constant SEC_ADC4_ADC_AWD2CR_AWD2CH0                      \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000002 constant SEC_ADC4_ADC_AWD2CR_AWD2CH1                      \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000004 constant SEC_ADC4_ADC_AWD2CR_AWD2CH2                      \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000008 constant SEC_ADC4_ADC_AWD2CR_AWD2CH3                      \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000010 constant SEC_ADC4_ADC_AWD2CR_AWD2CH4                      \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000020 constant SEC_ADC4_ADC_AWD2CR_AWD2CH5                      \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000040 constant SEC_ADC4_ADC_AWD2CR_AWD2CH6                      \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000080 constant SEC_ADC4_ADC_AWD2CR_AWD2CH7                      \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000100 constant SEC_ADC4_ADC_AWD2CR_AWD2CH8                      \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000200 constant SEC_ADC4_ADC_AWD2CR_AWD2CH9                      \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000400 constant SEC_ADC4_ADC_AWD2CR_AWD2CH10                     \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000800 constant SEC_ADC4_ADC_AWD2CR_AWD2CH11                     \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00001000 constant SEC_ADC4_ADC_AWD2CR_AWD2CH12                     \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00002000 constant SEC_ADC4_ADC_AWD2CR_AWD2CH13                     \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 2 (AWD2). Note: The channels selected through ADC_AWD2CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).


\
\ @brief ADC Analog Watchdog 3 Configuration register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000001 constant SEC_ADC4_ADC_AWD3CR_AWD3CH0                      \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000002 constant SEC_ADC4_ADC_AWD3CR_AWD3CH1                      \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000004 constant SEC_ADC4_ADC_AWD3CR_AWD3CH2                      \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000008 constant SEC_ADC4_ADC_AWD3CR_AWD3CH3                      \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000010 constant SEC_ADC4_ADC_AWD3CR_AWD3CH4                      \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000020 constant SEC_ADC4_ADC_AWD3CR_AWD3CH5                      \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000040 constant SEC_ADC4_ADC_AWD3CR_AWD3CH6                      \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000080 constant SEC_ADC4_ADC_AWD3CR_AWD3CH7                      \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000100 constant SEC_ADC4_ADC_AWD3CR_AWD3CH8                      \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000200 constant SEC_ADC4_ADC_AWD3CR_AWD3CH9                      \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000400 constant SEC_ADC4_ADC_AWD3CR_AWD3CH10                     \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00000800 constant SEC_ADC4_ADC_AWD3CR_AWD3CH11                     \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00001000 constant SEC_ADC4_ADC_AWD3CR_AWD3CH12                     \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00002000 constant SEC_ADC4_ADC_AWD3CR_AWD3CH13                     \ Analog watchdog channel selection These bits are set and cleared by software. They enable and select the input channels to be guarded by analog watchdog 3 (AWD3). Note: The channels selected through ADC_AWD3CR must be also configured into the ADC_CHSELR registers. Refer to SQ8[3:0] for a definition of channel selection. The software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).


\
\ @brief ADC Calibration factor
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$0000007f constant SEC_ADC4_ADC_CALFACT_CALFACT                     \ Calibration factor These bits are written by hardware or by software. Once a calibration is complete, they are updated by hardware with the calibration factors. Software can write these bits with a new calibration factor. If the new calibration factor is different from the current one stored into the analog ADC, it is then applied once a new calibration is launched. Just after a calibration is complete, DATA[6:0] contains the calibration factor. Note: Software can write these bits only when ADEN = 1 (ADC is enabled and no calibration is ongoing and no conversion is ongoing).


\
\ @brief ADC common configuration register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$003c0000 constant SEC_ADC4_ADC_CCR_PRESC                           \ ADC prescaler Set and cleared by software to select the frequency of the clock to the ADC. Other: Reserved Note: Software is allowed to write these bits only when the ADC is disabled (ADCAL = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
$00400000 constant SEC_ADC4_ADC_CCR_VREFEN                          \ VsubREFINT/sub enable This bit is set and cleared by software to enable/disable the VsubREFINT/sub buffer. Note: Software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).
$00800000 constant SEC_ADC4_ADC_CCR_VSENSESEL                       \ Temperature sensor selection This bit is set and cleared by software to enable/disable the temperature sensor. Note: Software is allowed to write this bit only when ADSTART is cleared to 0 by writing ADSTP to 1 (which ensures that no conversion is ongoing).


\
\ @brief ADC register block
\
$56021000 constant SEC_ADC4_ADC_ISR  \ offset: 0x00 : ADC interrupt and status register
$56021004 constant SEC_ADC4_ADC_IER  \ offset: 0x04 : ADC interrupt enable register
$56021008 constant SEC_ADC4_ADC_CR  \ offset: 0x08 : ADC control register
$5602100c constant SEC_ADC4_ADC_CFGR1  \ offset: 0x0C : ADC configuration register 1
$56021010 constant SEC_ADC4_ADC_CFGR2  \ offset: 0x10 : ADC configuration register 2
$56021014 constant SEC_ADC4_ADC_SMPR  \ offset: 0x14 : ADC sampling time register
$56021020 constant SEC_ADC4_ADC_AWD1TR  \ offset: 0x20 : ADC watchdog threshold register
$56021024 constant SEC_ADC4_ADC_AWD2TR  \ offset: 0x24 : ADC watchdog threshold register
$56021028 constant SEC_ADC4_ADC_CHSELR  \ offset: 0x28 : ADC channel selection register [alternate]
$56021028 constant SEC_ADC4_ADC_CHSELR_ALTERNATE  \ offset: 0x28 : ADC channel selection register [alternate]
$5602102c constant SEC_ADC4_ADC_AWD3TR  \ offset: 0x2C : ADC watchdog threshold register
$56021040 constant SEC_ADC4_ADC_DR  \ offset: 0x40 : ADC data register
$56021044 constant SEC_ADC4_ADC_PWR  \ offset: 0x44 : ADC data register
$560210a0 constant SEC_ADC4_ADC_AWD2CR  \ offset: 0xA0 : ADC Analog Watchdog 2 Configuration register
$560210a4 constant SEC_ADC4_ADC_AWD3CR  \ offset: 0xA4 : ADC Analog Watchdog 3 Configuration register
$560210c4 constant SEC_ADC4_ADC_CALFACT  \ offset: 0xC4 : ADC Calibration factor
$56021308 constant SEC_ADC4_ADC_CCR  \ offset: 0x308 : ADC common configuration register

