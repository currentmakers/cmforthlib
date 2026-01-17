\
\ @file dac.fs
\ @brief DAC address block description
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
    $02 constant DAC_TSEL1                      \ [0x02 : 4] DAC channel1 trigger selection These bits select the external event used to trigger DAC channel1 ... Refer to the trigger selection tables in Section114.4.2: DAC pins and internal signals for details on trigger configuration and mapping. Note: Only used if bit TEN11=11 (DAC channel1 trigger enabled).
    $06 constant DAC_WAVE1                      \ [0x06 : 2] DAC channel1 noise/triangle wave generation enable These bits are set and cleared by software. 1x: Triangle wave generation enabled Only used if bit TEN11=11 (DAC channel1 trigger enabled).
    $08 constant DAC_MAMP1                      \ [0x08 : 4] DAC channel1 mask/amplitude selector
    $0c constant DAC_DMAEN1                     \ [0x0c] DAC channel1 DMA enable This bit is set and cleared by software.
    $0d constant DAC_DMAUDRIE1                  \ [0x0d] DAC channel1 DMA Underrun Interrupt enable This bit is set and cleared by software.
    $0e constant DAC_CEN1                       \ [0x0e] DAC channel1 calibration enable This bit is set and cleared by software to enable/disable DAC channel1 calibration, it can be written only if bit EN11=10 into DAC_CR (the calibration mode can be entered/exit only when the DAC channel is disabled) Otherwise, the write operation is ignored.
  [then]


  [ifdef] DAC_DAC_SWTRGR_DEF
    \
    \ @brief DAC software trigger register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DAC_SWTRIG1                    \ [0x00] DAC channel1 software trigger This bit is set by software to trigger the DAC in software trigger mode. Note: This bit is cleared by hardware (one dac_pclk clock cycle later) once the DAC_DHR1 register value has been loaded into the DAC_DOR1 register.
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


  [ifdef] DAC_DAC_DOR1_DEF
    \
    \ @brief DAC channel1 data output register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC1DOR                   \ [0x00 : 12] DAC channel1 data output These bits are read-only, they contain data output for DAC channel1.
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
  [then]


  [ifdef] DAC_DAC_CCR_DEF
    \
    \ @brief DAC calibration control register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DAC_OTRIM1                     \ [0x00 : 5] DAC channel1 offset trimming value
  [then]


  [ifdef] DAC_DAC_MCR_DEF
    \
    \ @brief DAC mode control register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DAC_MODE1                      \ [0x00 : 3] DAC channel1 mode These bits can be written only when the DAC is disabled and not in the calibration mode (when bit EN11=10 and bit CEN11=10 in the DAC_CR register). If EN11=11 or CEN11=11 the write operation is ignored. They can be set and cleared by software to select the DAC channel1 mode: DAC channel1 in Normal mode DAC channel1 in sample & hold mode Note: This register can be modified only when EN11=10.
  [then]


  [ifdef] DAC_DAC_SHSR1_DEF
    \
    \ @brief DAC channel1 sample and hold sample time register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant DAC_TSAMPLE1                   \ [0x00 : 10] DAC channel1 sample time (only valid in Sample and hold mode) These bits can be written when the DAC channel1 is disabled or also during normal operation. in the latter case, the write can be done only when BWST1 of DAC_SR register is low, If BWST11=11, the write operation is ignored.
  [then]


  [ifdef] DAC_DAC_SHHR_DEF
    \
    \ @brief DAC sample and hold time register
    \ Address offset: 0x48
    \ Reset value: 0x00010001
    \
    $00 constant DAC_THOLD1                     \ [0x00 : 10] DAC channel1 hold time (only valid in Sample and hold mode) Hold time1=1(THOLD[9:0]) x LSI clock period Note: This register can be modified only when EN11=10.
  [then]


  [ifdef] DAC_DAC_SHRR_DEF
    \
    \ @brief DAC sample and hold refresh time register
    \ Address offset: 0x4C
    \ Reset value: 0x00010001
    \
    $00 constant DAC_TREFRESH1                  \ [0x00 : 8] DAC channel1 refresh time (only valid in Sample and hold mode) Refresh time1=1(TREFRESH[7:0]) x LSI clock period Note: This register can be modified only when EN11=10.
  [then]

  \
  \ @brief DAC address block description
  \
  $00 constant DAC_DAC_CR               \ DAC control register
  $04 constant DAC_DAC_SWTRGR           \ DAC software trigger register
  $08 constant DAC_DAC_DHR12R1          \ DAC channel1 12-bit right-aligned data holding register
  $0C constant DAC_DAC_DHR12L1          \ DAC channel1 12-bit left aligned data holding register
  $10 constant DAC_DAC_DHR8R1           \ DAC channel1 8-bit right aligned data holding register
  $2C constant DAC_DAC_DOR1             \ DAC channel1 data output register
  $34 constant DAC_DAC_SR               \ DAC status register
  $38 constant DAC_DAC_CCR              \ DAC calibration control register
  $3C constant DAC_DAC_MCR              \ DAC mode control register
  $40 constant DAC_DAC_SHSR1            \ DAC channel1 sample and hold sample time register
  $48 constant DAC_DAC_SHHR             \ DAC sample and hold time register
  $4C constant DAC_DAC_SHRR             \ DAC sample and hold refresh time register

: DAC_DEF ; [then]
