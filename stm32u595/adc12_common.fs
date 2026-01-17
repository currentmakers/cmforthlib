\
\ @file adc12_common.fs
\ @brief Analog-to-Digital Converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC12_COMMON_DEF

  [ifdef] ADC12_COMMON_ADC12_CSR_DEF
    \
    \ @brief ADC common status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADC12_COMMON_ADRDY_MST         \ [0x00] Master ADC ready This bit is a copy of the ADRDY bit in the corresponding ADC_ISR register.
    $01 constant ADC12_COMMON_EOSMP_MST         \ [0x01] End of Sampling phase flag of the master ADC This bit is a copy of the EOSMP bit in the corresponding ADC_ISR register.
    $02 constant ADC12_COMMON_EOC_MST           \ [0x02] End of regular conversion of the master ADC This bit is a copy of the EOC bit in the corresponding ADC_ISR register.
    $03 constant ADC12_COMMON_EOS_MST           \ [0x03] End of regular sequence flag of the master ADC This bit is a copy of the EOS bit in the corresponding ADC_ISR register.
    $04 constant ADC12_COMMON_OVR_MST           \ [0x04] Overrun flag of the master ADC This bit is a copy of the OVR bit in the corresponding ADC_ISR register.
    $05 constant ADC12_COMMON_JEOC_MST          \ [0x05] End of injected conversion flag of the master ADC This bit is a copy of the JEOC bit in the corresponding ADC_ISR register.
    $06 constant ADC12_COMMON_JEOS_MST          \ [0x06] End of injected sequence flag of the master ADC This bit is a copy of the JEOS bit in the corresponding ADC_ISR register.
    $07 constant ADC12_COMMON_AWD1_MST          \ [0x07] Analog watchdog 1 flag of the master ADC This bit is a copy of the AWD1 bit in the corresponding ADC_ISR register.
    $08 constant ADC12_COMMON_AWD2_MST          \ [0x08] Analog watchdog 2 flag of the master ADC This bit is a copy of the AWD2 bit in the corresponding ADC_ISR register.
    $09 constant ADC12_COMMON_AWD3_MST          \ [0x09] Analog watchdog 3 flag of the master ADC This bit is a copy of the AWD3 bit in the corresponding ADC_ISR register.
    $0c constant ADC12_COMMON_LDORDY_MST        \ [0x0c] ADC voltage regulator ready flag of the master ADC This bit is a copy of the LDORDY bit of the corresponding ADC_ISR register.
    $10 constant ADC12_COMMON_ADRDY_SLV         \ [0x10] Slave ADC ready This bit is a copy of the ADRDY bit in the corresponding ADCx+1_ISR register.
    $11 constant ADC12_COMMON_EOSMP_SLV         \ [0x11] End of Sampling phase flag of the slave ADC This bit is a copy of the EOSMP2 bit in the corresponding ADCx+1_ISR register.
    $12 constant ADC12_COMMON_EOC_SLV           \ [0x12] End of regular conversion of the slave ADC This bit is a copy of the EOC bit in the corresponding ADCx+1_ISR register.
    $13 constant ADC12_COMMON_EOS_SLV           \ [0x13] End of regular sequence flag of the slave ADC This bit is a copy of the EOS bit in the corresponding ADCx+1_ISR register.
    $14 constant ADC12_COMMON_OVR_SLV           \ [0x14] Overrun flag of the slave ADC This bit is a copy of the OVR bit in the corresponding ADCx+1_ISR register.
    $15 constant ADC12_COMMON_JEOC_SLV          \ [0x15] End of injected conversion flag of the slave ADC This bit is a copy of the JEOC bit in the corresponding ADCx+1_ISR register.
    $16 constant ADC12_COMMON_JEOS_SLV          \ [0x16] End of injected sequence flag of the slave ADC This bit is a copy of the JEOS bit in the corresponding ADCx+1_ISR register.
    $17 constant ADC12_COMMON_AWD1_SLV          \ [0x17] Analog watchdog 1 flag of the slave ADC This bit is a copy of the AWD1 bit in the corresponding ADCx+1_ISR register.
    $18 constant ADC12_COMMON_AWD2_SLV          \ [0x18] Analog watchdog 2 flag of the slave ADC This bit is a copy of the AWD2 bit in the corresponding ADCx+1_ISR register.
    $19 constant ADC12_COMMON_AWD3_SLV          \ [0x19] Analog watchdog 3 flag of the slave ADC This bit is a copy of the AWD3 bit in the corresponding ADCx+1_ISR register.
    $1c constant ADC12_COMMON_LDORDY_SLV        \ [0x1c] ADC voltage regulator ready flag of the slave ADC This bit is a copy of the LDORDY bit of the corresponding ADCx+1_ISR register.
  [then]


  [ifdef] ADC12_COMMON_ADC12_CCR_DEF
    \
    \ @brief ADC_CCR system control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ADC12_COMMON_DUAL              \ [0x00 : 5] Dual ADC mode selection These bits are written by software to select the operating mode. All the ADCs are independent: The configurations 00001 to 01001 correspond to the following operating modes: Dual mode, master and slave ADCs working together: All other combinations are reserved and must not be programmed Note: The software is allowed to write these bits only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
    $08 constant ADC12_COMMON_DELAY             \ [0x08 : 4] Delay between the end of the master ADC sampling phase and the beginning of the slave ADC sampling phase. These bits are set and cleared by software. These bits are used in dual interleaved modes. Refer to for the value of ADC resolution versus DELAY bits values. Note: The software is allowed to write these bits only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
    $0e constant ADC12_COMMON_DAMDF             \ [0x0e : 2] Dual ADC Mode Data Format This bit-field is set and cleared by software. It specifies the data format in the common data register ADC12_CDR. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $12 constant ADC12_COMMON_PRESC             \ [0x12 : 4] ADC prescaler These bits are set and cleared by software to select the frequency of the ADC clock. The clock is common to all ADCs. Others: Reserved, must not be used Note: The software is allowed to write this bit only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
    $16 constant ADC12_COMMON_VREFEN            \ [0x16] VREFINT enable This bit is set and cleared by software to enable/disable the VREFINT buffer. Note: The software is allowed to write this bit only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
    $17 constant ADC12_COMMON_VSENSESEL         \ [0x17] Temperature sensor voltage selection This bit is set and cleared by software to control the temperature sensor channel. Note: The software is allowed to write this bit only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
    $18 constant ADC12_COMMON_VBATEN            \ [0x18] VBAT enable This bit is set and cleared by software to control the VBAT channel. Note: The software is allowed to write this bit only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
  [then]


  [ifdef] ADC12_COMMON_ADC12_CDR_DEF
    \
    \ @brief ADC common regular data register for dual mode
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ADC12_COMMON_RDATA_MST         \ [0x00 : 16] Regular data of the master ADC. In dual mode, these bits contain the regular data of the master ADC. Refer to . The data alignment is applied as described in offset (ADC_DR, ADC_JDRy, OFFSETy, OFFSETy_CH, OVSS, LSHIFT, USAT, SSAT)) In DAMDF[1:0] = 11 mode, bits 15:8 contains SLV_ADC_DR[7:0], bits 7:0 contains MST_ADC_DR[7:0].
    $10 constant ADC12_COMMON_RDATA_SLV         \ [0x10 : 16] Regular data of the slave ADC In dual mode, these bits contain the regular data of the slave ADC. Refer to Dual ADC modes. The data alignment is applied as described in offset (ADC_DR, ADC_JDRy, OFFSETy, OFFSETy_CH, OVSS, LSHIFT, USAT, SSAT))
  [then]


  [ifdef] ADC12_COMMON_ADC12_CDR2_DEF
    \
    \ @brief ADC common regular data register for 32-bit dual mode
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ADC12_COMMON_RDATA_ALT         \ [0x00 : 32] Regular data of the master/slave alternated ADCs In dual mode, these bits alternatively contains the regular 32-bit data of the master and the slave ADC. Refer to . The data alignment is applied as described in (ADC_DR, ADC_JDRy, OFFSETy, OFFSETy_CH, OVSS, LSHIFT, USAT, SSAT).
  [then]

  \
  \ @brief Analog-to-Digital Converter
  \
  $00 constant ADC12_COMMON_ADC12_CSR   \ ADC common status register
  $08 constant ADC12_COMMON_ADC12_CCR   \ ADC_CCR system control register
  $0C constant ADC12_COMMON_ADC12_CDR   \ ADC common regular data register for dual mode
  $10 constant ADC12_COMMON_ADC12_CDR2  \ ADC common regular data register for 32-bit dual mode

: ADC12_COMMON_DEF ; [then]
