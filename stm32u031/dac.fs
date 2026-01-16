\
\ @file dac.fs
\ @brief DAC address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DAC control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DAC_DAC_CR_EN1                                   \ DAC channel1 enable This bit is set and cleared by software to enable/disable DAC channel1.
$00000002 constant DAC_DAC_CR_TEN1                                  \ DAC channel1 trigger enable This bit is set and cleared by software to enable/disable DAC channel1 trigger. Note: When software trigger is selected, the transfer from the DAC_DHR1 register to the DAC_DOR1 register takes only one dac_pclk clock cycle.
$0000003c constant DAC_DAC_CR_TSEL1                                 \ DAC channel1 trigger selection These bits select the external event used to trigger DAC channel1 ... Refer to the trigger selection tables in Section114.4.2: DAC pins and internal signals for details on trigger configuration and mapping. Note: Only used if bit TEN11=11 (DAC channel1 trigger enabled).
$000000c0 constant DAC_DAC_CR_WAVE1                                 \ DAC channel1 noise/triangle wave generation enable These bits are set and cleared by software. 1x: Triangle wave generation enabled Only used if bit TEN11=11 (DAC channel1 trigger enabled).
$00000f00 constant DAC_DAC_CR_MAMP1                                 \ DAC channel1 mask/amplitude selector
$00001000 constant DAC_DAC_CR_DMAEN1                                \ DAC channel1 DMA enable This bit is set and cleared by software.
$00002000 constant DAC_DAC_CR_DMAUDRIE1                             \ DAC channel1 DMA Underrun Interrupt enable This bit is set and cleared by software.
$00004000 constant DAC_DAC_CR_CEN1                                  \ DAC channel1 calibration enable This bit is set and cleared by software to enable/disable DAC channel1 calibration, it can be written only if bit EN11=10 into DAC_CR (the calibration mode can be entered/exit only when the DAC channel is disabled) Otherwise, the write operation is ignored.


\
\ @brief DAC software trigger register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DAC_DAC_SWTRGR_SWTRIG1                           \ DAC channel1 software trigger This bit is set by software to trigger the DAC in software trigger mode. Note: This bit is cleared by hardware (one dac_pclk clock cycle later) once the DAC_DHR1 register value has been loaded into the DAC_DOR1 register.


\
\ @brief DAC channel1 12-bit right-aligned data holding register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000fff constant DAC_DAC_DHR12R1_DACC1DHR                         \ DAC channel1 12-bit right-aligned data These bits are written by software. They specify 12-bit data for DAC channel1.


\
\ @brief DAC channel1 12-bit left aligned data holding register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000fff0 constant DAC_DAC_DHR12L1_DACC1DHR                         \ DAC channel1 12-bit left-aligned data These bits are written by software. They specify 12-bit data for DAC channel1.


\
\ @brief DAC channel1 8-bit right aligned data holding register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant DAC_DAC_DHR8R1_DACC1DHR                          \ DAC channel1 8-bit right-aligned data These bits are written by software. They specify 8-bit data for DAC channel1.


\
\ @brief DAC channel1 data output register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000fff constant DAC_DAC_DOR1_DACC1DOR                            \ DAC channel1 data output These bits are read-only, they contain data output for DAC channel1.


\
\ @brief DAC status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00002000 constant DAC_DAC_SR_DMAUDR1                               \ DAC channel1 DMA underrun flag This bit is set by hardware and cleared by software (by writing it to 1).
$00004000 constant DAC_DAC_SR_CAL_FLAG1                             \ DAC channel1 calibration offset status This bit is set and cleared by hardware
$00008000 constant DAC_DAC_SR_BWST1                                 \ DAC channel1 busy writing sample time flag This bit is systematically set just after Sample and hold mode enable and is set each time the software writes the register DAC_SHSR1, It is cleared by hardware when the write operation of DAC_SHSR1 is complete. (It takes about 3 LSI periods of synchronization).


\
\ @brief DAC calibration control register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant DAC_DAC_CCR_OTRIM1                               \ DAC channel1 offset trimming value


\
\ @brief DAC mode control register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000007 constant DAC_DAC_MCR_MODE1                                \ DAC channel1 mode These bits can be written only when the DAC is disabled and not in the calibration mode (when bit EN11=10 and bit CEN11=10 in the DAC_CR register). If EN11=11 or CEN11=11 the write operation is ignored. They can be set and cleared by software to select the DAC channel1 mode: DAC channel1 in Normal mode DAC channel1 in sample & hold mode Note: This register can be modified only when EN11=10.


\
\ @brief DAC channel1 sample and hold sample time register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000003ff constant DAC_DAC_SHSR1_TSAMPLE1                           \ DAC channel1 sample time (only valid in Sample and hold mode) These bits can be written when the DAC channel1 is disabled or also during normal operation. in the latter case, the write can be done only when BWST1 of DAC_SR register is low, If BWST11=11, the write operation is ignored.


\
\ @brief DAC sample and hold time register
\ Address offset: 0x48
\ Reset value: 0x00010001
\

$000003ff constant DAC_DAC_SHHR_THOLD1                              \ DAC channel1 hold time (only valid in Sample and hold mode) Hold time1=1(THOLD[9:0]) x LSI clock period Note: This register can be modified only when EN11=10.


\
\ @brief DAC sample and hold refresh time register
\ Address offset: 0x4C
\ Reset value: 0x00010001
\

$000000ff constant DAC_DAC_SHRR_TREFRESH1                           \ DAC channel1 refresh time (only valid in Sample and hold mode) Refresh time1=1(TREFRESH[7:0]) x LSI clock period Note: This register can be modified only when EN11=10.


\
\ @brief DAC address block description
\
$40007400 constant DAC_DAC_CR     \ offset: 0x00 : DAC control register
$40007404 constant DAC_DAC_SWTRGR  \ offset: 0x04 : DAC software trigger register
$40007408 constant DAC_DAC_DHR12R1  \ offset: 0x08 : DAC channel1 12-bit right-aligned data holding register
$4000740c constant DAC_DAC_DHR12L1  \ offset: 0x0C : DAC channel1 12-bit left aligned data holding register
$40007410 constant DAC_DAC_DHR8R1  \ offset: 0x10 : DAC channel1 8-bit right aligned data holding register
$4000742c constant DAC_DAC_DOR1   \ offset: 0x2C : DAC channel1 data output register
$40007434 constant DAC_DAC_SR     \ offset: 0x34 : DAC status register
$40007438 constant DAC_DAC_CCR    \ offset: 0x38 : DAC calibration control register
$4000743c constant DAC_DAC_MCR    \ offset: 0x3C : DAC mode control register
$40007440 constant DAC_DAC_SHSR1  \ offset: 0x40 : DAC channel1 sample and hold sample time register
$40007448 constant DAC_DAC_SHHR   \ offset: 0x48 : DAC sample and hold time register
$4000744c constant DAC_DAC_SHRR   \ offset: 0x4C : DAC sample and hold refresh time register

