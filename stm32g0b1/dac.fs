\
\ @file dac.fs
\ @brief DAC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DAC_DEF

  [ifdef] DAC_DAC_CR_DEF
    \
    \ @brief DAC control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DAC_EN1                        \ [0x00] DAC channel1 enable This bit is set and cleared by software to enable/disable DAC channel1.
    $01 constant DAC_TEN1                       \ [0x01] DAC channel1 trigger enable This bit is set and cleared by software to enable/disable DAC channel1 trigger. Note: When software trigger is selected, the transfer from the DAC_DHR1 register to the DAC_DOR1 register takes only one dac_pclk clock cycle.
    $02 constant DAC_TSEL1                      \ [0x02 : 4] DAC channel1 trigger selection These bits select the external event used to trigger DAC channel1 ... Refer to the trigger selection tables in for details on trigger configuration and mapping. Note: Only used if bit TEN1 = 1 (DAC channel1 trigger enabled).
    $06 constant DAC_WAVE1                      \ [0x06 : 2] DAC channel1 noise/triangle wave generation enable These bits are set and cleared by software. 1x: Triangle wave generation enabled Only used if bit TEN1 = 1 (DAC channel1 trigger enabled).
    $08 constant DAC_MAMP1                      \ [0x08 : 4] DAC channel1 mask/amplitude selector These bits are written by software to select mask in wave generation mode or amplitude in triangle generation mode. bigger or equal to 1011: Unmask bits[11:0] of LFSR/ triangle amplitude equal to 4095
    $0c constant DAC_DMAEN1                     \ [0x0c] DAC channel1 DMA enable This bit is set and cleared by software.
    $0d constant DAC_DMAUDRIE1                  \ [0x0d] DAC channel1 DMA Underrun Interrupt enable This bit is set and cleared by software.
    $0e constant DAC_CEN1                       \ [0x0e] DAC channel1 calibration enable This bit is set and cleared by software to enable/disable DAC channel1 calibration, it can be written only if bit EN1=0 into DAC_CR (the calibration mode can be entered/exit only when the DAC channel is disabled) Otherwise, the write operation is ignored.
    $10 constant DAC_EN2                        \ [0x10] DAC channel2 enable This bit is set and cleared by software to enable/disable DAC channel2. Note: These bits are available only on dual-channel DACs. Refer to implementation.
    $11 constant DAC_TEN2                       \ [0x11] DAC channel2 trigger enable This bit is set and cleared by software to enable/disable DAC channel2 trigger Note: When software trigger is selected, the transfer from the DAC_DHR2 register to the DAC_DOR2 register takes only one dac_pclk clock cycle. These bits are available only on dual-channel DACs. Refer to implementation.
    $12 constant DAC_TSEL2                      \ [0x12 : 4] DAC channel2 trigger selection These bits select the external event used to trigger DAC channel2 ... Refer to the trigger selection tables in for details on trigger configuration and mapping. Note: Only used if bit TEN2 = 1 (DAC channel2 trigger enabled). These bits are available only on dual-channel DACs. Refer to implementation.
    $16 constant DAC_WAVE2                      \ [0x16 : 2] DAC channel2 noise/triangle wave generation enable These bits are set/reset by software. 1x: Triangle wave generation enabled Note: Only used if bit TEN2 = 1 (DAC channel2 trigger enabled) These bits are available only on dual-channel DACs. Refer to implementation.
    $18 constant DAC_MAMP2                      \ [0x18 : 4] DAC channel2 mask/amplitude selector These bits are written by software to select mask in wave generation mode or amplitude in triangle generation mode. bigger or equal to 1011: Unmask bits[11:0] of LFSR/ triangle amplitude equal to 4095 Note: These bits are available only on dual-channel DACs. Refer to implementation.
    $1c constant DAC_DMAEN2                     \ [0x1c] DAC channel2 DMA enable This bit is set and cleared by software. Note: This bit is available only on dual-channel DACs. Refer to implementation.
    $1d constant DAC_DMAUDRIE2                  \ [0x1d] DAC channel2 DMA underrun interrupt enable This bit is set and cleared by software. Note: This bit is available only on dual-channel DACs. Refer to implementation.
    $1e constant DAC_CEN2                       \ [0x1e] DAC channel2 calibration enable This bit is set and cleared by software to enable/disable DAC channel2 calibration, it can be written only if EN2 bit is set to 0 into DAC_CR (the calibration mode can be entered/exit only when the DAC channel is disabled) Otherwise, the write operation is ignored. Note: This bit is available only on dual-channel DACs. Refer to implementation.
  [then]


  [ifdef] DAC_DAC_SWTRGR_DEF
    \
    \ @brief DAC software trigger register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DAC_SWTRIG1                    \ [0x00] DAC channel1 software trigger This bit is set by software to trigger the DAC in software trigger mode. Note: This bit is cleared by hardware (one dac_pclk clock cycle later) once the DAC_DHR1 register value has been loaded into the DAC_DOR1 register.
    $01 constant DAC_SWTRIG2                    \ [0x01] DAC channel2 software trigger This bit is set by software to trigger the DAC in software trigger mode. Note: This bit is cleared by hardware (one dac_pclk clock cycle later) once the DAC_DHR2 register value has been loaded into the DAC_DOR2 register. This bit is available only on dual-channel DACs. Refer to implementation.
  [then]


  [ifdef] DAC_DAC_DHR12R1_DEF
    \
    \ @brief DAC channel1 12-bit right-aligned data holding register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC1DHR                   \ [0x00 : 12] DAC channel1 12-bit right-aligned data These bits are written by software. They specify 12-bit data for DAC channel1.
  [then]


  [ifdef] DAC_DAC_DHR12L1_DEF
    \
    \ @brief DAC channel1 12-bit left aligned data holding register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $04 constant DAC_DACC1DHR                   \ [0x04 : 12] DAC channel1 12-bit left-aligned data These bits are written by software. They specify 12-bit data for DAC channel1.
  [then]


  [ifdef] DAC_DAC_DHR8R1_DEF
    \
    \ @brief DAC channel1 8-bit right aligned data holding register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC1DHR                   \ [0x00 : 8] DAC channel1 8-bit right-aligned data These bits are written by software. They specify 8-bit data for DAC channel1.
  [then]


  [ifdef] DAC_DAC_DHR12R2_DEF
    \
    \ @brief DAC channel2 12-bit right aligned data holding register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC2DHR                   \ [0x00 : 12] DAC channel2 12-bit right-aligned data These bits are written by software. They specify 12-bit data for DAC channel2.
  [then]


  [ifdef] DAC_DAC_DHR12L2_DEF
    \
    \ @brief DAC channel2 12-bit left aligned data holding register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $04 constant DAC_DACC2DHR                   \ [0x04 : 12] DAC channel2 12-bit left-aligned data These bits are written by software which specify 12-bit data for DAC channel2.
  [then]


  [ifdef] DAC_DAC_DHR8R2_DEF
    \
    \ @brief DAC channel2 8-bit right-aligned data holding register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC2DHR                   \ [0x00 : 8] DAC channel2 8-bit right-aligned data These bits are written by software which specifies 8-bit data for DAC channel2.
  [then]


  [ifdef] DAC_DAC_DHR12RD_DEF
    \
    \ @brief Dual DAC 12-bit right-aligned data holding register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC1DHR                   \ [0x00 : 12] DAC channel1 12-bit right-aligned data These bits are written by software which specifies 12-bit data for DAC channel1.
    $10 constant DAC_DACC2DHR                   \ [0x10 : 12] DAC channel2 12-bit right-aligned data These bits are written by software which specifies 12-bit data for DAC channel2.
  [then]


  [ifdef] DAC_DAC_DHR12LD_DEF
    \
    \ @brief DUAL DAC 12-bit left aligned data holding register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $04 constant DAC_DACC1DHR                   \ [0x04 : 12] DAC channel1 12-bit left-aligned data These bits are written by software which specifies 12-bit data for DAC channel1.
    $14 constant DAC_DACC2DHR                   \ [0x14 : 12] DAC channel2 12-bit left-aligned data These bits are written by software which specifies 12-bit data for DAC channel2.
  [then]


  [ifdef] DAC_DAC_DHR8RD_DEF
    \
    \ @brief DUAL DAC 8-bit right aligned data holding register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC1DHR                   \ [0x00 : 8] DAC channel1 8-bit right-aligned data These bits are written by software which specifies 8-bit data for DAC channel1.
    $08 constant DAC_DACC2DHR                   \ [0x08 : 8] DAC channel2 8-bit right-aligned data These bits are written by software which specifies 8-bit data for DAC channel2.
  [then]


  [ifdef] DAC_DAC_DOR1_DEF
    \
    \ @brief DAC channel1 data output register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC1DOR                   \ [0x00 : 12] DAC channel1 data output These bits are read-only, they contain data output for DAC channel1.
  [then]


  [ifdef] DAC_DAC_DOR2_DEF
    \
    \ @brief DAC channel2 data output register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC2DOR                   \ [0x00 : 12] DAC channel2 data output These bits are read-only, they contain data output for DAC channel2.
  [then]


  [ifdef] DAC_DAC_SR_DEF
    \
    \ @brief DAC status register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $0d constant DAC_DMAUDR1                    \ [0x0d] DAC channel1 DMA underrun flag This bit is set by hardware and cleared by software (by writing it to 1).
    $0e constant DAC_CAL_FLAG1                  \ [0x0e] DAC channel1 calibration offset status This bit is set and cleared by hardware
    $0f constant DAC_BWST1                      \ [0x0f] DAC channel1 busy writing sample time flag This bit is systematically set just after Sample and hold mode enable and is set each time the software writes the register DAC_SHSR1, It is cleared by hardware when the write operation of DAC_SHSR1 is complete. (It takes about 3 LSI periods of synchronization).
    $1d constant DAC_DMAUDR2                    \ [0x1d] DAC channel2 DMA underrun flag This bit is set by hardware and cleared by software (by writing it to 1). Note: This bit is available only on dual-channel DACs. Refer to implementation.
    $1e constant DAC_CAL_FLAG2                  \ [0x1e] DAC channel2 calibration offset status This bit is set and cleared by hardware Note: This bit is available only on dual-channel DACs. Refer to implementation.
    $1f constant DAC_BWST2                      \ [0x1f] DAC channel2 busy writing sample time flag This bit is systematically set just after Sample and hold mode enable. It is set each time the software writes the register DAC_SHSR2, It is cleared by hardware when the write operation of DAC_SHSR2 is complete. (It takes about 3 LSI periods of synchronization). Note: This bit is available only on dual-channel DACs. Refer to implementation.
  [then]


  [ifdef] DAC_DAC_CCR_DEF
    \
    \ @brief DAC calibration control register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DAC_OTRIM1                     \ [0x00 : 5] DAC channel1 offset trimming value
    $10 constant DAC_OTRIM2                     \ [0x10 : 5] DAC channel2 offset trimming value These bits are available only on dual-channel DACs. Refer to implementation.
  [then]


  [ifdef] DAC_DAC_MCR_DEF
    \
    \ @brief DAC mode control register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DAC_MODE1                      \ [0x00 : 3] DAC channel1 mode These bits can be written only when the DAC is disabled and not in the calibration mode (when bit EN1=0 and bit CEN1 =0 in the DAC_CR register). If EN1=1 or CEN1 =1 the write operation is ignored. They can be set and cleared by software to select the DAC channel1 mode: DAC channel1 in Normal mode DAC channel1 in sample & hold mode Note: This register can be modified only when EN1=0.
    $10 constant DAC_MODE2                      \ [0x10 : 3] DAC channel2 mode These bits can be written only when the DAC is disabled and not in the calibration mode (when bit EN2=0 and bit CEN2 =0 in the DAC_CR register). If EN2=1 or CEN2 =1 the write operation is ignored. They can be set and cleared by software to select the DAC channel2 mode: DAC channel2 in Normal mode DAC channel2 in Sample and hold mode Note: This register can be modified only when EN2=0. Refer to for the availability of DAC channel2.
  [then]


  [ifdef] DAC_DAC_SHSR1_DEF
    \
    \ @brief DAC Sample and Hold sample time register 1
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant DAC_TSAMPLE1                   \ [0x00 : 10] DAC channel1 sample time (only valid in Sample and hold mode) These bits can be written when the DAC channel1 is disabled or also during normal operation. in the latter case, the write can be done only when BWST1 of DAC_SR register is low, If BWST1=1, the write operation is ignored.
  [then]


  [ifdef] DAC_DAC_SHSR2_DEF
    \
    \ @brief DAC Sample and Hold sample time register 2
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant DAC_TSAMPLE2                   \ [0x00 : 10] DAC channel2 sample time (only valid in Sample and hold mode) These bits can be written when the DAC channel2 is disabled or also during normal operation. in the latter case, the write can be done only when BWST2 of DAC_SR register is low, if BWST2=1, the write operation is ignored.
  [then]


  [ifdef] DAC_DAC_SHHR_DEF
    \
    \ @brief DAC Sample and Hold hold time register
    \ Address offset: 0x48
    \ Reset value: 0x00010001
    \
    $00 constant DAC_THOLD1                     \ [0x00 : 10] DAC channel1 hold time (only valid in Sample and hold mode) Hold time= (THOLD[9:0]) x LSI clock period Note: This register can be modified only when EN1=0.
    $10 constant DAC_THOLD2                     \ [0x10 : 10] DAC channel2 hold time (only valid in Sample and hold mode). Hold time= (THOLD[9:0]) x LSI clock period Note: This register can be modified only when EN2=0. These bits are available only on dual-channel DACs. Refer to implementation.
  [then]


  [ifdef] DAC_DAC_SHRR_DEF
    \
    \ @brief DAC Sample and Hold refresh time register
    \ Address offset: 0x4C
    \ Reset value: 0x00010001
    \
    $00 constant DAC_TREFRESH1                  \ [0x00 : 8] DAC channel1 refresh time (only valid in Sample and hold mode) Refresh time= (TREFRESH[7:0]) x LSI clock period Note: This register can be modified only when EN1=0.
    $10 constant DAC_TREFRESH2                  \ [0x10 : 8] DAC channel2 refresh time (only valid in Sample and hold mode) Refresh time= (TREFRESH[7:0]) x LSI clock period Note: This register can be modified only when EN2=0. These bits are available only on dual-channel DACs. Refer to implementation.
  [then]

  \
  \ @brief DAC
  \
  $00 constant DAC_DAC_CR               \ DAC control register
  $04 constant DAC_DAC_SWTRGR           \ DAC software trigger register
  $08 constant DAC_DAC_DHR12R1          \ DAC channel1 12-bit right-aligned data holding register
  $0C constant DAC_DAC_DHR12L1          \ DAC channel1 12-bit left aligned data holding register
  $10 constant DAC_DAC_DHR8R1           \ DAC channel1 8-bit right aligned data holding register
  $14 constant DAC_DAC_DHR12R2          \ DAC channel2 12-bit right aligned data holding register
  $18 constant DAC_DAC_DHR12L2          \ DAC channel2 12-bit left aligned data holding register
  $1C constant DAC_DAC_DHR8R2           \ DAC channel2 8-bit right-aligned data holding register
  $20 constant DAC_DAC_DHR12RD          \ Dual DAC 12-bit right-aligned data holding register
  $24 constant DAC_DAC_DHR12LD          \ DUAL DAC 12-bit left aligned data holding register
  $28 constant DAC_DAC_DHR8RD           \ DUAL DAC 8-bit right aligned data holding register
  $2C constant DAC_DAC_DOR1             \ DAC channel1 data output register
  $30 constant DAC_DAC_DOR2             \ DAC channel2 data output register
  $34 constant DAC_DAC_SR               \ DAC status register
  $38 constant DAC_DAC_CCR              \ DAC calibration control register
  $3C constant DAC_DAC_MCR              \ DAC mode control register
  $40 constant DAC_DAC_SHSR1            \ DAC Sample and Hold sample time register 1
  $44 constant DAC_DAC_SHSR2            \ DAC Sample and Hold sample time register 2
  $48 constant DAC_DAC_SHHR             \ DAC Sample and Hold hold time register
  $4C constant DAC_DAC_SHRR             \ DAC Sample and Hold refresh time register

: DAC_DEF ; [then]
