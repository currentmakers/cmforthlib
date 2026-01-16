\
\ @file dac.fs
\ @brief DAC
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
$00000002 constant DAC_DAC_CR_TEN1                                  \ DAC channel1 trigger enable
$0000001c constant DAC_DAC_CR_TSEL1                                 \ DAC channel1 trigger selection These bits select the external event used to trigger DAC channel1. Note: Only used if bit TEN1 = 1 (DAC channel1 trigger enabled).
$000000c0 constant DAC_DAC_CR_WAVE1                                 \ DAC channel1 noise/triangle wave generation enable These bits are set and cleared by software. Note: Only used if bit TEN1 = 1 (DAC channel1 trigger enabled).
$00000f00 constant DAC_DAC_CR_MAMP1                                 \ DAC channel1 mask/amplitude selector These bits are written by software to select mask in wave generation mode or amplitude in triangle generation mode. = 1011: Unmask bits[11:0] of LFSR/ triangle amplitude equal to 4095
$00001000 constant DAC_DAC_CR_DMAEN1                                \ DAC channel1 DMA enable This bit is set and cleared by software.
$00002000 constant DAC_DAC_CR_DMAUDRIE1                             \ DAC channel1 DMA Underrun Interrupt enable This bit is set and cleared by software.
$00004000 constant DAC_DAC_CR_CEN1                                  \ DAC Channel 1 calibration enable This bit is set and cleared by software to enable/disable DAC channel 1 calibration, it can be written only if bit EN1=0 into DAC_CR (the calibration mode can be entered/exit only when the DAC channel is disabled) Otherwise, the write operation is ignored.
$00010000 constant DAC_DAC_CR_EN2                                   \ DAC channel2 enable This bit is set and cleared by software to enable/disable DAC channel2.
$00020000 constant DAC_DAC_CR_TEN2                                  \ DAC channel2 trigger enable
$001c0000 constant DAC_DAC_CR_TSEL2                                 \ DAC channel2 trigger selection These bits select the external event used to trigger DAC channel2 Note: Only used if bit TEN2 = 1 (DAC channel2 trigger enabled).
$00c00000 constant DAC_DAC_CR_WAVE2                                 \ DAC channel2 noise/triangle wave generation enable These bits are set/reset by software. 1x: Triangle wave generation enabled Note: Only used if bit TEN2 = 1 (DAC channel2 trigger enabled)
$0f000000 constant DAC_DAC_CR_MAMP2                                 \ DAC channel2 mask/amplitude selector These bits are written by software to select mask in wave generation mode or amplitude in triangle generation mode. = 1011: Unmask bits[11:0] of LFSR/ triangle amplitude equal to 4095
$10000000 constant DAC_DAC_CR_DMAEN2                                \ DAC channel2 DMA enable This bit is set and cleared by software.
$20000000 constant DAC_DAC_CR_DMAUDRIE2                             \ DAC channel2 DMA underrun interrupt enable This bit is set and cleared by software.
$40000000 constant DAC_DAC_CR_CEN2                                  \ DAC Channel 2 calibration enable This bit is set and cleared by software to enable/disable DAC channel 2 calibration, it can be written only if bit EN2=0 into DAC_CR (the calibration mode can be entered/exit only when the DAC channel is disabled) Otherwise, the write operation is ignored.


\
\ @brief DAC software trigger register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DAC_DAC_SWTRGR_SWTRIG1                           \ DAC channel1 software trigger This bit is set by software to trigger the DAC in software trigger mode. Note: This bit is cleared by hardware (one APB1 clock cycle later) once the DAC_DHR1 register value has been loaded into the DAC_DOR1 register.
$00000002 constant DAC_DAC_SWTRGR_SWTRIG2                           \ DAC channel2 software trigger This bit is set by software to trigger the DAC in software trigger mode. Note: This bit is cleared by hardware (one APB1 clock cycle later) once the DAC_DHR2 register value has been loaded into the DAC_DOR2 register.


\
\ @brief DAC channel1 12-bit right-aligned data holding register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000fff constant DAC_DAC_DHR12R1_DACC1DHR                         \ DAC channel1 12-bit right-aligned data These bits are written by software which specifies 12-bit data for DAC channel1.


\
\ @brief DAC channel1 12-bit left aligned data holding register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000fff0 constant DAC_DAC_DHR12L1_DACC1DHR                         \ DAC channel1 12-bit left-aligned data These bits are written by software which specifies 12-bit data for DAC channel1.


\
\ @brief DAC channel1 8-bit right aligned data holding register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant DAC_DAC_DHR8R1_DACC1DHR                          \ DAC channel1 8-bit right-aligned data These bits are written by software which specifies 8-bit data for DAC channel1.


