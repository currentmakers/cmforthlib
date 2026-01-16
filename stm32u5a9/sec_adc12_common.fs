\
\ @file sec_adc12_common.fs
\ @brief Analog-to-Digital Converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief ADC common status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_ADC12_COMMON_ADC12_CSR_ADRDY_MST             \ Master ADC ready This bit is a copy of the ADRDY bit in the corresponding ADC_ISR register.
$00000002 constant SEC_ADC12_COMMON_ADC12_CSR_EOSMP_MST             \ End of Sampling phase flag of the master ADC This bit is a copy of the EOSMP bit in the corresponding ADC_ISR register.
$00000004 constant SEC_ADC12_COMMON_ADC12_CSR_EOC_MST               \ End of regular conversion of the master ADC This bit is a copy of the EOC bit in the corresponding ADC_ISR register.
$00000008 constant SEC_ADC12_COMMON_ADC12_CSR_EOS_MST               \ End of regular sequence flag of the master ADC This bit is a copy of the EOS bit in the corresponding ADC_ISR register.
$00000010 constant SEC_ADC12_COMMON_ADC12_CSR_OVR_MST               \ Overrun flag of the master ADC This bit is a copy of the OVR bit in the corresponding ADC_ISR register.
$00000020 constant SEC_ADC12_COMMON_ADC12_CSR_JEOC_MST              \ End of injected conversion flag of the master ADC This bit is a copy of the JEOC bit in the corresponding ADC_ISR register.
$00000040 constant SEC_ADC12_COMMON_ADC12_CSR_JEOS_MST              \ End of injected sequence flag of the master ADC This bit is a copy of the JEOS bit in the corresponding ADC_ISR register.
$00000080 constant SEC_ADC12_COMMON_ADC12_CSR_AWD1_MST              \ Analog watchdog 1 flag of the master ADC This bit is a copy of the AWD1 bit in the corresponding ADC_ISR register.
$00000100 constant SEC_ADC12_COMMON_ADC12_CSR_AWD2_MST              \ Analog watchdog 2 flag of the master ADC This bit is a copy of the AWD2 bit in the corresponding ADC_ISR register.
$00000200 constant SEC_ADC12_COMMON_ADC12_CSR_AWD3_MST              \ Analog watchdog 3 flag of the master ADC This bit is a copy of the AWD3 bit in the corresponding ADC_ISR register.
$00001000 constant SEC_ADC12_COMMON_ADC12_CSR_LDORDY_MST            \ ADC voltage regulator ready flag of the master ADC This bit is a copy of the LDORDY bit of the corresponding ADC_ISR register.
$00010000 constant SEC_ADC12_COMMON_ADC12_CSR_ADRDY_SLV             \ Slave ADC ready This bit is a copy of the ADRDY bit in the corresponding ADCx+1_ISR register.
$00020000 constant SEC_ADC12_COMMON_ADC12_CSR_EOSMP_SLV             \ End of Sampling phase flag of the slave ADC This bit is a copy of the EOSMP2 bit in the corresponding ADCx+1_ISR register.
$00040000 constant SEC_ADC12_COMMON_ADC12_CSR_EOC_SLV               \ End of regular conversion of the slave ADC This bit is a copy of the EOC bit in the corresponding ADCx+1_ISR register.
$00080000 constant SEC_ADC12_COMMON_ADC12_CSR_EOS_SLV               \ End of regular sequence flag of the slave ADC This bit is a copy of the EOS bit in the corresponding ADCx+1_ISR register.
$00100000 constant SEC_ADC12_COMMON_ADC12_CSR_OVR_SLV               \ Overrun flag of the slave ADC This bit is a copy of the OVR bit in the corresponding ADCx+1_ISR register.
$00200000 constant SEC_ADC12_COMMON_ADC12_CSR_JEOC_SLV              \ End of injected conversion flag of the slave ADC This bit is a copy of the JEOC bit in the corresponding ADCx+1_ISR register.
$00400000 constant SEC_ADC12_COMMON_ADC12_CSR_JEOS_SLV              \ End of injected sequence flag of the slave ADC This bit is a copy of the JEOS bit in the corresponding ADCx+1_ISR register.
$00800000 constant SEC_ADC12_COMMON_ADC12_CSR_AWD1_SLV              \ Analog watchdog 1 flag of the slave ADC This bit is a copy of the AWD1 bit in the corresponding ADCx+1_ISR register.
$01000000 constant SEC_ADC12_COMMON_ADC12_CSR_AWD2_SLV              \ Analog watchdog 2 flag of the slave ADC This bit is a copy of the AWD2 bit in the corresponding ADCx+1_ISR register.
$02000000 constant SEC_ADC12_COMMON_ADC12_CSR_AWD3_SLV              \ Analog watchdog 3 flag of the slave ADC This bit is a copy of the AWD3 bit in the corresponding ADCx+1_ISR register.
$10000000 constant SEC_ADC12_COMMON_ADC12_CSR_LDORDY_SLV            \ ADC voltage regulator ready flag of the slave ADC This bit is a copy of the LDORDY bit of the corresponding ADCx+1_ISR register.


