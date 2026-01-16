\
\ @file sec_adc_common.fs
\ @brief Analog-to-Digital Converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief ADC Common status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_ADC_COMMON_CSR_ADDRDY_MST                    \ ADDRDY_MST
$00000002 constant SEC_ADC_COMMON_CSR_EOSMP_MST                     \ EOSMP_MST
$00000004 constant SEC_ADC_COMMON_CSR_EOC_MST                       \ EOC_MST
$00000008 constant SEC_ADC_COMMON_CSR_EOS_MST                       \ EOS_MST
$00000010 constant SEC_ADC_COMMON_CSR_OVR_MST                       \ OVR_MST
$00000020 constant SEC_ADC_COMMON_CSR_JEOC_MST                      \ JEOC_MST
$00000040 constant SEC_ADC_COMMON_CSR_JEOS_MST                      \ JEOS_MST
$00000080 constant SEC_ADC_COMMON_CSR_AWD1_MST                      \ AWD1_MST
$00000100 constant SEC_ADC_COMMON_CSR_AWD2_MST                      \ AWD2_MST
$00000200 constant SEC_ADC_COMMON_CSR_AWD3_MST                      \ AWD3_MST
$00000400 constant SEC_ADC_COMMON_CSR_JQOVF_MST                     \ JQOVF_MST
$00010000 constant SEC_ADC_COMMON_CSR_ADRDY_SLV                     \ ADRDY_SLV
$00020000 constant SEC_ADC_COMMON_CSR_EOSMP_SLV                     \ EOSMP_SLV
$00040000 constant SEC_ADC_COMMON_CSR_EOC_SLV                       \ EOC_SLV
$00080000 constant SEC_ADC_COMMON_CSR_EOS_SLV                       \ EOS_SLV
$00100000 constant SEC_ADC_COMMON_CSR_OVR_SLV                       \ OVR_SLV
$00200000 constant SEC_ADC_COMMON_CSR_JEOC_SLV                      \ JEOC_SLV
$00400000 constant SEC_ADC_COMMON_CSR_JEOS_SLV                      \ JEOS_SLV
$00800000 constant SEC_ADC_COMMON_CSR_AWD1_SLV                      \ AWD1_SLV
$01000000 constant SEC_ADC_COMMON_CSR_AWD2_SLV                      \ AWD2_SLV
$02000000 constant SEC_ADC_COMMON_CSR_AWD3_SLV                      \ AWD3_SLV
$04000000 constant SEC_ADC_COMMON_CSR_JQOVF_SLV                     \ JQOVF_SLV


\
\ @brief ADC common control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000001f constant SEC_ADC_COMMON_CCR_DUAL                          \ DUAL
$00000700 constant SEC_ADC_COMMON_CCR_DELAY                         \ DELAY
$00002000 constant SEC_ADC_COMMON_CCR_DMACFG                        \ DMACFG
$0000c000 constant SEC_ADC_COMMON_CCR_MDMA                          \ MDMA
$00030000 constant SEC_ADC_COMMON_CCR_CKMODE                        \ ADC clock mode
$003c0000 constant SEC_ADC_COMMON_CCR_PRESC                         \ ADC prescaler
$00400000 constant SEC_ADC_COMMON_CCR_VREFEN                        \ VREFINT enable
$00800000 constant SEC_ADC_COMMON_CCR_CH17SEL                       \ CH17SEL
$01000000 constant SEC_ADC_COMMON_CCR_CH18SEL                       \ CH18SEL


\
\ @brief Common regular data register for dual mode
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant SEC_ADC_COMMON_CDR_RDATA_MST                     \ RDATA_MST
$ffff0000 constant SEC_ADC_COMMON_CDR_RDATA_SLV                     \ RDATA_SLV


\
\ @brief Analog-to-Digital Converter
\
$52028300 constant SEC_ADC_COMMON_CSR  \ offset: 0x00 : ADC Common status register
$52028308 constant SEC_ADC_COMMON_CCR  \ offset: 0x08 : ADC common control register
$5202830c constant SEC_ADC_COMMON_CDR  \ offset: 0x0C : Common regular data register for dual mode