\
\ @brief DAC channel2 12-bit right aligned data holding register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000fff constant DAC_DAC_DHR12R2_DACC2DHR                         \ DAC channel2 12-bit right-aligned data These bits are written by software which specifies 12-bit data for DAC channel2.


\
\ @brief DAC channel2 12-bit left aligned data holding register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000fff0 constant DAC_DAC_DHR12L2_DACC2DHR                         \ DAC channel2 12-bit left-aligned data These bits are written by software which specify 12-bit data for DAC channel2.


\
\ @brief DAC channel2 8-bit right-aligned data holding register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000000ff constant DAC_DAC_DHR8R2_DACC2DHR                          \ DAC channel2 8-bit right-aligned data These bits are written by software which specifies 8-bit data for DAC channel2.


\
\ @brief Dual DAC 12-bit right-aligned data holding register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000fff constant DAC_DAC_DHR12RD_DACC1DHR                         \ DAC channel1 12-bit right-aligned data These bits are written by software which specifies 12-bit data for DAC channel1.
$0fff0000 constant DAC_DAC_DHR12RD_DACC2DHR                         \ DAC channel2 12-bit right-aligned data These bits are written by software which specifies 12-bit data for DAC channel2.


\
\ @brief DUAL DAC 12-bit left aligned data holding register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000fff0 constant DAC_DAC_DHR12LD_DACC1DHR                         \ DAC channel1 12-bit left-aligned data These bits are written by software which specifies 12-bit data for DAC channel1.
$fff00000 constant DAC_DAC_DHR12LD_DACC2DHR                         \ DAC channel2 12-bit left-aligned data These bits are written by software which specifies 12-bit data for DAC channel2.


\
\ @brief DUAL DAC 8-bit right aligned data holding register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant DAC_DAC_DHR8RD_DACC1DHR                          \ DAC channel1 8-bit right-aligned data These bits are written by software which specifies 8-bit data for DAC channel1.
$0000ff00 constant DAC_DAC_DHR8RD_DACC2DHR                          \ DAC channel2 8-bit right-aligned data These bits are written by software which specifies 8-bit data for DAC channel2.


\
\ @brief DAC channel1 data output register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000fff constant DAC_DAC_DOR1_DACC1DOR                            \ DAC channel1 data output These bits are read-only, they contain data output for DAC channel1.


\
\ @brief DAC channel2 data output register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000fff constant DAC_DAC_DOR2_DACC2DOR                            \ DAC channel2 data output These bits are read-only, they contain data output for DAC channel2.


\
\ @brief DAC status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00002000 constant DAC_DAC_SR_DMAUDR1                               \ DAC channel1 DMA underrun flag This bit is set by hardware and cleared by software (by writing it to 1).
$00004000 constant DAC_DAC_SR_CAL_FLAG1                             \ DAC Channel 1 calibration offset status This bit is set and cleared by hardware
$00008000 constant DAC_DAC_SR_BWST1                                 \ DAC Channel 1 busy writing sample time flag This bit is systematically set just after Sample & Hold mode enable and is set each time the software writes the register DAC_SHSR1, It is cleared by hardware when the write operation of DAC_SHSR1 is complete. (It takes about 3LSI periods of synchronization).
$20000000 constant DAC_DAC_SR_DMAUDR2                               \ DAC channel2 DMA underrun flag This bit is set by hardware and cleared by software (by writing it to 1).
$40000000 constant DAC_DAC_SR_CAL_FLAG2                             \ DAC Channel 2 calibration offset status This bit is set and cleared by hardware
$80000000 constant DAC_DAC_SR_BWST2                                 \ DAC Channel 2 busy writing sample time flag This bit is systematically set just after Sample & Hold mode enable and is set each time the software writes the register DAC_SHSR2, It is cleared by hardware when the write operation of DAC_SHSR2 is complete. (It takes about 3 LSI periods of synchronization).


\
\ @brief DAC calibration control register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant DAC_DAC_CCR_OTRIM1                               \ DAC Channel 1 offset trimming value
$001f0000 constant DAC_DAC_CCR_OTRIM2                               \ DAC Channel 2 offset trimming value


\
\ @brief DAC mode control register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000007 constant DAC_DAC_MCR_MODE1                                \ DAC Channel 1 mode These bits can be written only when the DAC is disabled and not in the calibration mode (when bit EN1=0 and bit CEN1 =0 in the DAC_CR register). If EN1=1 or CEN1 =1 the write operation is ignored. They can be set and cleared by software to select the DAC Channel 1 mode: DAC Channel 1 in normal Mode DAC Channel 1 in sample &amp; hold mode
$00070000 constant DAC_DAC_MCR_MODE2                                \ DAC Channel 2 mode These bits can be written only when the DAC is disabled and not in the calibration mode (when bit EN2=0 and bit CEN2 =0 in the DAC_CR register). If EN2=1 or CEN2 =1 the write operation is ignored. They can be set and cleared by software to select the DAC Channel 2 mode: DAC Channel 2 in normal Mode DAC Channel 2 in sample &amp; hold mode


