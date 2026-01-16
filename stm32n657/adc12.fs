\
\ @file adc12.fs
\ @brief ADC common registers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief ADC12 common status register
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant ADC12_ADC12_CSR_ADRDY_MST                        \ Master ADC ready
$00000002 constant ADC12_ADC12_CSR_EOSMP_MST                        \ End of Sampling phase flag of the master ADC
$00000004 constant ADC12_ADC12_CSR_EOC_MST                          \ End of regular conversion of the master ADC
$00000008 constant ADC12_ADC12_CSR_EOS_MST                          \ End of regular sequence flag of the master ADC
$00000010 constant ADC12_ADC12_CSR_OVR_MST                          \ Overrun flag of the master ADC
$00000020 constant ADC12_ADC12_CSR_JEOC_MST                         \ End of injected conversion flag of the master ADC
$00000040 constant ADC12_ADC12_CSR_JEOS_MST                         \ End of injected sequence flag of the master ADC
$00000080 constant ADC12_ADC12_CSR_AWD1_MST                         \ Analog watchdog 1 flag of the master ADC
$00000100 constant ADC12_ADC12_CSR_AWD2_MST                         \ Analog watchdog 2 flag of the master ADC
$00000200 constant ADC12_ADC12_CSR_AWD3_MST                         \ Analog watchdog 3 flag of the master ADC
$00010000 constant ADC12_ADC12_CSR_ADRDY_SLV                        \ Slave ADC ready
$00020000 constant ADC12_ADC12_CSR_EOSMP_SLV                        \ End of Sampling phase flag of the slave ADC
$00040000 constant ADC12_ADC12_CSR_EOC_SLV                          \ End of regular conversion of the slave ADC
$00080000 constant ADC12_ADC12_CSR_EOS_SLV                          \ End of regular sequence flag of the slave ADC. This bit is a copy of the EOS bit in the corresponding ADC_ISR register.
$00100000 constant ADC12_ADC12_CSR_OVR_SLV                          \ Overrun flag of the slave ADC
$00200000 constant ADC12_ADC12_CSR_JEOC_SLV                         \ End of injected conversion flag of the slave ADC
$00400000 constant ADC12_ADC12_CSR_JEOS_SLV                         \ End of injected sequence flag of the slave ADC
$00800000 constant ADC12_ADC12_CSR_AWD1_SLV                         \ Analog watchdog 1 flag of the slave ADC
$01000000 constant ADC12_ADC12_CSR_AWD2_SLV                         \ Analog watchdog 2 flag of the slave ADC
$02000000 constant ADC12_ADC12_CSR_AWD3_SLV                         \ Analog watchdog 3 flag of the slave ADC


\
\ @brief ADC12 common control register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$0000001f constant ADC12_ADC12_CCR_DUAL                             \ Dual ADC mode selection
$00000f00 constant ADC12_ADC12_CCR_DELAY                            \ Delay between two sampling phases
$0000c000 constant ADC12_ADC12_CCR_DAMDF                            \ Dual ADC mode data format
$00400000 constant ADC12_ADC12_CCR_VREFEN                           \ Vless thansub>REFINTless than/sub> enable
$01000000 constant ADC12_ADC12_CCR_VBATEN                           \ VBAT enable


\
\ @brief ADC12 common regular data register for Dual mode
\ Address offset: 0x30C
\ Reset value: 0x00000000
\

$0000ffff constant ADC12_ADC12_CDR_RDATA_MST                        \ Regular data of the master ADC.
$ffff0000 constant ADC12_ADC12_CDR_RDATA_SLV                        \ Regular data of the slave ADC


\
\ @brief ADC12 common regular data register for Dual mode
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000000 constant ADC12_ADC12_CDR2_RDATA_ALT                       \ Regular data of the master/slave alternated ADCs.


\
\ @brief ADC common registers
\
$40022600 constant ADC12_ADC12_CSR  \ offset: 0x300 : ADC12 common status register
$40022608 constant ADC12_ADC12_CCR  \ offset: 0x308 : ADC12 common control register
$4002260c constant ADC12_ADC12_CDR  \ offset: 0x30C : ADC12 common regular data register for Dual mode
$40022610 constant ADC12_ADC12_CDR2  \ offset: 0x310 : ADC12 common regular data register for Dual mode

