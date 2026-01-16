\
\ @file adc_common.fs
\ @brief ADC common registers
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

$00000001 constant ADC_COMMON_ADC1_CSR_ADRDY_MST                    \ Master ADC ready
$00000002 constant ADC_COMMON_ADC1_CSR_EOSMP_MST                    \ End of Sampling phase flag of the master ADC
$00000004 constant ADC_COMMON_ADC1_CSR_EOC_MST                      \ End of regular conversion of the master ADC
$00000008 constant ADC_COMMON_ADC1_CSR_EOS_MST                      \ End of regular sequence flag of the master ADC
$00000010 constant ADC_COMMON_ADC1_CSR_OVR_MST                      \ Overrun flag of the master ADC
$00000020 constant ADC_COMMON_ADC1_CSR_JEOC_MST                     \ End of injected conversion flag of the master ADC
$00000040 constant ADC_COMMON_ADC1_CSR_JEOS_MST                     \ End of injected sequence flag of the master ADC
$00000080 constant ADC_COMMON_ADC1_CSR_AWD1_MST                     \ Analog watchdog 1 flag of the master ADC
$00000100 constant ADC_COMMON_ADC1_CSR_AWD2_MST                     \ Analog watchdog 2 flag of the master ADC
$00000200 constant ADC_COMMON_ADC1_CSR_AWD3_MST                     \ Analog watchdog 3 flag of the master ADC
$00000400 constant ADC_COMMON_ADC1_CSR_JQOVF_MST                    \ Injected Context Queue Overflow flag of the master ADC
$00010000 constant ADC_COMMON_ADC1_CSR_ADRDY_SLV                    \ Slave ADC ready
$00020000 constant ADC_COMMON_ADC1_CSR_EOSMP_SLV                    \ End of Sampling phase flag of the slave ADC
$00040000 constant ADC_COMMON_ADC1_CSR_EOC_SLV                      \ End of regular conversion of the slave ADC
$00080000 constant ADC_COMMON_ADC1_CSR_EOS_SLV                      \ End of regular sequence flag of the slave ADC
$00100000 constant ADC_COMMON_ADC1_CSR_OVR_SLV                      \ Overrun flag of the slave ADC
$00200000 constant ADC_COMMON_ADC1_CSR_JEOC_SLV                     \ End of injected conversion flag of the slave ADC
$00400000 constant ADC_COMMON_ADC1_CSR_JEOS_SLV                     \ End of injected sequence flag of the slave ADC
$00800000 constant ADC_COMMON_ADC1_CSR_AWD1_SLV                     \ Analog watchdog 1 flag of the slave ADC
$01000000 constant ADC_COMMON_ADC1_CSR_AWD2_SLV                     \ Analog watchdog 2 flag of the slave ADC
$02000000 constant ADC_COMMON_ADC1_CSR_AWD3_SLV                     \ Analog watchdog 3 flag of the slave ADC
$04000000 constant ADC_COMMON_ADC1_CSR_JQOVF_SLV                    \ Injected Context Queue Overflow flag of the slave ADC


\
\ @brief ADC common control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000001f constant ADC_COMMON_ADC1_CCR_DUAL                         \ Dual ADC mode selection
$00000f00 constant ADC_COMMON_ADC1_CCR_DELAY                        \ Delay between 2 sampling phases
$00002000 constant ADC_COMMON_ADC1_CCR_DMACFG                       \ DMA configuration (for dual ADC mode)
$0000c000 constant ADC_COMMON_ADC1_CCR_MDMA                         \ Direct memory access mode for dual ADC mode
$00030000 constant ADC_COMMON_ADC1_CCR_CKMODE                       \ ADC clock mode
$00400000 constant ADC_COMMON_ADC1_CCR_VREFEN                       \ VREFINT enable
$00800000 constant ADC_COMMON_ADC1_CCR_TSEN                         \ Temperature sensor enable
$01000000 constant ADC_COMMON_ADC1_CCR_VBATEN                       \ VBAT enable


\
\ @brief ADC common regular data register for dual mode
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant ADC_COMMON_ADC1_CDR_RDATA_MST                    \ Regular data of the master ADC
$ffff0000 constant ADC_COMMON_ADC1_CDR_RDATA_SLV                    \ Regular data of the slave ADC


\
\ @brief ADC common registers
\
$50000300 constant ADC_COMMON_ADC1_CSR  \ offset: 0x00 : ADC Common status register
$50000308 constant ADC_COMMON_ADC1_CCR  \ offset: 0x08 : ADC common control register
$5000030c constant ADC_COMMON_ADC1_CDR  \ offset: 0x0C : ADC common regular data register for dual mode

