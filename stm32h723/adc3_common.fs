\
\ @file adc3_common.fs
\ @brief Analog-to-Digital Converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC3_COMMON_DEF

  [ifdef] ADC3_COMMON_ADC_CSR_DEF
    \
    \ @brief ADC common status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_COMMON_ADRDY_MST          \ [0x00] Master ADC ready This bit is a copy of the ADRDY bit in the corresponding ADC_ISR register.
    $01 constant ADC3_COMMON_EOSMP_MST          \ [0x01] End of Sampling phase flag of the master ADC This bit is a copy of the EOSMP bit in the corresponding ADC_ISR register.
    $02 constant ADC3_COMMON_EOC_MST            \ [0x02] End of regular conversion of the master ADC This bit is a copy of the EOC bit in the corresponding ADC_ISR register.
    $03 constant ADC3_COMMON_EOS_MST            \ [0x03] End of regular sequence flag of the master ADC This bit is a copy of the EOS bit in the corresponding ADC_ISR register.
    $04 constant ADC3_COMMON_OVR_MST            \ [0x04] Overrun flag of the master ADC This bit is a copy of the OVR bit in the corresponding ADC_ISR register.
    $05 constant ADC3_COMMON_JEOC_MST           \ [0x05] End of injected conversion flag of the master ADC This bit is a copy of the JEOC bit in the corresponding ADC_ISR register.
    $06 constant ADC3_COMMON_JEOS_MST           \ [0x06] End of injected sequence flag of the master ADC This bit is a copy of the JEOS bit in the corresponding ADC_ISR register.
    $07 constant ADC3_COMMON_AWD1_MST           \ [0x07] Analog watchdog 1 flag of the master ADC This bit is a copy of the AWD1 bit in the corresponding ADC_ISR register.
    $08 constant ADC3_COMMON_AWD2_MST           \ [0x08] Analog watchdog 2 flag of the master ADC This bit is a copy of the AWD2 bit in the corresponding ADC_ISR register.
    $09 constant ADC3_COMMON_AWD3_MST           \ [0x09] Analog watchdog 3 flag of the master ADC This bit is a copy of the AWD3 bit in the corresponding ADC_ISR register.
    $0a constant ADC3_COMMON_JQOVF_MST          \ [0x0a] Injected Context Queue Overflow flag of the master ADC This bit is a copy of the JQOVF bit in the corresponding ADC_ISR register.
  [then]


  [ifdef] ADC3_COMMON_ADC_CCR_DEF
    \
    \ @brief ADC common control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $10 constant ADC3_COMMON_CKMODE             \ [0x10 : 2] ADC clock mode These bits are set and cleared by software to define the ADC clock scheme (which is common to both master and slave ADCs): In all synchronous clock modes, there is no jitter in the delay from a timer trigger to the start of a conversion. Note: The software is allowed to write these bits only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
    $12 constant ADC3_COMMON_PRESC              \ [0x12 : 4] ADC prescaler These bits are set and cleared by software to select the frequency of the clock to the ADC. The clock is common for all the ADCs. other: reserved Note: The software is allowed to write these bits only when the ADC is disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0). The ADC prescaler value is applied only when CKMODE[1:0] = 0b00.
    $16 constant ADC3_COMMON_VREFEN             \ [0x16] VREFINT enable This bit is set and cleared by software to enable/disable the VREFINT channel.
    $17 constant ADC3_COMMON_TSEN               \ [0x17] VSENSE enable This bit is set and cleared by software to control VSENSE.
    $18 constant ADC3_COMMON_VBATEN             \ [0x18] VBAT enable This bit is set and cleared by software to control.
  [then]


  [ifdef] ADC3_COMMON_ADC_CDR_DEF
    \
    \ @brief ADC common regular data register for dual and triple modes
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_COMMON_RDATA_MST          \ [0x00 : 16] Regular data of the master ADC
    $10 constant ADC3_COMMON_RDATA_SLV          \ [0x10 : 16] Regular data of the slave ADC
  [then]


  [ifdef] ADC3_COMMON_ADC_CDR2_DEF
    \
    \ @brief ADC x common regular data register for 32-bit dual mode
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_COMMON_RDATA_ALT          \ [0x00 : 32] Regular data of the master/slave alternated ADCs
  [then]

  \
  \ @brief Analog-to-Digital Converter
  \
  $00 constant ADC3_COMMON_ADC_CSR      \ ADC common status register
  $08 constant ADC3_COMMON_ADC_CCR      \ ADC common control register
  $0C constant ADC3_COMMON_ADC_CDR      \ ADC common regular data register for dual and triple modes
  $10 constant ADC3_COMMON_ADC_CDR2     \ ADC x common regular data register for 32-bit dual mode

: ADC3_COMMON_DEF ; [then]
