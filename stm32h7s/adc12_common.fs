\
\ @file adc12_common.fs
\ @brief master and slave ADC common
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC12_COMMON_DEF

  [ifdef] ADC12_COMMON_ADC_CSR_DEF
    \
    \ @brief ADC common status register
    \ Address offset: 0x300
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
    $0a constant ADC12_COMMON_JQOVF_MST         \ [0x0a] Injected Context Queue Overflow flag of the master ADC This bit is a copy of the JQOVF bit in the corresponding ADC_ISR register.
    $10 constant ADC12_COMMON_ADRDY_SLV         \ [0x10] Slave ADC ready This bit is a copy of the ADRDY bit in the corresponding ADC_ISR register.
    $11 constant ADC12_COMMON_EOSMP_SLV         \ [0x11] End of Sampling phase flag of the slave ADC This bit is a copy of the EOSMP2 bit in the corresponding ADC_ISR register.
    $12 constant ADC12_COMMON_EOC_SLV           \ [0x12] End of regular conversion of the slave ADC This bit is a copy of the EOC bit in the corresponding ADC_ISR register.
    $13 constant ADC12_COMMON_EOS_SLV           \ [0x13] End of regular sequence flag of the slave ADC. This bit is a copy of the EOS bit in the corresponding ADC_ISR register.
    $14 constant ADC12_COMMON_OVR_SLV           \ [0x14] Overrun flag of the slave ADC This bit is a copy of the OVR bit in the corresponding ADC_ISR register.
    $15 constant ADC12_COMMON_JEOC_SLV          \ [0x15] End of injected conversion flag of the slave ADC This bit is a copy of the JEOC bit in the corresponding ADC_ISR register.
    $16 constant ADC12_COMMON_JEOS_SLV          \ [0x16] End of injected sequence flag of the slave ADC This bit is a copy of the JEOS bit in the corresponding ADC_ISR register.
    $17 constant ADC12_COMMON_AWD1_SLV          \ [0x17] Analog watchdog 1 flag of the slave ADC This bit is a copy of the AWD1 bit in the corresponding ADC_ISR register.
    $18 constant ADC12_COMMON_AWD2_SLV          \ [0x18] Analog watchdog 2 flag of the slave ADC This bit is a copy of the AWD2 bit in the corresponding ADC_ISR register.
    $19 constant ADC12_COMMON_AWD3_SLV          \ [0x19] Analog watchdog 3 flag of the slave ADC This bit is a copy of the AWD3 bit in the corresponding ADC_ISR register.
    $1a constant ADC12_COMMON_JQOVF_SLV         \ [0x1a] Injected Context Queue Overflow flag of the slave ADC This bit is a copy of the JQOVF bit in the corresponding ADC_ISR register.
  [then]


  [ifdef] ADC12_COMMON_ADC_CCR_DEF
    \
    \ @brief ADC common control register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant ADC12_COMMON_DUAL              \ [0x00 : 5] Dual ADC mode selection These bits are written by software to select the operating mode. 00000 corresponds to Independent mode. Values 00001 to 01001 correspond to Dual mode, master and slave ADCs working together. Others: Reserved, must not be used Note: The software is allowed to write these bits only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
    $08 constant ADC12_COMMON_DELAY             \ [0x08 : 4] Delay between 2 sampling phases These bits are set and cleared by software. These bits are used in dual interleaved modes. Refer to Table 198 for the value of ADC resolution versus DELAY bits values. Note: The software is allowed to write these bits only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
    $0d constant ADC12_COMMON_DMACFG            \ [0x0d] DMA configuration (for dual ADC mode) This bit is set and cleared by software to select between two DMA modes of operation and is effective only when DMAEN = 1. For more details, refer to Section : Managing conversions using the DMA Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $0e constant ADC12_COMMON_MDMA              \ [0x0e : 2] Direct memory access mode for dual ADC mode This bitfield is set and cleared by software. Refer to the DMA controller section for more details. Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
    $10 constant ADC12_COMMON_CKMODE            \ [0x10 : 2] ADC clock mode These bits are set and cleared by software to define the ADC clock scheme (which is common to both master and slave ADCs): In all synchronous clock modes, there is no jitter in the delay from a timer trigger to the start of a conversion. Note: The software is allowed to write these bits only when the ADCs are disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0).
    $12 constant ADC12_COMMON_PRESC             \ [0x12 : 4] ADC prescaler These bits are set and cleared by software to select the frequency of the clock to the ADC. The clock is common for all the ADCs. other: reserved Note: The software is allowed to write these bits only when the ADC is disabled (ADCAL = 0, JADSTART = 0, ADSTART = 0, ADSTP = 0, ADDIS = 0 and ADEN = 0). The ADC prescaler value is applied only when CKMODE[1:0] = 0b00.
    $16 constant ADC12_COMMON_VREFEN            \ [0x16] V<sub>REFINT</sub> enable This bit is set and cleared by software to enable/disable the V<sub>REFINT</sub> channel.
    $17 constant ADC12_COMMON_TSEN              \ [0x17] V<sub>SENSE</sub> enable This bit is set and cleared by software to control V<sub>SENSE</sub>.
    $18 constant ADC12_COMMON_VBATEN            \ [0x18] VBAT enable This bit is set and cleared by software to control.
  [then]


  [ifdef] ADC12_COMMON_ADC_CDR_DEF
    \
    \ @brief ADC common regular data register for dual mode
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
    $00 constant ADC12_COMMON_RDATA_MST         \ [0x00 : 16] Regular data of the master ADC. In dual mode, these bits contain the regular data of the master ADC. Refer to Section 25.4.31: Dual ADC modes. The data alignment is applied as described in Section : Data register, data alignment and offset (ADC_DR, OFFSET, OFFSET_CH, ALIGN)) In MDMA = 0b11 mode, bits 15:8 contains SLV_ADC_DR[7:0], bits 7:0 contains MST_ADC_DR[7:0].
    $10 constant ADC12_COMMON_RDATA_SLV         \ [0x10 : 16] Regular data of the slave ADC In dual mode, these bits contain the regular data of the slave ADC. Refer to Section 25.4.31: Dual ADC modes. The data alignment is applied as described in Section : Data register, data alignment and offset (ADC_DR, OFFSET, OFFSET_CH, ALIGN))
  [then]


  [ifdef] ADC12_COMMON_ADC_HWCFGR0_DEF
    \
    \ @brief ADC hardware configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x00001112
    \
    $00 constant ADC12_COMMON_ADCNUM            \ [0x00 : 4] Number of ADCs implemented
    $04 constant ADC12_COMMON_MULPIPE           \ [0x04 : 4] Number of pipeline stages
    $08 constant ADC12_COMMON_OPBITS            \ [0x08 : 4] Number of option bits
    $0c constant ADC12_COMMON_IDLEVALUE         \ [0x0c : 4] Idle value for non-selected channels
  [then]


  [ifdef] ADC12_COMMON_ADC_VERR_DEF
    \
    \ @brief ADC version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000012
    \
    $00 constant ADC12_COMMON_MINREV            \ [0x00 : 4] Minor revision These bits returns the ADC IP minor revision
    $04 constant ADC12_COMMON_MAJREV            \ [0x04 : 4] Major revision These bits returns the ADC IP major revision
  [then]


  [ifdef] ADC12_COMMON_ADC_IPDR_DEF
    \
    \ @brief ADC identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00110006
    \
    $00 constant ADC12_COMMON_ID                \ [0x00 : 32] Peripheral identifier These bits returns the ADC identifier. ID[31:0] = 0x0011 0006: c7amba_aditf5_90_v1
  [then]


  [ifdef] ADC12_COMMON_ADC_SIDR_DEF
    \
    \ @brief ADC size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant ADC12_COMMON_SID               \ [0x00 : 32] Size Identification SID[31:8]: fixed code that characterizes the ADC_SIDR register. This field is always read at 0xA3C5DD. SID[7:0]: read-only numeric field that returns the address offset (in Kbytes) of the identification registers from the IP base address:
  [then]

  \
  \ @brief master and slave ADC common
  \
  $300 constant ADC12_COMMON_ADC_CSR    \ ADC common status register
  $308 constant ADC12_COMMON_ADC_CCR    \ ADC common control register
  $30C constant ADC12_COMMON_ADC_CDR    \ ADC common regular data register for dual mode
  $3F0 constant ADC12_COMMON_ADC_HWCFGR0    \ ADC hardware configuration register
  $3F4 constant ADC12_COMMON_ADC_VERR   \ ADC version register
  $3F8 constant ADC12_COMMON_ADC_IPDR   \ ADC identification register
  $3FC constant ADC12_COMMON_ADC_SIDR   \ ADC size identification register

: ADC12_COMMON_DEF ; [then]
