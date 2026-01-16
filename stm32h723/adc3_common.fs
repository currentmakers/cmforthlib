\
\ @file adc3_common.fs
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

$00000001 constant ADC3_COMMON_ADC_CSR_ADRDY_MST                    \ Master ADC ready This bit is a copy of the ADRDY bit in the corresponding ADC_ISR register.
$00000002 constant ADC3_COMMON_ADC_CSR_EOSMP_MST                    \ End of Sampling phase flag of the master ADC This bit is a copy of the EOSMP bit in the corresponding ADC_ISR register.
$00000004 constant ADC3_COMMON_ADC_CSR_EOC_MST                      \ End of regular conversion of the master ADC This bit is a copy of the EOC bit in the corresponding ADC_ISR register.
$00000008 constant ADC3_COMMON_ADC_CSR_EOS_MST                      \ End of regular sequence flag of the master ADC This bit is a copy of the EOS bit in the corresponding ADC_ISR register.
$00000010 constant ADC3_COMMON_ADC_CSR_OVR_MST                      \ Overrun flag of the master ADC This bit is a copy of the OVR bit in the corresponding ADC_ISR register.
$00000020 constant ADC3_COMMON_ADC_CSR_JEOC_MST                     \ End of injected conversion flag of the master ADC This bit is a copy of the JEOC bit in the corresponding ADC_ISR register.
$00000040 constant ADC3_COMMON_ADC_CSR_JEOS_MST                     \ End of injected sequence flag of the master ADC This bit is a copy of the JEOS bit in the corresponding ADC_ISR register.
$00000080 constant ADC3_COMMON_ADC_CSR_AWD1_MST                     \ Analog watchdog 1 flag of the master ADC This bit is a copy of the AWD1 bit in the corresponding ADC_ISR register.
$00000100 constant ADC3_COMMON_ADC_CSR_AWD2_MST                     \ Analog watchdog 2 flag of the master ADC This bit is a copy of the AWD2 bit in the corresponding ADC_ISR register.
$00000200 constant ADC3_COMMON_ADC_CSR_AWD3_MST                     \ Analog watchdog 3 flag of the master ADC This bit is a copy of the AWD3 bit in the corresponding ADC_ISR register.
$00000400 constant ADC3_COMMON_ADC_CSR_JQOVF_MST                    \ Injected Context Queue Overflow flag of the master ADC This bit is a copy of the JQOVF bit in the corresponding ADC_ISR register.


\
\ @brief ADC common control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00030000 constant ADC3_COMMON_ADC_CCR_CKMODE                       \ ADC clock mode These bits are set and cleared by software to define the ADC clock scheme (which is common to both master and slave ADCs): In all synchronous clock modes, there is no jitter in the delay from a timer trigger to the start of a conversion. Note: The software is allowed to write these bits only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
$003c0000 constant ADC3_COMMON_ADC_CCR_PRESC                        \ ADC prescaler These bits are set and cleared by software to select the frequency of the clock to the ADC. The clock is common for all the ADCs. other: reserved Note: The software is allowed to write these bits only when the ADC is disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0). The ADC prescaler value is applied only when CKMODE[1:0] = 0b00.
$00400000 constant ADC3_COMMON_ADC_CCR_VREFEN                       \ VREFINT enable This bit is set and cleared by software to enable/disable the VREFINT channel.
$00800000 constant ADC3_COMMON_ADC_CCR_TSEN                         \ VSENSE enable This bit is set and cleared by software to control VSENSE.
$01000000 constant ADC3_COMMON_ADC_CCR_VBATEN                       \ VBAT enable This bit is set and cleared by software to control.


\
\ @brief ADC common regular data register for dual and triple modes
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant ADC3_COMMON_ADC_CDR_RDATA_MST                    \ Regular data of the master ADC
$ffff0000 constant ADC3_COMMON_ADC_CDR_RDATA_SLV                    \ Regular data of the slave ADC


\
\ @brief ADC x common regular data register for 32-bit dual mode
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant ADC3_COMMON_ADC_CDR2_RDATA_ALT                   \ Regular data of the master/slave alternated ADCs


\
\ @brief Analog-to-Digital Converter
\
$58026300 constant ADC3_COMMON_ADC_CSR  \ offset: 0x00 : ADC common status register
$58026308 constant ADC3_COMMON_ADC_CCR  \ offset: 0x08 : ADC common control register
$5802630c constant ADC3_COMMON_ADC_CDR  \ offset: 0x0C : ADC common regular data register for dual and triple modes
$58026310 constant ADC3_COMMON_ADC_CDR2  \ offset: 0x10 : ADC x common regular data register for 32-bit dual mode

