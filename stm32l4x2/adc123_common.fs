\
\ @file adc123_common.fs
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

$00000001 constant ADC123_COMMON_ADC_CSR_ADRDY_MST                  \ Master ADC ready This bit is a copy of the ADRDY bit in the corresponding ADC_ISR register.
$00000002 constant ADC123_COMMON_ADC_CSR_EOSMP_MST                  \ End of Sampling phase flag of the master ADC This bit is a copy of the EOSMP bit in the corresponding ADC_ISR register.
$00000004 constant ADC123_COMMON_ADC_CSR_EOC_MST                    \ End of regular conversion of the master ADC This bit is a copy of the EOC bit in the corresponding ADC_ISR register.
$00000008 constant ADC123_COMMON_ADC_CSR_EOS_MST                    \ End of regular sequence flag of the master ADC This bit is a copy of the EOS bit in the corresponding ADC_ISR register.
$00000010 constant ADC123_COMMON_ADC_CSR_OVR_MST                    \ Overrun flag of the master ADC This bit is a copy of the OVR bit in the corresponding ADC_ISR register.
$00000020 constant ADC123_COMMON_ADC_CSR_JEOC_MST                   \ End of injected conversion flag of the master ADC This bit is a copy of the JEOC bit in the corresponding ADC_ISR register.
$00000040 constant ADC123_COMMON_ADC_CSR_JEOS_MST                   \ End of injected sequence flag of the master ADC This bit is a copy of the JEOS bit in the corresponding ADC_ISR register.
$00000080 constant ADC123_COMMON_ADC_CSR_AWD1_MST                   \ Analog watchdog 1 flag of the master ADC This bit is a copy of the AWD1 bit in the corresponding ADC_ISR register.
$00000100 constant ADC123_COMMON_ADC_CSR_AWD2_MST                   \ Analog watchdog 2 flag of the master ADC This bit is a copy of the AWD2 bit in the corresponding ADC_ISR register.
$00000200 constant ADC123_COMMON_ADC_CSR_AWD3_MST                   \ Analog watchdog 3 flag of the master ADC This bit is a copy of the AWD3 bit in the corresponding ADC_ISR register.
$00000400 constant ADC123_COMMON_ADC_CSR_JQOVF_MST                  \ Injected Context Queue Overflow flag of the master ADC This bit is a copy of the JQOVF bit in the corresponding ADC_ISR register.
$00010000 constant ADC123_COMMON_ADC_CSR_ADRDY_SLV                  \ Slave ADC ready This bit is a copy of the ADRDY bit in the corresponding ADC_ISR register.
$00020000 constant ADC123_COMMON_ADC_CSR_EOSMP_SLV                  \ End of Sampling phase flag of the slave ADC This bit is a copy of the EOSMP2 bit in the corresponding ADC_ISR register.
$00040000 constant ADC123_COMMON_ADC_CSR_EOC_SLV                    \ End of regular conversion of the slave ADC This bit is a copy of the EOC bit in the corresponding ADC_ISR register.
$00080000 constant ADC123_COMMON_ADC_CSR_EOS_SLV                    \ End of regular sequence flag of the slave ADC. This bit is a copy of the EOS bit in the corresponding ADC_ISR register.
$00100000 constant ADC123_COMMON_ADC_CSR_OVR_SLV                    \ Overrun flag of the slave ADC This bit is a copy of the OVR bit in the corresponding ADC_ISR register.
$00200000 constant ADC123_COMMON_ADC_CSR_JEOC_SLV                   \ End of injected conversion flag of the slave ADC This bit is a copy of the JEOC bit in the corresponding ADC_ISR register.
$00400000 constant ADC123_COMMON_ADC_CSR_JEOS_SLV                   \ End of injected sequence flag of the slave ADC This bit is a copy of the JEOS bit in the corresponding ADC_ISR register.
$00800000 constant ADC123_COMMON_ADC_CSR_AWD1_SLV                   \ Analog watchdog 1 flag of the slave ADC This bit is a copy of the AWD1 bit in the corresponding ADC_ISR register.
$01000000 constant ADC123_COMMON_ADC_CSR_AWD2_SLV                   \ Analog watchdog 2 flag of the slave ADC This bit is a copy of the AWD2 bit in the corresponding ADC_ISR register.
$02000000 constant ADC123_COMMON_ADC_CSR_AWD3_SLV                   \ Analog watchdog 3 flag of the slave ADC This bit is a copy of the AWD3 bit in the corresponding ADC_ISR register.
$04000000 constant ADC123_COMMON_ADC_CSR_JQOVF_SLV                  \ Injected Context Queue Overflow flag of the slave ADC This bit is a copy of the JQOVF bit in the corresponding ADC_ISR register.


