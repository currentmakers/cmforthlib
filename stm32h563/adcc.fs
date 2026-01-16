\
\ @file adcc.fs
\ @brief ADC common registers block
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

$00000001 constant ADCC_ADC_CSR_ADRDY_MST                           \ Master ADC ready
$00000002 constant ADCC_ADC_CSR_EOSMP_MST                           \ End of Sampling phase flag of the master ADC
$00000004 constant ADCC_ADC_CSR_EOC_MST                             \ End of regular conversion of the master ADC
$00000008 constant ADCC_ADC_CSR_EOS_MST                             \ End of regular sequence flag of the master ADC
$00000010 constant ADCC_ADC_CSR_OVR_MST                             \ Overrun flag of the master ADC
$00000020 constant ADCC_ADC_CSR_JEOC_MST                            \ End of injected conversion flag of the master ADC
$00000040 constant ADCC_ADC_CSR_JEOS_MST                            \ End of injected sequence flag of the master ADC
$00000080 constant ADCC_ADC_CSR_AWD1_MST                            \ Analog watchdog 1 flag of the master ADC
$00000100 constant ADCC_ADC_CSR_AWD2_MST                            \ Analog watchdog 2 flag of the master ADC
$00000200 constant ADCC_ADC_CSR_AWD3_MST                            \ Analog watchdog 3 flag of the master ADC
$00000400 constant ADCC_ADC_CSR_JQOVF_MST                           \ Injected Context Queue Overflow flag of the master ADC
$00010000 constant ADCC_ADC_CSR_ADRDY_SLV                           \ Slave ADC ready
$00020000 constant ADCC_ADC_CSR_EOSMP_SLV                           \ End of Sampling phase flag of the slave ADC
$00040000 constant ADCC_ADC_CSR_EOC_SLV                             \ End of regular conversion of the slave ADC
$00080000 constant ADCC_ADC_CSR_EOS_SLV                             \ End of regular sequence flag of the slave ADC.
$00100000 constant ADCC_ADC_CSR_OVR_SLV                             \ Overrun flag of the slave ADC
$00200000 constant ADCC_ADC_CSR_JEOC_SLV                            \ End of injected conversion flag of the slave ADC
$00400000 constant ADCC_ADC_CSR_JEOS_SLV                            \ End of injected sequence flag of the slave ADC
$00800000 constant ADCC_ADC_CSR_AWD1_SLV                            \ Analog watchdog 1 flag of the slave ADC
$01000000 constant ADCC_ADC_CSR_AWD2_SLV                            \ Analog watchdog 2 flag of the slave ADC
$02000000 constant ADCC_ADC_CSR_AWD3_SLV                            \ Analog watchdog 3 flag of the slave ADC
$04000000 constant ADCC_ADC_CSR_JQOVF_SLV                           \ Injected Context Queue Overflow flag of the slave ADC


\
\ @brief ADC common control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000001f constant ADCC_ADC_CCR_DUAL                                \ Dual ADC mode selection
$00000f00 constant ADCC_ADC_CCR_DELAY                               \ Delay between 2 sampling phases
$00002000 constant ADCC_ADC_CCR_DMACFG                              \ DMA configuration (for dual ADC mode)
$0000c000 constant ADCC_ADC_CCR_MDMA                                \ Direct memory access mode for dual ADC mode
$00030000 constant ADCC_ADC_CCR_CKMODE                              \ ADC clock mode
$003c0000 constant ADCC_ADC_CCR_PRESC                               \ ADC prescaler
$00400000 constant ADCC_ADC_CCR_VREFEN                              \ Vless thansub>REFINTless than/sub> enable
$00800000 constant ADCC_ADC_CCR_TSEN                                \ Vless thansub>SENSEless than/sub> enable
$01000000 constant ADCC_ADC_CCR_VBATEN                              \ VBAT enable


\
\ @brief ADC common regular data register for dual mode
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant ADCC_ADC_CDR_RDATA_MST                           \ Regular data of the master ADC.
$ffff0000 constant ADCC_ADC_CDR_RDATA_SLV                           \ Regular data of the slave ADC


\
\ @brief ADC hardware configuration register
\ Address offset: 0xF0
\ Reset value: 0x00001212
\

$0000000f constant ADCC_ADC_HWCFGR0_ADCNUM                          \ Number of ADCs implemented
$000000f0 constant ADCC_ADC_HWCFGR0_MULPIPE                         \ Number of pipeline stages
$00000f00 constant ADCC_ADC_HWCFGR0_OPBITS                          \ Number of option bits
$0000f000 constant ADCC_ADC_HWCFGR0_IDLEVALUE                       \ Idle value for non-selected channels


\
\ @brief ADC version register
\ Address offset: 0xF4
\ Reset value: 0x00000012
\

$0000000f constant ADCC_ADC_VERR_MINREV                             \ Minor revision
$000000f0 constant ADCC_ADC_VERR_MAJREV                             \ Major revision


\
\ @brief ADC identification register
\ Address offset: 0xF8
\ Reset value: 0x00110006
\

$00000000 constant ADCC_ADC_IPDR_ID                                 \ Peripheral identifier


\
\ @brief ADC size identification register
\ Address offset: 0xFC
\ Reset value: 0xA3C5DD01
\

$00000000 constant ADCC_ADC_SIDR_SID                                \ Size Identification


\
\ @brief ADC common registers block
\
$42028300 constant ADCC_ADC_CSR   \ offset: 0x00 : ADC common status register
$42028308 constant ADCC_ADC_CCR   \ offset: 0x08 : ADC common control register
$4202830c constant ADCC_ADC_CDR   \ offset: 0x0C : ADC common regular data register for dual mode
$420283f0 constant ADCC_ADC_HWCFGR0  \ offset: 0xF0 : ADC hardware configuration register
$420283f4 constant ADCC_ADC_VERR  \ offset: 0xF4 : ADC version register
$420283f8 constant ADCC_ADC_IPDR  \ offset: 0xF8 : ADC identification register
$420283fc constant ADCC_ADC_SIDR  \ offset: 0xFC : ADC size identification register