\
\ @brief DAC Sample and Hold sample time register 1
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000003ff constant DAC_DAC_SHSR1_TSAMPLE1                           \ DAC Channel 1 sample Time (only valid in sample &amp; hold mode) These bits can be written when the DAC channel1 is disabled or also during normal operation. in the latter case, the write can be done only when BWSTx of DAC_SR register is low, If BWSTx=1, the write operation is ignored.


\
\ @brief DAC Sample and Hold sample time register 2
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000003ff constant DAC_DAC_SHSR2_TSAMPLE2                           \ DAC Channel 2 sample Time (only valid in sample &amp; hold mode) These bits can be written when the DAC channel2 is disabled or also during normal operation. in the latter case, the write can be done only when BWSTx of DAC_SR register is low, if BWSTx=1, the write operation is ignored.


\
\ @brief DAC Sample and Hold hold time register
\ Address offset: 0x48
\ Reset value: 0x00010001
\

$000003ff constant DAC_DAC_SHHR_THOLD1                              \ DAC Channel 1 hold Time (only valid in sample &amp; hold mode) Hold time= (THOLD[9:0]) x T LSI
$03ff0000 constant DAC_DAC_SHHR_THOLD2                              \ DAC Channel 2 hold time (only valid in sample &amp; hold mode). Hold time= (THOLD[9:0]) x T LSI


\
\ @brief DAC Sample and Hold refresh time register
\ Address offset: 0x4C
\ Reset value: 0x00010001
\

$000000ff constant DAC_DAC_SHRR_TREFRESH1                           \ DAC Channel 1 refresh Time (only valid in sample &amp; hold mode) Refresh time= (TREFRESH[7:0]) x T LSI
$00ff0000 constant DAC_DAC_SHRR_TREFRESH2                           \ DAC Channel 2 refresh Time (only valid in sample &amp; hold mode) Refresh time= (TREFRESH[7:0]) x T LSI


\
\ @brief DAC
\
$40007400 constant DAC_DAC_CR     \ offset: 0x00 : DAC control register
$40007404 constant DAC_DAC_SWTRGR  \ offset: 0x04 : DAC software trigger register
$40007408 constant DAC_DAC_DHR12R1  \ offset: 0x08 : DAC channel1 12-bit right-aligned data holding register
$4000740c constant DAC_DAC_DHR12L1  \ offset: 0x0C : DAC channel1 12-bit left aligned data holding register
$40007410 constant DAC_DAC_DHR8R1  \ offset: 0x10 : DAC channel1 8-bit right aligned data holding register
$40007414 constant DAC_DAC_DHR12R2  \ offset: 0x14 : DAC channel2 12-bit right aligned data holding register
$40007418 constant DAC_DAC_DHR12L2  \ offset: 0x18 : DAC channel2 12-bit left aligned data holding register
$4000741c constant DAC_DAC_DHR8R2  \ offset: 0x1C : DAC channel2 8-bit right-aligned data holding register
$40007420 constant DAC_DAC_DHR12RD  \ offset: 0x20 : Dual DAC 12-bit right-aligned data holding register
$40007424 constant DAC_DAC_DHR12LD  \ offset: 0x24 : DUAL DAC 12-bit left aligned data holding register
$40007428 constant DAC_DAC_DHR8RD  \ offset: 0x28 : DUAL DAC 8-bit right aligned data holding register
$4000742c constant DAC_DAC_DOR1   \ offset: 0x2C : DAC channel1 data output register
$40007430 constant DAC_DAC_DOR2   \ offset: 0x30 : DAC channel2 data output register
$40007434 constant DAC_DAC_SR     \ offset: 0x34 : DAC status register
$40007438 constant DAC_DAC_CCR    \ offset: 0x38 : DAC calibration control register
$4000743c constant DAC_DAC_MCR    \ offset: 0x3C : DAC mode control register
$40007440 constant DAC_DAC_SHSR1  \ offset: 0x40 : DAC Sample and Hold sample time register 1
$40007444 constant DAC_DAC_SHSR2  \ offset: 0x44 : DAC Sample and Hold sample time register 2
$40007448 constant DAC_DAC_SHHR   \ offset: 0x48 : DAC Sample and Hold hold time register
$4000744c constant DAC_DAC_SHRR   \ offset: 0x4C : DAC Sample and Hold refresh time register