\
\ @brief ADC common control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000001f constant ADC123_COMMON_ADC_CCR_DUAL                       \ Dual ADC mode selection These bits are written by software to select the operating mode. All the ADCs independent: 00001 to 01001: Dual mode, master and slave ADCs working together All other combinations are reserved and must not be programmed Note: The software is allowed to write these bits only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
$00000f00 constant ADC123_COMMON_ADC_CCR_DELAY                      \ Delay between 2 sampling phases These bits are set and cleared by software. These bits are used in dual interleaved modes. Refer to Table 112 for the value of ADC resolution versus DELAY bits values. Note: The software is allowed to write these bits only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
$00002000 constant ADC123_COMMON_ADC_CCR_DMACFG                     \ DMA configuration (for dual ADC mode) This bit is set and cleared by software to select between two DMA modes of operation and is effective only when DMAEN = 1. For more details, refer to Section : Managing conversions using the DMA Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$0000c000 constant ADC123_COMMON_ADC_CCR_MDMA                       \ Direct memory access mode for dual ADC mode This bitfield is set and cleared by software. Refer to the DMA controller section for more details. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00030000 constant ADC123_COMMON_ADC_CCR_CKMODE                     \ ADC clock mode These bits are set and cleared by software to define the ADC clock scheme (which is common to both master and slave ADCs): In all synchronous clock modes, there is no jitter in the delay from a timer trigger to the start of a conversion. Note: The software is allowed to write these bits only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
$003c0000 constant ADC123_COMMON_ADC_CCR_PRESC                      \ ADC prescaler These bits are set and cleared by software to select the frequency of the clock to the ADC. The clock is common for all the ADCs. other: reserved Note: The software is allowed to write these bits only when the ADC is disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0). The ADC prescaler value is applied only when CKMODE[1:0] = 00.
$00400000 constant ADC123_COMMON_ADC_CCR_VREFEN                     \ V<sub>REFINT</sub> enable This bit is set and cleared by software to enable/disable the V<sub>REFINT</sub> channel.
$00800000 constant ADC123_COMMON_ADC_CCR_CH17SEL                    \ CH17 selection This bit is set and cleared by software to control channel 17.
$01000000 constant ADC123_COMMON_ADC_CCR_CH18SEL                    \ CH18 selection This bit is set and cleared by software to control channel 18.


\
\ @brief ADC common regular data register for dual mode
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant ADC123_COMMON_ADC_CDR_RDATA_MST                  \ Regular data of the master ADC. In dual mode, these bits contain the regular data of the master ADC. Refer to Section 16.4.32: Dual ADC modes. The data alignment is applied as described in Section : Data register, data alignment and offset (ADC_DR, OFFSETy, OFFSETy_CH, ALIGN)) In MDMA = 11 mode, bits 15:8 contains SLV_ADC_DR[7:0], bits 7:0 contains MST_ADC_DR[7:0].
$ffff0000 constant ADC123_COMMON_ADC_CDR_RDATA_SLV                  \ Regular data of the slave ADC In dual mode, these bits contain the regular data of the slave ADC. Refer to Section 16.4.32: Dual ADC modes. The data alignment is applied as described in Section : Data register, data alignment and offset (ADC_DR, OFFSETy, OFFSETy_CH, ALIGN))


\
\ @brief Analog-to-Digital Converter
\
$50040300 constant ADC123_COMMON_ADC_CSR  \ offset: 0x00 : ADC common status register
$50040308 constant ADC123_COMMON_ADC_CCR  \ offset: 0x08 : ADC common control register
$5004030c constant ADC123_COMMON_ADC_CDR  \ offset: 0x0C : ADC common regular data register for dual mode

