\
\ @file adc12.fs
\ @brief ADC common registers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC12_DEF

  [ifdef] ADC12_ADC12_CCR_DEF
    \
    \ @brief ADC_CCR system control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $12 constant ADC12_PRESC                    \ [0x12 : 4] ADC prescaler These bits are set and cleared by software to select the frequency of the ADC clock. The clock is common to all ADCs. Others: Reserved, must not be used Note: The software is allowed to write this bit only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
    $16 constant ADC12_VREFEN                   \ [0x16] VREFINT enable This bit is set and cleared by software to enable/disable the VREFINT buffer. Note: The software is allowed to write this bit only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
    $17 constant ADC12_VSENSESEL                \ [0x17] Temperature sensor voltage selection This bit is set and cleared by software to control the temperature sensor channel. Note: The software is allowed to write this bit only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
    $18 constant ADC12_VBATEN                   \ [0x18] VBAT enable This bit is set and cleared by software to control the VBAT channel. Note: The software is allowed to write this bit only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
  [then]

  \
  \ @brief ADC common registers
  \
  $08 constant ADC12_ADC12_CCR          \ ADC_CCR system control register

: ADC12_DEF ; [then]