\
\ @brief ADC_CCR system control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000001f constant SEC_ADC12_COMMON_ADC12_CCR_DUAL                  \ Dual ADC mode selection These bits are written by software to select the operating mode. All the ADCs are independent: The configurations 00001 to 01001 correspond to the following operating modes: Dual mode, master and slave ADCs working together: All other combinations are reserved and must not be programmed Note: The software is allowed to write these bits only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
$00000f00 constant SEC_ADC12_COMMON_ADC12_CCR_DELAY                 \ Delay between the end of the master ADC sampling phase and the beginning of the slave ADC sampling phase. These bits are set and cleared by software. These bits are used in dual interleaved modes. Refer to for the value of ADC resolution versus DELAY bits values. Note: The software is allowed to write these bits only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
$0000c000 constant SEC_ADC12_COMMON_ADC12_CCR_DAMDF                 \ Dual ADC Mode Data Format This bit-field is set and cleared by software. It specifies the data format in the common data register ADC12_CDR. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$003c0000 constant SEC_ADC12_COMMON_ADC12_CCR_PRESC                 \ ADC prescaler These bits are set and cleared by software to select the frequency of the ADC clock. The clock is common to all ADCs. Others: Reserved, must not be used Note: The software is allowed to write this bit only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
$00400000 constant SEC_ADC12_COMMON_ADC12_CCR_VREFEN                \ VREFINT enable This bit is set and cleared by software to enable/disable the VREFINT buffer. Note: The software is allowed to write this bit only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
$00800000 constant SEC_ADC12_COMMON_ADC12_CCR_VSENSESEL             \ Temperature sensor voltage selection This bit is set and cleared by software to control the temperature sensor channel. Note: The software is allowed to write this bit only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
$01000000 constant SEC_ADC12_COMMON_ADC12_CCR_VBATEN                \ VBAT enable This bit is set and cleared by software to control the VBAT channel. Note: The software is allowed to write this bit only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).


\
\ @brief ADC common regular data register for dual mode
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant SEC_ADC12_COMMON_ADC12_CDR_RDATA_MST             \ Regular data of the master ADC. In dual mode, these bits contain the regular data of the master ADC. Refer to . The data alignment is applied as described in offset (ADC_DR, ADC_JDRy, OFFSETy, OFFSETy_CH, OVSS, LSHIFT, USAT, SSAT)) In DAMDF[1:0] = 11 mode, bits 15:8 contains SLV_ADC_DR[7:0], bits 7:0 contains MST_ADC_DR[7:0].
$ffff0000 constant SEC_ADC12_COMMON_ADC12_CDR_RDATA_SLV             \ Regular data of the slave ADC In dual mode, these bits contain the regular data of the slave ADC. Refer to Dual ADC modes. The data alignment is applied as described in offset (ADC_DR, ADC_JDRy, OFFSETy, OFFSETy_CH, OVSS, LSHIFT, USAT, SSAT))


\
\ @brief ADC common regular data register for 32-bit dual mode
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant SEC_ADC12_COMMON_ADC12_CDR2_RDATA_ALT            \ Regular data of the master/slave alternated ADCs In dual mode, these bits alternatively contains the regular 32-bit data of the master and the slave ADC. Refer to . The data alignment is applied as described in (ADC_DR, ADC_JDRy, OFFSETy, OFFSETy_CH, OVSS, LSHIFT, USAT, SSAT).


\
\ @brief Analog-to-Digital Converter
\
$52028300 constant SEC_ADC12_COMMON_ADC12_CSR  \ offset: 0x00 : ADC common status register
$52028308 constant SEC_ADC12_COMMON_ADC12_CCR  \ offset: 0x08 : ADC_CCR system control register
$5202830c constant SEC_ADC12_COMMON_ADC12_CDR  \ offset: 0x0C : ADC common regular data register for dual mode
$52028310 constant SEC_ADC12_COMMON_ADC12_CDR2  \ offset: 0x10 : ADC common regular data register for 32-bit dual mode

