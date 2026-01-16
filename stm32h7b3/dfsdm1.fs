\
\ @file dfsdm1.fs
\ @brief Digital filter for sigma delta         modulators
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DFSDM channel 0 configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant DFSDM1_DFSDM_CH0CFGR1_SITP                       \ Serial interface type for channel y This value can only be modified when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000000c constant DFSDM1_DFSDM_CH0CFGR1_SPICKSEL                   \ SPI clock select for channel y 2: clock coming from internal CKOUT - sampling point on each second CKOUT falling edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input rising edge). 3: clock coming from internal CKOUT output - sampling point on each second CKOUT rising edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input falling edge). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00000020 constant DFSDM1_DFSDM_CH0CFGR1_SCDEN                      \ Short-circuit detector enable on channel y
$00000040 constant DFSDM1_DFSDM_CH0CFGR1_CKABEN                     \ Clock absence detector enable on channel y
$00000080 constant DFSDM1_DFSDM_CH0CFGR1_CHEN                       \ Channel y enable If channel y is enabled, then serial data receiving is started according to the given channel setting.
$00000100 constant DFSDM1_DFSDM_CH0CFGR1_CHINSEL                    \ Channel inputs selection This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00003000 constant DFSDM1_DFSDM_CH0CFGR1_DATMPX                     \ Input data multiplexer for channel y 2: Data to channel y are taken from internal DFSDM_CHyDATINR register by direct CPU/DMA write. There can be written one or two 16-bit data samples according DATPACK[1:0] bit field setting. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000c000 constant DFSDM1_DFSDM_CH0CFGR1_DATPACK                    \ Data packing mode in DFSDM_CHyDATINR register. first sample in INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y) To empty DFSDM_CHyDATINR register, two samples must be read by the digital filter from channel y (INDAT0[15:0] part is read as first sample and then INDAT1[15:0] part is read as next sample). 2: Dual: input data in DFSDM_CHyDATINR register are stored as two samples: first sample INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y+1) To empty DFSDM_CHyDATINR register first sample must be read by the digital filter from channel y and second sample must be read by another digital filter from channel y+1. Dual mode is available only on even channel numbers (y = 0, 2, 4, 6), for odd channel numbers (y = 1, 3, 5, 7) DFSDM_CHyDATINR is write protected. If an even channel is set to dual mode then the following odd channel must be set into standard mode (DATPACK[1:0]=0) for correct cooperation with even channel. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00ff0000 constant DFSDM1_DFSDM_CH0CFGR1_CKOUTDIV                   \ Output serial clock divider Â 256 (Divider = CKOUTDIV+1). CKOUTDIV also defines the threshold for a clock absence detection. This value can only be modified when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). If DFSDMEN=0 (in DFSDM_CH0CFGR1 register) then CKOUT signal is set to low state (setting is performed one DFSDM clock cycle after DFSDMEN=0). Note: CKOUTDIV is present only in DFSDM_CH0CFGR1 register (channel y=0) 1- 255: Defines the division of system clock for the serial clock output for CKOUT signal in range 2Â -
$40000000 constant DFSDM1_DFSDM_CH0CFGR1_CKOUTSRC                   \ Output serial clock source selection This value can be modified only when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). Note: CKOUTSRC is present only in DFSDM_CH0CFGR1 register (channel y=0)
$80000000 constant DFSDM1_DFSDM_CH0CFGR1_DFSDMEN                    \ Global enable for DFSDM interface If DFSDM interface is enabled, then it is started to operate according to enabled y channels and enabled x filters settings (CHEN bit in DFSDM_CHyCFGR1 and DFEN bit in DFSDM_FLTxCR1). Data cleared by setting DFSDMEN=0: all registers DFSDM_FLTxISR are set to reset state (x = 0..7) all registers DFSDM_FLTxAWSR are set to reset state (x = 0..7) Note: DFSDMEN is present only in DFSDM_CH0CFGR1 register (channel y=0)


\
\ @brief DFSDM channel 0 configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM1_DFSDM_CH0CFGR2_DTRBS                      \ Data right bit-shift for channel y will be performed to have final results. Bit-shift is performed before offset correction. The data shift is rounding the result to nearest integer value. The sign of shifted result is maintained (to have valid 24-bit signed format of result data). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). 0-31: Defines the shift of the data result coming from the integrator - how many bit shifts to the right
$ffffff00 constant DFSDM1_DFSDM_CH0CFGR2_OFFSET                     \ 24-bit calibration offset for channel y For channel y, OFFSET is applied to the results of each conversion from this channel. This value is set by software.


\
\ @brief DFSDM channel 0 analog watchdog and short-circuit detector register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_CH0AWSCDR_SCDT                      \ short-circuit detector threshold for channel y These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given channel.
$0000f000 constant DFSDM1_DFSDM_CH0AWSCDR_BKSCD                     \ Break signal assignment for short-circuit detector on channel y BKSCD[i] = 0: Break i signal not assigned to short-circuit detector on channel y BKSCD[i] = 1: Break i signal assigned to short-circuit detector on channel y
$001f0000 constant DFSDM1_DFSDM_CH0AWSCDR_AWFOSR                    \ Analog watchdog filter oversampling ratio (decimation rate) on channel y also the decimation ratio of the analog data rate. This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). Note: If AWFOSR = 0 then the filter has no effect (filter bypass). 0 - 31: Defines the length of the Sinc type filter in the range 1 - 32 (AWFOSR + 1). This number is
$00c00000 constant DFSDM1_DFSDM_CH0AWSCDR_AWFORD                    \ Analog watchdog Sinc filter order on channel y 2: Sinc2 filter type 3: Sinc3 filter type Sincx filter type transfer function: FastSinc filter type transfer function: This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).


\
\ @brief DFSDM channel 0 watchdog filter data register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH0WDATR_WDATA                      \ Input channel y watchdog data Data converted by the analog watchdog filter for input channel y. This data is continuously converted (no trigger) for this channel, with a limited resolution (OSR=1..32/sinc order = 1..3).


\
\ @brief DFSDM channel 0 data input register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH0DATINR_INDAT0                    \ Input data for channel y Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) Channel y data sample is stored into INDAT0[15:0]. If DATPACK[1:0]=1 (interleaved mode) First channel y data sample is stored into INDAT0[15:0]. Second channel y data sample is stored into INDAT1[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: Channel y data sample is stored into INDAT0[15:0]. For odd y channels: INDAT0[15:0] is write protected. See for more details. INDAT0[15:0] is in the16-bit signed format.
$ffff0000 constant DFSDM1_DFSDM_CH0DATINR_INDAT1                    \ Input data for channel y or channel y+1 Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) INDAT0[15:0] is write protected (not used for input sample). If DATPACK[1:0]=1 (interleaved mode) Second channel y data sample is stored into INDAT1[15:0]. First channel y data sample is stored into INDAT0[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: sample in INDAT1[15:0] is automatically copied into INDAT0[15:0] of channel (y+1). For odd y channels: INDAT1[15:0] is write protected. See for more details. INDAT0[15:1] is in the16-bit signed format.


\
\ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000003f constant DFSDM1_DFSDM_CH0DLYR_PLSSKP                      \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied


\
\ @brief DFSDM channel 1 configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000003 constant DFSDM1_DFSDM_CH1CFGR1_SITP                       \ Serial interface type for channel y This value can only be modified when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000000c constant DFSDM1_DFSDM_CH1CFGR1_SPICKSEL                   \ SPI clock select for channel y 2: clock coming from internal CKOUT - sampling point on each second CKOUT falling edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input rising edge). 3: clock coming from internal CKOUT output - sampling point on each second CKOUT rising edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input falling edge). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00000020 constant DFSDM1_DFSDM_CH1CFGR1_SCDEN                      \ Short-circuit detector enable on channel y
$00000040 constant DFSDM1_DFSDM_CH1CFGR1_CKABEN                     \ Clock absence detector enable on channel y
$00000080 constant DFSDM1_DFSDM_CH1CFGR1_CHEN                       \ Channel y enable If channel y is enabled, then serial data receiving is started according to the given channel setting.
$00000100 constant DFSDM1_DFSDM_CH1CFGR1_CHINSEL                    \ Channel inputs selection This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00003000 constant DFSDM1_DFSDM_CH1CFGR1_DATMPX                     \ Input data multiplexer for channel y 2: Data to channel y are taken from internal DFSDM_CHyDATINR register by direct CPU/DMA write. There can be written one or two 16-bit data samples according DATPACK[1:0] bit field setting. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000c000 constant DFSDM1_DFSDM_CH1CFGR1_DATPACK                    \ Data packing mode in DFSDM_CHyDATINR register. first sample in INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y) To empty DFSDM_CHyDATINR register, two samples must be read by the digital filter from channel y (INDAT0[15:0] part is read as first sample and then INDAT1[15:0] part is read as next sample). 2: Dual: input data in DFSDM_CHyDATINR register are stored as two samples: first sample INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y+1) To empty DFSDM_CHyDATINR register first sample must be read by the digital filter from channel y and second sample must be read by another digital filter from channel y+1. Dual mode is available only on even channel numbers (y = 0, 2, 4, 6), for odd channel numbers (y = 1, 3, 5, 7) DFSDM_CHyDATINR is write protected. If an even channel is set to dual mode then the following odd channel must be set into standard mode (DATPACK[1:0]=0) for correct cooperation with even channel. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00ff0000 constant DFSDM1_DFSDM_CH1CFGR1_CKOUTDIV                   \ Output serial clock divider Â 256 (Divider = CKOUTDIV+1). CKOUTDIV also defines the threshold for a clock absence detection. This value can only be modified when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). If DFSDMEN=0 (in DFSDM_CH0CFGR1 register) then CKOUT signal is set to low state (setting is performed one DFSDM clock cycle after DFSDMEN=0). Note: CKOUTDIV is present only in DFSDM_CH0CFGR1 register (channel y=0) 1- 255: Defines the division of system clock for the serial clock output for CKOUT signal in range 2Â -
$40000000 constant DFSDM1_DFSDM_CH1CFGR1_CKOUTSRC                   \ Output serial clock source selection This value can be modified only when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). Note: CKOUTSRC is present only in DFSDM_CH0CFGR1 register (channel y=0)
$80000000 constant DFSDM1_DFSDM_CH1CFGR1_DFSDMEN                    \ Global enable for DFSDM interface If DFSDM interface is enabled, then it is started to operate according to enabled y channels and enabled x filters settings (CHEN bit in DFSDM_CHyCFGR1 and DFEN bit in DFSDM_FLTxCR1). Data cleared by setting DFSDMEN=0: all registers DFSDM_FLTxISR are set to reset state (x = 0..7) all registers DFSDM_FLTxAWSR are set to reset state (x = 0..7) Note: DFSDMEN is present only in DFSDM_CH0CFGR1 register (channel y=0)


\
\ @brief DFSDM channel 1 configuration register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM1_DFSDM_CH1CFGR2_DTRBS                      \ Data right bit-shift for channel y will be performed to have final results. Bit-shift is performed before offset correction. The data shift is rounding the result to nearest integer value. The sign of shifted result is maintained (to have valid 24-bit signed format of result data). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). 0-31: Defines the shift of the data result coming from the integrator - how many bit shifts to the right
$ffffff00 constant DFSDM1_DFSDM_CH1CFGR2_OFFSET                     \ 24-bit calibration offset for channel y For channel y, OFFSET is applied to the results of each conversion from this channel. This value is set by software.


\
\ @brief DFSDM channel 1 analog watchdog and short-circuit detector register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_CH1AWSCDR_SCDT                      \ short-circuit detector threshold for channel y These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given channel.
$0000f000 constant DFSDM1_DFSDM_CH1AWSCDR_BKSCD                     \ Break signal assignment for short-circuit detector on channel y BKSCD[i] = 0: Break i signal not assigned to short-circuit detector on channel y BKSCD[i] = 1: Break i signal assigned to short-circuit detector on channel y
$001f0000 constant DFSDM1_DFSDM_CH1AWSCDR_AWFOSR                    \ Analog watchdog filter oversampling ratio (decimation rate) on channel y also the decimation ratio of the analog data rate. This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). Note: If AWFOSR = 0 then the filter has no effect (filter bypass). 0 - 31: Defines the length of the Sinc type filter in the range 1 - 32 (AWFOSR + 1). This number is
$00c00000 constant DFSDM1_DFSDM_CH1AWSCDR_AWFORD                    \ Analog watchdog Sinc filter order on channel y 2: Sinc2 filter type 3: Sinc3 filter type Sincx filter type transfer function: FastSinc filter type transfer function: This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).


\
\ @brief DFSDM channel 1 watchdog filter data register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH1WDATR_WDATA                      \ Input channel y watchdog data Data converted by the analog watchdog filter for input channel y. This data is continuously converted (no trigger) for this channel, with a limited resolution (OSR=1..32/sinc order = 1..3).


\
\ @brief DFSDM channel 1 data input register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH1DATINR_INDAT0                    \ Input data for channel y Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) Channel y data sample is stored into INDAT0[15:0]. If DATPACK[1:0]=1 (interleaved mode) First channel y data sample is stored into INDAT0[15:0]. Second channel y data sample is stored into INDAT1[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: Channel y data sample is stored into INDAT0[15:0]. For odd y channels: INDAT0[15:0] is write protected. See for more details. INDAT0[15:0] is in the16-bit signed format.
$ffff0000 constant DFSDM1_DFSDM_CH1DATINR_INDAT1                    \ Input data for channel y or channel y+1 Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) INDAT0[15:0] is write protected (not used for input sample). If DATPACK[1:0]=1 (interleaved mode) Second channel y data sample is stored into INDAT1[15:0]. First channel y data sample is stored into INDAT0[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: sample in INDAT1[15:0] is automatically copied into INDAT0[15:0] of channel (y+1). For odd y channels: INDAT1[15:0] is write protected. See for more details. INDAT0[15:1] is in the16-bit signed format.


\
\ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000003f constant DFSDM1_DFSDM_CH1DLYR_PLSSKP                      \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied


\
\ @brief DFSDM channel 2 configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000003 constant DFSDM1_DFSDM_CH2CFGR1_SITP                       \ Serial interface type for channel y This value can only be modified when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000000c constant DFSDM1_DFSDM_CH2CFGR1_SPICKSEL                   \ SPI clock select for channel y 2: clock coming from internal CKOUT - sampling point on each second CKOUT falling edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input rising edge). 3: clock coming from internal CKOUT output - sampling point on each second CKOUT rising edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input falling edge). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00000020 constant DFSDM1_DFSDM_CH2CFGR1_SCDEN                      \ Short-circuit detector enable on channel y
$00000040 constant DFSDM1_DFSDM_CH2CFGR1_CKABEN                     \ Clock absence detector enable on channel y
$00000080 constant DFSDM1_DFSDM_CH2CFGR1_CHEN                       \ Channel y enable If channel y is enabled, then serial data receiving is started according to the given channel setting.
$00000100 constant DFSDM1_DFSDM_CH2CFGR1_CHINSEL                    \ Channel inputs selection This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00003000 constant DFSDM1_DFSDM_CH2CFGR1_DATMPX                     \ Input data multiplexer for channel y 2: Data to channel y are taken from internal DFSDM_CHyDATINR register by direct CPU/DMA write. There can be written one or two 16-bit data samples according DATPACK[1:0] bit field setting. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000c000 constant DFSDM1_DFSDM_CH2CFGR1_DATPACK                    \ Data packing mode in DFSDM_CHyDATINR register. first sample in INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y) To empty DFSDM_CHyDATINR register, two samples must be read by the digital filter from channel y (INDAT0[15:0] part is read as first sample and then INDAT1[15:0] part is read as next sample). 2: Dual: input data in DFSDM_CHyDATINR register are stored as two samples: first sample INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y+1) To empty DFSDM_CHyDATINR register first sample must be read by the digital filter from channel y and second sample must be read by another digital filter from channel y+1. Dual mode is available only on even channel numbers (y = 0, 2, 4, 6), for odd channel numbers (y = 1, 3, 5, 7) DFSDM_CHyDATINR is write protected. If an even channel is set to dual mode then the following odd channel must be set into standard mode (DATPACK[1:0]=0) for correct cooperation with even channel. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00ff0000 constant DFSDM1_DFSDM_CH2CFGR1_CKOUTDIV                   \ Output serial clock divider Â 256 (Divider = CKOUTDIV+1). CKOUTDIV also defines the threshold for a clock absence detection. This value can only be modified when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). If DFSDMEN=0 (in DFSDM_CH0CFGR1 register) then CKOUT signal is set to low state (setting is performed one DFSDM clock cycle after DFSDMEN=0). Note: CKOUTDIV is present only in DFSDM_CH0CFGR1 register (channel y=0) 1- 255: Defines the division of system clock for the serial clock output for CKOUT signal in range 2Â -
$40000000 constant DFSDM1_DFSDM_CH2CFGR1_CKOUTSRC                   \ Output serial clock source selection This value can be modified only when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). Note: CKOUTSRC is present only in DFSDM_CH0CFGR1 register (channel y=0)
$80000000 constant DFSDM1_DFSDM_CH2CFGR1_DFSDMEN                    \ Global enable for DFSDM interface If DFSDM interface is enabled, then it is started to operate according to enabled y channels and enabled x filters settings (CHEN bit in DFSDM_CHyCFGR1 and DFEN bit in DFSDM_FLTxCR1). Data cleared by setting DFSDMEN=0: all registers DFSDM_FLTxISR are set to reset state (x = 0..7) all registers DFSDM_FLTxAWSR are set to reset state (x = 0..7) Note: DFSDMEN is present only in DFSDM_CH0CFGR1 register (channel y=0)


\
\ @brief DFSDM channel 2 configuration register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM1_DFSDM_CH2CFGR2_DTRBS                      \ Data right bit-shift for channel y will be performed to have final results. Bit-shift is performed before offset correction. The data shift is rounding the result to nearest integer value. The sign of shifted result is maintained (to have valid 24-bit signed format of result data). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). 0-31: Defines the shift of the data result coming from the integrator - how many bit shifts to the right
$ffffff00 constant DFSDM1_DFSDM_CH2CFGR2_OFFSET                     \ 24-bit calibration offset for channel y For channel y, OFFSET is applied to the results of each conversion from this channel. This value is set by software.


\
\ @brief DFSDM channel 2 analog watchdog and short-circuit detector register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_CH2AWSCDR_SCDT                      \ short-circuit detector threshold for channel y These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given channel.
$0000f000 constant DFSDM1_DFSDM_CH2AWSCDR_BKSCD                     \ Break signal assignment for short-circuit detector on channel y BKSCD[i] = 0: Break i signal not assigned to short-circuit detector on channel y BKSCD[i] = 1: Break i signal assigned to short-circuit detector on channel y
$001f0000 constant DFSDM1_DFSDM_CH2AWSCDR_AWFOSR                    \ Analog watchdog filter oversampling ratio (decimation rate) on channel y also the decimation ratio of the analog data rate. This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). Note: If AWFOSR = 0 then the filter has no effect (filter bypass). 0 - 31: Defines the length of the Sinc type filter in the range 1 - 32 (AWFOSR + 1). This number is
$00c00000 constant DFSDM1_DFSDM_CH2AWSCDR_AWFORD                    \ Analog watchdog Sinc filter order on channel y 2: Sinc2 filter type 3: Sinc3 filter type Sincx filter type transfer function: FastSinc filter type transfer function: This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).


\
\ @brief DFSDM channel 2 watchdog filter data register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH2WDATR_WDATA                      \ Input channel y watchdog data Data converted by the analog watchdog filter for input channel y. This data is continuously converted (no trigger) for this channel, with a limited resolution (OSR=1..32/sinc order = 1..3).


\
\ @brief DFSDM channel 2 data input register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH2DATINR_INDAT0                    \ Input data for channel y Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) Channel y data sample is stored into INDAT0[15:0]. If DATPACK[1:0]=1 (interleaved mode) First channel y data sample is stored into INDAT0[15:0]. Second channel y data sample is stored into INDAT1[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: Channel y data sample is stored into INDAT0[15:0]. For odd y channels: INDAT0[15:0] is write protected. See for more details. INDAT0[15:0] is in the16-bit signed format.
$ffff0000 constant DFSDM1_DFSDM_CH2DATINR_INDAT1                    \ Input data for channel y or channel y+1 Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) INDAT0[15:0] is write protected (not used for input sample). If DATPACK[1:0]=1 (interleaved mode) Second channel y data sample is stored into INDAT1[15:0]. First channel y data sample is stored into INDAT0[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: sample in INDAT1[15:0] is automatically copied into INDAT0[15:0] of channel (y+1). For odd y channels: INDAT1[15:0] is write protected. See for more details. INDAT0[15:1] is in the16-bit signed format.


\
\ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$0000003f constant DFSDM1_DFSDM_CH2DLYR_PLSSKP                      \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied


\
\ @brief DFSDM channel 3 configuration register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000003 constant DFSDM1_DFSDM_CH3CFGR1_SITP                       \ Serial interface type for channel y This value can only be modified when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000000c constant DFSDM1_DFSDM_CH3CFGR1_SPICKSEL                   \ SPI clock select for channel y 2: clock coming from internal CKOUT - sampling point on each second CKOUT falling edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input rising edge). 3: clock coming from internal CKOUT output - sampling point on each second CKOUT rising edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input falling edge). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00000020 constant DFSDM1_DFSDM_CH3CFGR1_SCDEN                      \ Short-circuit detector enable on channel y
$00000040 constant DFSDM1_DFSDM_CH3CFGR1_CKABEN                     \ Clock absence detector enable on channel y
$00000080 constant DFSDM1_DFSDM_CH3CFGR1_CHEN                       \ Channel y enable If channel y is enabled, then serial data receiving is started according to the given channel setting.
$00000100 constant DFSDM1_DFSDM_CH3CFGR1_CHINSEL                    \ Channel inputs selection This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00003000 constant DFSDM1_DFSDM_CH3CFGR1_DATMPX                     \ Input data multiplexer for channel y 2: Data to channel y are taken from internal DFSDM_CHyDATINR register by direct CPU/DMA write. There can be written one or two 16-bit data samples according DATPACK[1:0] bit field setting. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000c000 constant DFSDM1_DFSDM_CH3CFGR1_DATPACK                    \ Data packing mode in DFSDM_CHyDATINR register. first sample in INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y) To empty DFSDM_CHyDATINR register, two samples must be read by the digital filter from channel y (INDAT0[15:0] part is read as first sample and then INDAT1[15:0] part is read as next sample). 2: Dual: input data in DFSDM_CHyDATINR register are stored as two samples: first sample INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y+1) To empty DFSDM_CHyDATINR register first sample must be read by the digital filter from channel y and second sample must be read by another digital filter from channel y+1. Dual mode is available only on even channel numbers (y = 0, 2, 4, 6), for odd channel numbers (y = 1, 3, 5, 7) DFSDM_CHyDATINR is write protected. If an even channel is set to dual mode then the following odd channel must be set into standard mode (DATPACK[1:0]=0) for correct cooperation with even channel. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00ff0000 constant DFSDM1_DFSDM_CH3CFGR1_CKOUTDIV                   \ Output serial clock divider Â 256 (Divider = CKOUTDIV+1). CKOUTDIV also defines the threshold for a clock absence detection. This value can only be modified when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). If DFSDMEN=0 (in DFSDM_CH0CFGR1 register) then CKOUT signal is set to low state (setting is performed one DFSDM clock cycle after DFSDMEN=0). Note: CKOUTDIV is present only in DFSDM_CH0CFGR1 register (channel y=0) 1- 255: Defines the division of system clock for the serial clock output for CKOUT signal in range 2Â -
$40000000 constant DFSDM1_DFSDM_CH3CFGR1_CKOUTSRC                   \ Output serial clock source selection This value can be modified only when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). Note: CKOUTSRC is present only in DFSDM_CH0CFGR1 register (channel y=0)
$80000000 constant DFSDM1_DFSDM_CH3CFGR1_DFSDMEN                    \ Global enable for DFSDM interface If DFSDM interface is enabled, then it is started to operate according to enabled y channels and enabled x filters settings (CHEN bit in DFSDM_CHyCFGR1 and DFEN bit in DFSDM_FLTxCR1). Data cleared by setting DFSDMEN=0: all registers DFSDM_FLTxISR are set to reset state (x = 0..7) all registers DFSDM_FLTxAWSR are set to reset state (x = 0..7) Note: DFSDMEN is present only in DFSDM_CH0CFGR1 register (channel y=0)


\
\ @brief DFSDM channel 3 configuration register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM1_DFSDM_CH3CFGR2_DTRBS                      \ Data right bit-shift for channel y will be performed to have final results. Bit-shift is performed before offset correction. The data shift is rounding the result to nearest integer value. The sign of shifted result is maintained (to have valid 24-bit signed format of result data). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). 0-31: Defines the shift of the data result coming from the integrator - how many bit shifts to the right
$ffffff00 constant DFSDM1_DFSDM_CH3CFGR2_OFFSET                     \ 24-bit calibration offset for channel y For channel y, OFFSET is applied to the results of each conversion from this channel. This value is set by software.


\
\ @brief DFSDM channel 3 analog watchdog and short-circuit detector register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_CH3AWSCDR_SCDT                      \ short-circuit detector threshold for channel y These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given channel.
$0000f000 constant DFSDM1_DFSDM_CH3AWSCDR_BKSCD                     \ Break signal assignment for short-circuit detector on channel y BKSCD[i] = 0: Break i signal not assigned to short-circuit detector on channel y BKSCD[i] = 1: Break i signal assigned to short-circuit detector on channel y
$001f0000 constant DFSDM1_DFSDM_CH3AWSCDR_AWFOSR                    \ Analog watchdog filter oversampling ratio (decimation rate) on channel y also the decimation ratio of the analog data rate. This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). Note: If AWFOSR = 0 then the filter has no effect (filter bypass). 0 - 31: Defines the length of the Sinc type filter in the range 1 - 32 (AWFOSR + 1). This number is
$00c00000 constant DFSDM1_DFSDM_CH3AWSCDR_AWFORD                    \ Analog watchdog Sinc filter order on channel y 2: Sinc2 filter type 3: Sinc3 filter type Sincx filter type transfer function: FastSinc filter type transfer function: This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).


\
\ @brief DFSDM channel 3 watchdog filter data register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH3WDATR_WDATA                      \ Input channel y watchdog data Data converted by the analog watchdog filter for input channel y. This data is continuously converted (no trigger) for this channel, with a limited resolution (OSR=1..32/sinc order = 1..3).


\
\ @brief DFSDM channel 3 data input register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH3DATINR_INDAT0                    \ Input data for channel y Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) Channel y data sample is stored into INDAT0[15:0]. If DATPACK[1:0]=1 (interleaved mode) First channel y data sample is stored into INDAT0[15:0]. Second channel y data sample is stored into INDAT1[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: Channel y data sample is stored into INDAT0[15:0]. For odd y channels: INDAT0[15:0] is write protected. See for more details. INDAT0[15:0] is in the16-bit signed format.
$ffff0000 constant DFSDM1_DFSDM_CH3DATINR_INDAT1                    \ Input data for channel y or channel y+1 Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) INDAT0[15:0] is write protected (not used for input sample). If DATPACK[1:0]=1 (interleaved mode) Second channel y data sample is stored into INDAT1[15:0]. First channel y data sample is stored into INDAT0[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: sample in INDAT1[15:0] is automatically copied into INDAT0[15:0] of channel (y+1). For odd y channels: INDAT1[15:0] is write protected. See for more details. INDAT0[15:1] is in the16-bit signed format.


\
\ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$0000003f constant DFSDM1_DFSDM_CH3DLYR_PLSSKP                      \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied


\
\ @brief DFSDM channel 4 configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000003 constant DFSDM1_DFSDM_CH4CFGR1_SITP                       \ Serial interface type for channel y This value can only be modified when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000000c constant DFSDM1_DFSDM_CH4CFGR1_SPICKSEL                   \ SPI clock select for channel y 2: clock coming from internal CKOUT - sampling point on each second CKOUT falling edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input rising edge). 3: clock coming from internal CKOUT output - sampling point on each second CKOUT rising edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input falling edge). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00000020 constant DFSDM1_DFSDM_CH4CFGR1_SCDEN                      \ Short-circuit detector enable on channel y
$00000040 constant DFSDM1_DFSDM_CH4CFGR1_CKABEN                     \ Clock absence detector enable on channel y
$00000080 constant DFSDM1_DFSDM_CH4CFGR1_CHEN                       \ Channel y enable If channel y is enabled, then serial data receiving is started according to the given channel setting.
$00000100 constant DFSDM1_DFSDM_CH4CFGR1_CHINSEL                    \ Channel inputs selection This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00003000 constant DFSDM1_DFSDM_CH4CFGR1_DATMPX                     \ Input data multiplexer for channel y 2: Data to channel y are taken from internal DFSDM_CHyDATINR register by direct CPU/DMA write. There can be written one or two 16-bit data samples according DATPACK[1:0] bit field setting. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000c000 constant DFSDM1_DFSDM_CH4CFGR1_DATPACK                    \ Data packing mode in DFSDM_CHyDATINR register. first sample in INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y) To empty DFSDM_CHyDATINR register, two samples must be read by the digital filter from channel y (INDAT0[15:0] part is read as first sample and then INDAT1[15:0] part is read as next sample). 2: Dual: input data in DFSDM_CHyDATINR register are stored as two samples: first sample INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y+1) To empty DFSDM_CHyDATINR register first sample must be read by the digital filter from channel y and second sample must be read by another digital filter from channel y+1. Dual mode is available only on even channel numbers (y = 0, 2, 4, 6), for odd channel numbers (y = 1, 3, 5, 7) DFSDM_CHyDATINR is write protected. If an even channel is set to dual mode then the following odd channel must be set into standard mode (DATPACK[1:0]=0) for correct cooperation with even channel. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00ff0000 constant DFSDM1_DFSDM_CH4CFGR1_CKOUTDIV                   \ Output serial clock divider Â 256 (Divider = CKOUTDIV+1). CKOUTDIV also defines the threshold for a clock absence detection. This value can only be modified when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). If DFSDMEN=0 (in DFSDM_CH0CFGR1 register) then CKOUT signal is set to low state (setting is performed one DFSDM clock cycle after DFSDMEN=0). Note: CKOUTDIV is present only in DFSDM_CH0CFGR1 register (channel y=0) 1- 255: Defines the division of system clock for the serial clock output for CKOUT signal in range 2Â -
$40000000 constant DFSDM1_DFSDM_CH4CFGR1_CKOUTSRC                   \ Output serial clock source selection This value can be modified only when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). Note: CKOUTSRC is present only in DFSDM_CH0CFGR1 register (channel y=0)
$80000000 constant DFSDM1_DFSDM_CH4CFGR1_DFSDMEN                    \ Global enable for DFSDM interface If DFSDM interface is enabled, then it is started to operate according to enabled y channels and enabled x filters settings (CHEN bit in DFSDM_CHyCFGR1 and DFEN bit in DFSDM_FLTxCR1). Data cleared by setting DFSDMEN=0: all registers DFSDM_FLTxISR are set to reset state (x = 0..7) all registers DFSDM_FLTxAWSR are set to reset state (x = 0..7) Note: DFSDMEN is present only in DFSDM_CH0CFGR1 register (channel y=0)


\
\ @brief DFSDM channel 4 configuration register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM1_DFSDM_CH4CFGR2_DTRBS                      \ Data right bit-shift for channel y will be performed to have final results. Bit-shift is performed before offset correction. The data shift is rounding the result to nearest integer value. The sign of shifted result is maintained (to have valid 24-bit signed format of result data). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). 0-31: Defines the shift of the data result coming from the integrator - how many bit shifts to the right
$ffffff00 constant DFSDM1_DFSDM_CH4CFGR2_OFFSET                     \ 24-bit calibration offset for channel y For channel y, OFFSET is applied to the results of each conversion from this channel. This value is set by software.


\
\ @brief DFSDM channel 4 analog watchdog and short-circuit detector register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_CH4AWSCDR_SCDT                      \ short-circuit detector threshold for channel y These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given channel.
$0000f000 constant DFSDM1_DFSDM_CH4AWSCDR_BKSCD                     \ Break signal assignment for short-circuit detector on channel y BKSCD[i] = 0: Break i signal not assigned to short-circuit detector on channel y BKSCD[i] = 1: Break i signal assigned to short-circuit detector on channel y
$001f0000 constant DFSDM1_DFSDM_CH4AWSCDR_AWFOSR                    \ Analog watchdog filter oversampling ratio (decimation rate) on channel y also the decimation ratio of the analog data rate. This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). Note: If AWFOSR = 0 then the filter has no effect (filter bypass). 0 - 31: Defines the length of the Sinc type filter in the range 1 - 32 (AWFOSR + 1). This number is
$00c00000 constant DFSDM1_DFSDM_CH4AWSCDR_AWFORD                    \ Analog watchdog Sinc filter order on channel y 2: Sinc2 filter type 3: Sinc3 filter type Sincx filter type transfer function: FastSinc filter type transfer function: This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).


\
\ @brief DFSDM channel 4 watchdog filter data register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH4WDATR_WDATA                      \ Input channel y watchdog data Data converted by the analog watchdog filter for input channel y. This data is continuously converted (no trigger) for this channel, with a limited resolution (OSR=1..32/sinc order = 1..3).


\
\ @brief DFSDM channel 4 data input register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH4DATINR_INDAT0                    \ Input data for channel y Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) Channel y data sample is stored into INDAT0[15:0]. If DATPACK[1:0]=1 (interleaved mode) First channel y data sample is stored into INDAT0[15:0]. Second channel y data sample is stored into INDAT1[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: Channel y data sample is stored into INDAT0[15:0]. For odd y channels: INDAT0[15:0] is write protected. See for more details. INDAT0[15:0] is in the16-bit signed format.
$ffff0000 constant DFSDM1_DFSDM_CH4DATINR_INDAT1                    \ Input data for channel y or channel y+1 Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) INDAT0[15:0] is write protected (not used for input sample). If DATPACK[1:0]=1 (interleaved mode) Second channel y data sample is stored into INDAT1[15:0]. First channel y data sample is stored into INDAT0[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: sample in INDAT1[15:0] is automatically copied into INDAT0[15:0] of channel (y+1). For odd y channels: INDAT1[15:0] is write protected. See for more details. INDAT0[15:1] is in the16-bit signed format.


\
\ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$0000003f constant DFSDM1_DFSDM_CH4DLYR_PLSSKP                      \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied


\
\ @brief DFSDM channel 5 configuration register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000003 constant DFSDM1_DFSDM_CH5CFGR1_SITP                       \ Serial interface type for channel y This value can only be modified when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000000c constant DFSDM1_DFSDM_CH5CFGR1_SPICKSEL                   \ SPI clock select for channel y 2: clock coming from internal CKOUT - sampling point on each second CKOUT falling edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input rising edge). 3: clock coming from internal CKOUT output - sampling point on each second CKOUT rising edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input falling edge). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00000020 constant DFSDM1_DFSDM_CH5CFGR1_SCDEN                      \ Short-circuit detector enable on channel y
$00000040 constant DFSDM1_DFSDM_CH5CFGR1_CKABEN                     \ Clock absence detector enable on channel y
$00000080 constant DFSDM1_DFSDM_CH5CFGR1_CHEN                       \ Channel y enable If channel y is enabled, then serial data receiving is started according to the given channel setting.
$00000100 constant DFSDM1_DFSDM_CH5CFGR1_CHINSEL                    \ Channel inputs selection This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00003000 constant DFSDM1_DFSDM_CH5CFGR1_DATMPX                     \ Input data multiplexer for channel y 2: Data to channel y are taken from internal DFSDM_CHyDATINR register by direct CPU/DMA write. There can be written one or two 16-bit data samples according DATPACK[1:0] bit field setting. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000c000 constant DFSDM1_DFSDM_CH5CFGR1_DATPACK                    \ Data packing mode in DFSDM_CHyDATINR register. first sample in INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y) To empty DFSDM_CHyDATINR register, two samples must be read by the digital filter from channel y (INDAT0[15:0] part is read as first sample and then INDAT1[15:0] part is read as next sample). 2: Dual: input data in DFSDM_CHyDATINR register are stored as two samples: first sample INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y+1) To empty DFSDM_CHyDATINR register first sample must be read by the digital filter from channel y and second sample must be read by another digital filter from channel y+1. Dual mode is available only on even channel numbers (y = 0, 2, 4, 6), for odd channel numbers (y = 1, 3, 5, 7) DFSDM_CHyDATINR is write protected. If an even channel is set to dual mode then the following odd channel must be set into standard mode (DATPACK[1:0]=0) for correct cooperation with even channel. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00ff0000 constant DFSDM1_DFSDM_CH5CFGR1_CKOUTDIV                   \ Output serial clock divider Â 256 (Divider = CKOUTDIV+1). CKOUTDIV also defines the threshold for a clock absence detection. This value can only be modified when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). If DFSDMEN=0 (in DFSDM_CH0CFGR1 register) then CKOUT signal is set to low state (setting is performed one DFSDM clock cycle after DFSDMEN=0). Note: CKOUTDIV is present only in DFSDM_CH0CFGR1 register (channel y=0) 1- 255: Defines the division of system clock for the serial clock output for CKOUT signal in range 2Â -
$40000000 constant DFSDM1_DFSDM_CH5CFGR1_CKOUTSRC                   \ Output serial clock source selection This value can be modified only when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). Note: CKOUTSRC is present only in DFSDM_CH0CFGR1 register (channel y=0)
$80000000 constant DFSDM1_DFSDM_CH5CFGR1_DFSDMEN                    \ Global enable for DFSDM interface If DFSDM interface is enabled, then it is started to operate according to enabled y channels and enabled x filters settings (CHEN bit in DFSDM_CHyCFGR1 and DFEN bit in DFSDM_FLTxCR1). Data cleared by setting DFSDMEN=0: all registers DFSDM_FLTxISR are set to reset state (x = 0..7) all registers DFSDM_FLTxAWSR are set to reset state (x = 0..7) Note: DFSDMEN is present only in DFSDM_CH0CFGR1 register (channel y=0)


\
\ @brief DFSDM channel 5 configuration register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM1_DFSDM_CH5CFGR2_DTRBS                      \ Data right bit-shift for channel y will be performed to have final results. Bit-shift is performed before offset correction. The data shift is rounding the result to nearest integer value. The sign of shifted result is maintained (to have valid 24-bit signed format of result data). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). 0-31: Defines the shift of the data result coming from the integrator - how many bit shifts to the right
$ffffff00 constant DFSDM1_DFSDM_CH5CFGR2_OFFSET                     \ 24-bit calibration offset for channel y For channel y, OFFSET is applied to the results of each conversion from this channel. This value is set by software.


\
\ @brief DFSDM channel 5 analog watchdog and short-circuit detector register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_CH5AWSCDR_SCDT                      \ short-circuit detector threshold for channel y These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given channel.
$0000f000 constant DFSDM1_DFSDM_CH5AWSCDR_BKSCD                     \ Break signal assignment for short-circuit detector on channel y BKSCD[i] = 0: Break i signal not assigned to short-circuit detector on channel y BKSCD[i] = 1: Break i signal assigned to short-circuit detector on channel y
$001f0000 constant DFSDM1_DFSDM_CH5AWSCDR_AWFOSR                    \ Analog watchdog filter oversampling ratio (decimation rate) on channel y also the decimation ratio of the analog data rate. This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). Note: If AWFOSR = 0 then the filter has no effect (filter bypass). 0 - 31: Defines the length of the Sinc type filter in the range 1 - 32 (AWFOSR + 1). This number is
$00c00000 constant DFSDM1_DFSDM_CH5AWSCDR_AWFORD                    \ Analog watchdog Sinc filter order on channel y 2: Sinc2 filter type 3: Sinc3 filter type Sincx filter type transfer function: FastSinc filter type transfer function: This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).


\
\ @brief DFSDM channel 5 watchdog filter data register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH5WDATR_WDATA                      \ Input channel y watchdog data Data converted by the analog watchdog filter for input channel y. This data is continuously converted (no trigger) for this channel, with a limited resolution (OSR=1..32/sinc order = 1..3).


\
\ @brief DFSDM channel 5 data input register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH5DATINR_INDAT0                    \ Input data for channel y Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) Channel y data sample is stored into INDAT0[15:0]. If DATPACK[1:0]=1 (interleaved mode) First channel y data sample is stored into INDAT0[15:0]. Second channel y data sample is stored into INDAT1[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: Channel y data sample is stored into INDAT0[15:0]. For odd y channels: INDAT0[15:0] is write protected. See for more details. INDAT0[15:0] is in the16-bit signed format.
$ffff0000 constant DFSDM1_DFSDM_CH5DATINR_INDAT1                    \ Input data for channel y or channel y+1 Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) INDAT0[15:0] is write protected (not used for input sample). If DATPACK[1:0]=1 (interleaved mode) Second channel y data sample is stored into INDAT1[15:0]. First channel y data sample is stored into INDAT0[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: sample in INDAT1[15:0] is automatically copied into INDAT0[15:0] of channel (y+1). For odd y channels: INDAT1[15:0] is write protected. See for more details. INDAT0[15:1] is in the16-bit signed format.


\
\ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$0000003f constant DFSDM1_DFSDM_CH5DLYR_PLSSKP                      \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied


\
\ @brief DFSDM channel 6 configuration register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000003 constant DFSDM1_DFSDM_CH6CFGR1_SITP                       \ Serial interface type for channel y This value can only be modified when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000000c constant DFSDM1_DFSDM_CH6CFGR1_SPICKSEL                   \ SPI clock select for channel y 2: clock coming from internal CKOUT - sampling point on each second CKOUT falling edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input rising edge). 3: clock coming from internal CKOUT output - sampling point on each second CKOUT rising edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input falling edge). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00000020 constant DFSDM1_DFSDM_CH6CFGR1_SCDEN                      \ Short-circuit detector enable on channel y
$00000040 constant DFSDM1_DFSDM_CH6CFGR1_CKABEN                     \ Clock absence detector enable on channel y
$00000080 constant DFSDM1_DFSDM_CH6CFGR1_CHEN                       \ Channel y enable If channel y is enabled, then serial data receiving is started according to the given channel setting.
$00000100 constant DFSDM1_DFSDM_CH6CFGR1_CHINSEL                    \ Channel inputs selection This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00003000 constant DFSDM1_DFSDM_CH6CFGR1_DATMPX                     \ Input data multiplexer for channel y 2: Data to channel y are taken from internal DFSDM_CHyDATINR register by direct CPU/DMA write. There can be written one or two 16-bit data samples according DATPACK[1:0] bit field setting. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000c000 constant DFSDM1_DFSDM_CH6CFGR1_DATPACK                    \ Data packing mode in DFSDM_CHyDATINR register. first sample in INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y) To empty DFSDM_CHyDATINR register, two samples must be read by the digital filter from channel y (INDAT0[15:0] part is read as first sample and then INDAT1[15:0] part is read as next sample). 2: Dual: input data in DFSDM_CHyDATINR register are stored as two samples: first sample INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y+1) To empty DFSDM_CHyDATINR register first sample must be read by the digital filter from channel y and second sample must be read by another digital filter from channel y+1. Dual mode is available only on even channel numbers (y = 0, 2, 4, 6), for odd channel numbers (y = 1, 3, 5, 7) DFSDM_CHyDATINR is write protected. If an even channel is set to dual mode then the following odd channel must be set into standard mode (DATPACK[1:0]=0) for correct cooperation with even channel. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00ff0000 constant DFSDM1_DFSDM_CH6CFGR1_CKOUTDIV                   \ Output serial clock divider Â 256 (Divider = CKOUTDIV+1). CKOUTDIV also defines the threshold for a clock absence detection. This value can only be modified when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). If DFSDMEN=0 (in DFSDM_CH0CFGR1 register) then CKOUT signal is set to low state (setting is performed one DFSDM clock cycle after DFSDMEN=0). Note: CKOUTDIV is present only in DFSDM_CH0CFGR1 register (channel y=0) 1- 255: Defines the division of system clock for the serial clock output for CKOUT signal in range 2Â -
$40000000 constant DFSDM1_DFSDM_CH6CFGR1_CKOUTSRC                   \ Output serial clock source selection This value can be modified only when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). Note: CKOUTSRC is present only in DFSDM_CH0CFGR1 register (channel y=0)
$80000000 constant DFSDM1_DFSDM_CH6CFGR1_DFSDMEN                    \ Global enable for DFSDM interface If DFSDM interface is enabled, then it is started to operate according to enabled y channels and enabled x filters settings (CHEN bit in DFSDM_CHyCFGR1 and DFEN bit in DFSDM_FLTxCR1). Data cleared by setting DFSDMEN=0: all registers DFSDM_FLTxISR are set to reset state (x = 0..7) all registers DFSDM_FLTxAWSR are set to reset state (x = 0..7) Note: DFSDMEN is present only in DFSDM_CH0CFGR1 register (channel y=0)


\
\ @brief DFSDM channel 6 configuration register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM1_DFSDM_CH6CFGR2_DTRBS                      \ Data right bit-shift for channel y will be performed to have final results. Bit-shift is performed before offset correction. The data shift is rounding the result to nearest integer value. The sign of shifted result is maintained (to have valid 24-bit signed format of result data). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). 0-31: Defines the shift of the data result coming from the integrator - how many bit shifts to the right
$ffffff00 constant DFSDM1_DFSDM_CH6CFGR2_OFFSET                     \ 24-bit calibration offset for channel y For channel y, OFFSET is applied to the results of each conversion from this channel. This value is set by software.


\
\ @brief DFSDM channel 6 analog watchdog and short-circuit detector register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_CH6AWSCDR_SCDT                      \ short-circuit detector threshold for channel y These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given channel.
$0000f000 constant DFSDM1_DFSDM_CH6AWSCDR_BKSCD                     \ Break signal assignment for short-circuit detector on channel y BKSCD[i] = 0: Break i signal not assigned to short-circuit detector on channel y BKSCD[i] = 1: Break i signal assigned to short-circuit detector on channel y
$001f0000 constant DFSDM1_DFSDM_CH6AWSCDR_AWFOSR                    \ Analog watchdog filter oversampling ratio (decimation rate) on channel y also the decimation ratio of the analog data rate. This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). Note: If AWFOSR = 0 then the filter has no effect (filter bypass). 0 - 31: Defines the length of the Sinc type filter in the range 1 - 32 (AWFOSR + 1). This number is
$00c00000 constant DFSDM1_DFSDM_CH6AWSCDR_AWFORD                    \ Analog watchdog Sinc filter order on channel y 2: Sinc2 filter type 3: Sinc3 filter type Sincx filter type transfer function: FastSinc filter type transfer function: This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).


\
\ @brief DFSDM channel 6 watchdog filter data register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH6WDATR_WDATA                      \ Input channel y watchdog data Data converted by the analog watchdog filter for input channel y. This data is continuously converted (no trigger) for this channel, with a limited resolution (OSR=1..32/sinc order = 1..3).


\
\ @brief DFSDM channel 6 data input register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH6DATINR_INDAT0                    \ Input data for channel y Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) Channel y data sample is stored into INDAT0[15:0]. If DATPACK[1:0]=1 (interleaved mode) First channel y data sample is stored into INDAT0[15:0]. Second channel y data sample is stored into INDAT1[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: Channel y data sample is stored into INDAT0[15:0]. For odd y channels: INDAT0[15:0] is write protected. See for more details. INDAT0[15:0] is in the16-bit signed format.
$ffff0000 constant DFSDM1_DFSDM_CH6DATINR_INDAT1                    \ Input data for channel y or channel y+1 Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) INDAT0[15:0] is write protected (not used for input sample). If DATPACK[1:0]=1 (interleaved mode) Second channel y data sample is stored into INDAT1[15:0]. First channel y data sample is stored into INDAT0[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: sample in INDAT1[15:0] is automatically copied into INDAT0[15:0] of channel (y+1). For odd y channels: INDAT1[15:0] is write protected. See for more details. INDAT0[15:1] is in the16-bit signed format.


\
\ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$0000003f constant DFSDM1_DFSDM_CH6DLYR_PLSSKP                      \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied


\
\ @brief DFSDM channel 7 configuration register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000003 constant DFSDM1_DFSDM_CH7CFGR1_SITP                       \ Serial interface type for channel y This value can only be modified when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000000c constant DFSDM1_DFSDM_CH7CFGR1_SPICKSEL                   \ SPI clock select for channel y 2: clock coming from internal CKOUT - sampling point on each second CKOUT falling edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input rising edge). 3: clock coming from internal CKOUT output - sampling point on each second CKOUT rising edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input falling edge). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00000020 constant DFSDM1_DFSDM_CH7CFGR1_SCDEN                      \ Short-circuit detector enable on channel y
$00000040 constant DFSDM1_DFSDM_CH7CFGR1_CKABEN                     \ Clock absence detector enable on channel y
$00000080 constant DFSDM1_DFSDM_CH7CFGR1_CHEN                       \ Channel y enable If channel y is enabled, then serial data receiving is started according to the given channel setting.
$00000100 constant DFSDM1_DFSDM_CH7CFGR1_CHINSEL                    \ Channel inputs selection This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00003000 constant DFSDM1_DFSDM_CH7CFGR1_DATMPX                     \ Input data multiplexer for channel y 2: Data to channel y are taken from internal DFSDM_CHyDATINR register by direct CPU/DMA write. There can be written one or two 16-bit data samples according DATPACK[1:0] bit field setting. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000c000 constant DFSDM1_DFSDM_CH7CFGR1_DATPACK                    \ Data packing mode in DFSDM_CHyDATINR register. first sample in INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y) To empty DFSDM_CHyDATINR register, two samples must be read by the digital filter from channel y (INDAT0[15:0] part is read as first sample and then INDAT1[15:0] part is read as next sample). 2: Dual: input data in DFSDM_CHyDATINR register are stored as two samples: first sample INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y+1) To empty DFSDM_CHyDATINR register first sample must be read by the digital filter from channel y and second sample must be read by another digital filter from channel y+1. Dual mode is available only on even channel numbers (y = 0, 2, 4, 6), for odd channel numbers (y = 1, 3, 5, 7) DFSDM_CHyDATINR is write protected. If an even channel is set to dual mode then the following odd channel must be set into standard mode (DATPACK[1:0]=0) for correct cooperation with even channel. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00ff0000 constant DFSDM1_DFSDM_CH7CFGR1_CKOUTDIV                   \ Output serial clock divider Â 256 (Divider = CKOUTDIV+1). CKOUTDIV also defines the threshold for a clock absence detection. This value can only be modified when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). If DFSDMEN=0 (in DFSDM_CH0CFGR1 register) then CKOUT signal is set to low state (setting is performed one DFSDM clock cycle after DFSDMEN=0). Note: CKOUTDIV is present only in DFSDM_CH0CFGR1 register (channel y=0) 1- 255: Defines the division of system clock for the serial clock output for CKOUT signal in range 2Â -
$40000000 constant DFSDM1_DFSDM_CH7CFGR1_CKOUTSRC                   \ Output serial clock source selection This value can be modified only when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). Note: CKOUTSRC is present only in DFSDM_CH0CFGR1 register (channel y=0)
$80000000 constant DFSDM1_DFSDM_CH7CFGR1_DFSDMEN                    \ Global enable for DFSDM interface If DFSDM interface is enabled, then it is started to operate according to enabled y channels and enabled x filters settings (CHEN bit in DFSDM_CHyCFGR1 and DFEN bit in DFSDM_FLTxCR1). Data cleared by setting DFSDMEN=0: all registers DFSDM_FLTxISR are set to reset state (x = 0..7) all registers DFSDM_FLTxAWSR are set to reset state (x = 0..7) Note: DFSDMEN is present only in DFSDM_CH0CFGR1 register (channel y=0)


\
\ @brief DFSDM channel 7 configuration register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM1_DFSDM_CH7CFGR2_DTRBS                      \ Data right bit-shift for channel y will be performed to have final results. Bit-shift is performed before offset correction. The data shift is rounding the result to nearest integer value. The sign of shifted result is maintained (to have valid 24-bit signed format of result data). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). 0-31: Defines the shift of the data result coming from the integrator - how many bit shifts to the right
$ffffff00 constant DFSDM1_DFSDM_CH7CFGR2_OFFSET                     \ 24-bit calibration offset for channel y For channel y, OFFSET is applied to the results of each conversion from this channel. This value is set by software.


\
\ @brief DFSDM channel 7 analog watchdog and short-circuit detector register
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_CH7AWSCDR_SCDT                      \ short-circuit detector threshold for channel y These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given channel.
$0000f000 constant DFSDM1_DFSDM_CH7AWSCDR_BKSCD                     \ Break signal assignment for short-circuit detector on channel y BKSCD[i] = 0: Break i signal not assigned to short-circuit detector on channel y BKSCD[i] = 1: Break i signal assigned to short-circuit detector on channel y
$001f0000 constant DFSDM1_DFSDM_CH7AWSCDR_AWFOSR                    \ Analog watchdog filter oversampling ratio (decimation rate) on channel y also the decimation ratio of the analog data rate. This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). Note: If AWFOSR = 0 then the filter has no effect (filter bypass). 0 - 31: Defines the length of the Sinc type filter in the range 1 - 32 (AWFOSR + 1). This number is
$00c00000 constant DFSDM1_DFSDM_CH7AWSCDR_AWFORD                    \ Analog watchdog Sinc filter order on channel y 2: Sinc2 filter type 3: Sinc3 filter type Sincx filter type transfer function: FastSinc filter type transfer function: This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).


\
\ @brief DFSDM channel 7 watchdog filter data register
\ Address offset: 0xEC
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH7WDATR_WDATA                      \ Input channel y watchdog data Data converted by the analog watchdog filter for input channel y. This data is continuously converted (no trigger) for this channel, with a limited resolution (OSR=1..32/sinc order = 1..3).


\
\ @brief DFSDM channel 7 data input register
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH7DATINR_INDAT0                    \ Input data for channel y Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) Channel y data sample is stored into INDAT0[15:0]. If DATPACK[1:0]=1 (interleaved mode) First channel y data sample is stored into INDAT0[15:0]. Second channel y data sample is stored into INDAT1[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: Channel y data sample is stored into INDAT0[15:0]. For odd y channels: INDAT0[15:0] is write protected. See for more details. INDAT0[15:0] is in the16-bit signed format.
$ffff0000 constant DFSDM1_DFSDM_CH7DATINR_INDAT1                    \ Input data for channel y or channel y+1 Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) INDAT0[15:0] is write protected (not used for input sample). If DATPACK[1:0]=1 (interleaved mode) Second channel y data sample is stored into INDAT1[15:0]. First channel y data sample is stored into INDAT0[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: sample in INDAT1[15:0] is automatically copied into INDAT0[15:0] of channel (y+1). For odd y channels: INDAT1[15:0] is write protected. See for more details. INDAT0[15:1] is in the16-bit signed format.


\
\ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$0000003f constant DFSDM1_DFSDM_CH7DLYR_PLSSKP                      \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied


\
\ @brief DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT0CR1_DFEN                        \ DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
$00000002 constant DFSDM1_DFSDM_FLT0CR1_JSWSTART                    \ Start a conversion of the injected group of channels This bit is always read as '0â.
$00000008 constant DFSDM1_DFSDM_FLT0CR1_JSYNC                       \ Launch an injected conversion synchronously with the DFSDM_FLT0 JSWSTART trigger This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00000010 constant DFSDM1_DFSDM_FLT0CR1_JSCAN                       \ Scanning conversion mode for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Writing JCHG if JSCAN=0 resets the channel selection to the lowest selected channel.
$00000020 constant DFSDM1_DFSDM_FLT0CR1_JDMAEN                      \ DMA channel enabled to read data for the injected channel group This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00001f00 constant DFSDM1_DFSDM_FLT0CR1_JEXTSEL                     \ Trigger signal selection for launching injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Note: synchronous trigger has latency up to one fDFSDMCLK clock cycle (with deterministic jitter), asynchronous trigger has latency 2-3 fDFSDMCLK clock cycles (with jitter up to 1 cycle). DFSDM_FLTx 0x00 dfsdm_jtrg0 0x01 dfsdm_jtrg1 ... 0x1E dfsdm_jtrg30 0x1F dfsdm_jtrg31 Refer to . 0x0-0x1F: Trigger inputs selected by the following table (internal or external trigger).
$00006000 constant DFSDM1_DFSDM_FLT0CR1_JEXTEN                      \ Trigger enable and trigger edge selection for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00020000 constant DFSDM1_DFSDM_FLT0CR1_RSWSTART                    \ Software start of a conversion on the regular channel This bit is always read as '0â.
$00040000 constant DFSDM1_DFSDM_FLT0CR1_RCONT                       \ Continuous mode selection for regular conversions Writing '0â to this bit while a continuous regular conversion is already in progress stops the continuous mode immediately.
$00080000 constant DFSDM1_DFSDM_FLT0CR1_RSYNC                       \ Launch regular conversion synchronously with DFSDM_FLT0 This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00200000 constant DFSDM1_DFSDM_FLT0CR1_RDMAEN                      \ DMA channel enabled to read data for the regular conversion This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$07000000 constant DFSDM1_DFSDM_FLT0CR1_RCH                         \ Regular channel selection ... 7: Channel 7 is selected as the regular channel Writing these bits when RCIP=1 takes effect when the next regular conversion begins. This is especially useful in continuous mode (when RCONT=1). It also affects regular conversions which are pending (due to ongoing injected conversion).
$20000000 constant DFSDM1_DFSDM_FLT0CR1_FAST                        \ Fast conversion mode selection for regular conversions When converting a regular conversion in continuous mode, having enabled the fast mode causes each conversion (except the first) to execute faster than in standard mode. This bit has no effect on conversions which are not continuous. This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): t = IOSR / fCKIN (... but CNVCNT=0) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input.
$40000000 constant DFSDM1_DFSDM_FLT0CR1_AWFSEL                      \ Analog watchdog fast mode select


\
\ @brief Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT0CR2_JEOCIE                      \ Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
$00000002 constant DFSDM1_DFSDM_FLT0CR2_REOCIE                      \ Regular end of conversion interrupt enable Please see the explanation of REOCF in DFSDM_FLTxISR.
$00000004 constant DFSDM1_DFSDM_FLT0CR2_JOVRIE                      \ Injected data overrun interrupt enable Please see the explanation of JOVRF in DFSDM_FLTxISR.
$00000008 constant DFSDM1_DFSDM_FLT0CR2_ROVRIE                      \ Regular data overrun interrupt enable Please see the explanation of ROVRF in DFSDM_FLTxISR.
$00000010 constant DFSDM1_DFSDM_FLT0CR2_AWDIE                       \ Analog watchdog interrupt enable Please see the explanation of AWDF in DFSDM_FLTxISR.
$00000020 constant DFSDM1_DFSDM_FLT0CR2_SCDIE                       \ Short-circuit detector interrupt enable Please see the explanation of SCDF[7:0] in DFSDM_FLTxISR. Note: SCDIE is present only in DFSDM_FLT0CR2 register (filter x=0)
$00000040 constant DFSDM1_DFSDM_FLT0CR2_CKABIE                      \ Clock absence interrupt enable Please see the explanation of CKABF[7:0] in DFSDM_FLTxISR. Note: CKABIE is present only in DFSDM_FLT0CR2 register (filter x=0)
$0000ff00 constant DFSDM1_DFSDM_FLT0CR2_EXCH                        \ Extremes detector channel selection These bits select the input channels to be taken by the Extremes detector. EXCH[y] = 0: Extremes detector does not accept data from channel y EXCH[y] = 1: Extremes detector accepts data from channel y
$00ff0000 constant DFSDM1_DFSDM_FLT0CR2_AWDCH                       \ Analog watchdog channel selection These bits select the input channel to be guarded continuously by the analog watchdog. AWDCH[y] = 0: Analog watchdog is disabled on channel y AWDCH[y] = 1: Analog watchdog is enabled on channel y


\
\ @brief End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
\ Address offset: 0x108
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM1_DFSDM_FLT0ISR_JEOCF                       \ End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
$00000002 constant DFSDM1_DFSDM_FLT0ISR_REOCF                       \ End of regular conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxRDATAR.
$00000004 constant DFSDM1_DFSDM_FLT0ISR_JOVRF                       \ Injected conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRJOVRF bit in the DFSDM_FLTxICR register.
$00000008 constant DFSDM1_DFSDM_FLT0ISR_ROVRF                       \ Regular conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRROVRF bit in the DFSDM_FLTxICR register.
$00000010 constant DFSDM1_DFSDM_FLT0ISR_AWDF                        \ Analog watchdog This bit is set by hardware. It is cleared by software by clearing all source flag bits AWHTF[7:0] and AWLTF[7:0] in DFSDM_FLTxAWSR register (by writing '1â into the clear bits in DFSDM_FLTxAWCFR register).
$00002000 constant DFSDM1_DFSDM_FLT0ISR_JCIP                        \ Injected conversion in progress status A request to start an injected conversion is ignored when JCIP=1.
$00004000 constant DFSDM1_DFSDM_FLT0ISR_RCIP                        \ Regular conversion in progress status A request to start a regular conversion is ignored when RCIP=1.
$00ff0000 constant DFSDM1_DFSDM_FLT0ISR_CKABF                       \ Clock absence flag CKABF[y]=0: Clock signal on channel y is present. CKABF[y]=1: Clock signal on channel y is not present. Given y bit is set by hardware when clock absence is detected on channel y. It is held at CKABF[y]=1 state by hardware when CHEN=0 (see DFSDM_CHyCFGR1 register). It is held at CKABF[y]=1 state by hardware when the transceiver is not yet synchronized.It can be cleared by software using the corresponding CLRCKABF[y] bit in the DFSDM_FLTxICR register. Note: CKABF[7:0] is present only in DFSDM_FLT0ISR register (filter x=0)
$ff000000 constant DFSDM1_DFSDM_FLT0ISR_SCDF                        \ short-circuit detector flag SDCF[y]=0: No short-circuit detector event occurred on channel y SDCF[y]=1: The short-circuit detector counter reaches, on channel y, the value programmed in the DFSDM_CHyAWSCDR registers This bit is set by hardware. It can be cleared by software using the corresponding CLRSCDF[y] bit in the DFSDM_FLTxICR register. SCDF[y] is cleared also by hardware when CHEN[y] = 0 (given channel is disabled). Note: SCDF[7:0] is present only in DFSDM_FLT0ISR register (filter x=0)


\
\ @brief Clear the injected conversion overrun flag
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM1_DFSDM_FLT0ICR_CLRJOVRF                    \ Clear the injected conversion overrun flag
$00000008 constant DFSDM1_DFSDM_FLT0ICR_CLRROVRF                    \ Clear the regular conversion overrun flag
$00ff0000 constant DFSDM1_DFSDM_FLT0ICR_CLRCKABF                    \ Clear the clock absence flag CLRCKABF[y]=0: Writing '0â has no effect CLRCKABF[y]=1: Writing '1â to position y clears the corresponding CKABF[y] bit in the DFSDM_FLTxISR register. When the transceiver is not yet synchronized, the clock absence flag is set and cannot be cleared by CLRCKABF[y]. Note: CLRCKABF[7:0] is present only in DFSDM_FLT0ICR register (filter x=0)
$ff000000 constant DFSDM1_DFSDM_FLT0ICR_CLRSCDF                     \ Clear the short-circuit detector flag CLRSCDF[y]=0: Writing '0â has no effect CLRSCDF[y]=1: Writing '1â to position y clears the corresponding SCDF[y] bit in the DFSDM_FLTxISR register Note: CLRSCDF[7:0] is present only in DFSDM_FLT0ICR register (filter x=0)


\
\ @brief Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
\ Address offset: 0x110
\ Reset value: 0x00000001
\

$000000ff constant DFSDM1_DFSDM_FLT0JCHGR_JCHG                      \ Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.


\
\ @brief Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT0FCR_IOSR                        \ Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
$03ff0000 constant DFSDM1_DFSDM_FLT0FCR_FOSR                        \ Sinc filter oversampling ratio (decimation rate) number is also the decimation ratio of the output data rate from filter. This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If FOSR = 0, then the filter has no effect (filter bypass). 0 - 1023: Defines the length of the Sinc type filter in the range 1 - 1024 (FOSR = FOSR[9:0] +1). This
$e0000000 constant DFSDM1_DFSDM_FLT0FCR_FORD                        \ Sinc filter order 2: Sinc2 filter type 3: Sinc3 filter type 4: Sinc4 filter type 5: Sinc5 filter type 6-7: Reserved Sincx filter type transfer function: FastSinc filter type transfer function: This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1).


\
\ @brief Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT0JDATAR_JDATACH                  \ Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
$ffffff00 constant DFSDM1_DFSDM_FLT0JDATAR_JDATA                    \ Injected group conversion data When each conversion of a channel in the injected group finishes, its resulting data is stored in this field. The data is valid when JEOCF=1. Reading this register clears the corresponding JEOCF.


\
\ @brief Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT0RDATAR_RDATACH                  \ Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
$00000010 constant DFSDM1_DFSDM_FLT0RDATAR_RPEND                    \ Regular channel pending data Regular data in RDATA[23:0] was delayed due to an injected channel trigger during the conversion
$ffffff00 constant DFSDM1_DFSDM_FLT0RDATAR_RDATA                    \ Regular channel conversion data When each regular conversion finishes, its data is stored in this register. The data is valid when REOCF=1. Reading this register clears the corresponding REOCF.


\
\ @brief Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT0AWHTR_BKAWH                     \ Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
$ffffff00 constant DFSDM1_DFSDM_FLT0AWHTR_AWHT                      \ Analog watchdog high threshold These bits are written by software to define the high threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), the higher 16 bits (AWHT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWHT[7:0] are not taken into comparison in this case.


\
\ @brief Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT0AWLTR_BKAWL                     \ Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
$ffffff00 constant DFSDM1_DFSDM_FLT0AWLTR_AWLT                      \ Analog watchdog low threshold These bits are written by software to define the low threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), only the higher 16 bits (AWLT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWLT[7:0] are not taken into comparison in this case.


\
\ @brief Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT0AWSR_AWLTF                      \ Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
$0000ff00 constant DFSDM1_DFSDM_FLT0AWSR_AWHTF                      \ Analog watchdog high threshold flag AWHTF[y]=1 indicates a high threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWHTF[y] bit in the DFSDM_FLTxAWCFR register.


\
\ @brief Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT0AWCFR_CLRAWLTF                  \ Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
$0000ff00 constant DFSDM1_DFSDM_FLT0AWCFR_CLRAWHTF                  \ Clear the analog watchdog high threshold flag CLRAWHTF[y]=0: Writing '0â has no effect CLRAWHTF[y]=1: Writing '1â to position y clears the corresponding AWHTF[y] bit in the DFSDM_FLTxAWSR register


\
\ @brief Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
\ Address offset: 0x130
\ Reset value: 0x80000000
\

$00000007 constant DFSDM1_DFSDM_FLT0EXMAX_EXMAXCH                   \ Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
$ffffff00 constant DFSDM1_DFSDM_FLT0EXMAX_EXMAX                     \ Extremes detector maximum value These bits are set by hardware and indicate the highest value converted by DFSDM_FLTx. EXMAX[23:0] bits are reset to value (0x800000) by reading of this register.


\
\ @brief Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
\ Address offset: 0x134
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM1_DFSDM_FLT0EXMIN_EXMINCH                   \ Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
$ffffff00 constant DFSDM1_DFSDM_FLT0EXMIN_EXMIN                     \ Extremes detector minimum value These bits are set by hardware and indicate the lowest value converted by DFSDM_FLTx. EXMIN[23:0] bits are reset to value (0x7FFFFF) by reading of this register.


\
\ @brief 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM1_DFSDM_FLT0CNVTIMR_CNVCNT                  \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.


\
\ @brief DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT1CR1_DFEN                        \ DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
$00000002 constant DFSDM1_DFSDM_FLT1CR1_JSWSTART                    \ Start a conversion of the injected group of channels This bit is always read as '0â.
$00000008 constant DFSDM1_DFSDM_FLT1CR1_JSYNC                       \ Launch an injected conversion synchronously with the DFSDM_FLT0 JSWSTART trigger This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00000010 constant DFSDM1_DFSDM_FLT1CR1_JSCAN                       \ Scanning conversion mode for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Writing JCHG if JSCAN=0 resets the channel selection to the lowest selected channel.
$00000020 constant DFSDM1_DFSDM_FLT1CR1_JDMAEN                      \ DMA channel enabled to read data for the injected channel group This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00001f00 constant DFSDM1_DFSDM_FLT1CR1_JEXTSEL                     \ Trigger signal selection for launching injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Note: synchronous trigger has latency up to one fDFSDMCLK clock cycle (with deterministic jitter), asynchronous trigger has latency 2-3 fDFSDMCLK clock cycles (with jitter up to 1 cycle). DFSDM_FLTx 0x00 dfsdm_jtrg0 0x01 dfsdm_jtrg1 ... 0x1E dfsdm_jtrg30 0x1F dfsdm_jtrg31 Refer to . 0x0-0x1F: Trigger inputs selected by the following table (internal or external trigger).
$00006000 constant DFSDM1_DFSDM_FLT1CR1_JEXTEN                      \ Trigger enable and trigger edge selection for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00020000 constant DFSDM1_DFSDM_FLT1CR1_RSWSTART                    \ Software start of a conversion on the regular channel This bit is always read as '0â.
$00040000 constant DFSDM1_DFSDM_FLT1CR1_RCONT                       \ Continuous mode selection for regular conversions Writing '0â to this bit while a continuous regular conversion is already in progress stops the continuous mode immediately.
$00080000 constant DFSDM1_DFSDM_FLT1CR1_RSYNC                       \ Launch regular conversion synchronously with DFSDM_FLT0 This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00200000 constant DFSDM1_DFSDM_FLT1CR1_RDMAEN                      \ DMA channel enabled to read data for the regular conversion This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$07000000 constant DFSDM1_DFSDM_FLT1CR1_RCH                         \ Regular channel selection ... 7: Channel 7 is selected as the regular channel Writing these bits when RCIP=1 takes effect when the next regular conversion begins. This is especially useful in continuous mode (when RCONT=1). It also affects regular conversions which are pending (due to ongoing injected conversion).
$20000000 constant DFSDM1_DFSDM_FLT1CR1_FAST                        \ Fast conversion mode selection for regular conversions When converting a regular conversion in continuous mode, having enabled the fast mode causes each conversion (except the first) to execute faster than in standard mode. This bit has no effect on conversions which are not continuous. This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): t = IOSR / fCKIN (... but CNVCNT=0) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input.
$40000000 constant DFSDM1_DFSDM_FLT1CR1_AWFSEL                      \ Analog watchdog fast mode select


\
\ @brief Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT1CR2_JEOCIE                      \ Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
$00000002 constant DFSDM1_DFSDM_FLT1CR2_REOCIE                      \ Regular end of conversion interrupt enable Please see the explanation of REOCF in DFSDM_FLTxISR.
$00000004 constant DFSDM1_DFSDM_FLT1CR2_JOVRIE                      \ Injected data overrun interrupt enable Please see the explanation of JOVRF in DFSDM_FLTxISR.
$00000008 constant DFSDM1_DFSDM_FLT1CR2_ROVRIE                      \ Regular data overrun interrupt enable Please see the explanation of ROVRF in DFSDM_FLTxISR.
$00000010 constant DFSDM1_DFSDM_FLT1CR2_AWDIE                       \ Analog watchdog interrupt enable Please see the explanation of AWDF in DFSDM_FLTxISR.
$00000020 constant DFSDM1_DFSDM_FLT1CR2_SCDIE                       \ Short-circuit detector interrupt enable Please see the explanation of SCDF[7:0] in DFSDM_FLTxISR. Note: SCDIE is present only in DFSDM_FLT0CR2 register (filter x=0)
$00000040 constant DFSDM1_DFSDM_FLT1CR2_CKABIE                      \ Clock absence interrupt enable Please see the explanation of CKABF[7:0] in DFSDM_FLTxISR. Note: CKABIE is present only in DFSDM_FLT0CR2 register (filter x=0)
$0000ff00 constant DFSDM1_DFSDM_FLT1CR2_EXCH                        \ Extremes detector channel selection These bits select the input channels to be taken by the Extremes detector. EXCH[y] = 0: Extremes detector does not accept data from channel y EXCH[y] = 1: Extremes detector accepts data from channel y
$00ff0000 constant DFSDM1_DFSDM_FLT1CR2_AWDCH                       \ Analog watchdog channel selection These bits select the input channel to be guarded continuously by the analog watchdog. AWDCH[y] = 0: Analog watchdog is disabled on channel y AWDCH[y] = 1: Analog watchdog is enabled on channel y


\
\ @brief End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
\ Address offset: 0x188
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM1_DFSDM_FLT1ISR_JEOCF                       \ End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
$00000002 constant DFSDM1_DFSDM_FLT1ISR_REOCF                       \ End of regular conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxRDATAR.
$00000004 constant DFSDM1_DFSDM_FLT1ISR_JOVRF                       \ Injected conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRJOVRF bit in the DFSDM_FLTxICR register.
$00000008 constant DFSDM1_DFSDM_FLT1ISR_ROVRF                       \ Regular conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRROVRF bit in the DFSDM_FLTxICR register.
$00000010 constant DFSDM1_DFSDM_FLT1ISR_AWDF                        \ Analog watchdog This bit is set by hardware. It is cleared by software by clearing all source flag bits AWHTF[7:0] and AWLTF[7:0] in DFSDM_FLTxAWSR register (by writing '1â into the clear bits in DFSDM_FLTxAWCFR register).
$00002000 constant DFSDM1_DFSDM_FLT1ISR_JCIP                        \ Injected conversion in progress status A request to start an injected conversion is ignored when JCIP=1.
$00004000 constant DFSDM1_DFSDM_FLT1ISR_RCIP                        \ Regular conversion in progress status A request to start a regular conversion is ignored when RCIP=1.
$00ff0000 constant DFSDM1_DFSDM_FLT1ISR_CKABF                       \ Clock absence flag CKABF[y]=0: Clock signal on channel y is present. CKABF[y]=1: Clock signal on channel y is not present. Given y bit is set by hardware when clock absence is detected on channel y. It is held at CKABF[y]=1 state by hardware when CHEN=0 (see DFSDM_CHyCFGR1 register). It is held at CKABF[y]=1 state by hardware when the transceiver is not yet synchronized.It can be cleared by software using the corresponding CLRCKABF[y] bit in the DFSDM_FLTxICR register. Note: CKABF[7:0] is present only in DFSDM_FLT0ISR register (filter x=0)
$ff000000 constant DFSDM1_DFSDM_FLT1ISR_SCDF                        \ short-circuit detector flag SDCF[y]=0: No short-circuit detector event occurred on channel y SDCF[y]=1: The short-circuit detector counter reaches, on channel y, the value programmed in the DFSDM_CHyAWSCDR registers This bit is set by hardware. It can be cleared by software using the corresponding CLRSCDF[y] bit in the DFSDM_FLTxICR register. SCDF[y] is cleared also by hardware when CHEN[y] = 0 (given channel is disabled). Note: SCDF[7:0] is present only in DFSDM_FLT0ISR register (filter x=0)


\
\ @brief Clear the injected conversion overrun flag
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM1_DFSDM_FLT1ICR_CLRJOVRF                    \ Clear the injected conversion overrun flag
$00000008 constant DFSDM1_DFSDM_FLT1ICR_CLRROVRF                    \ Clear the regular conversion overrun flag
$00ff0000 constant DFSDM1_DFSDM_FLT1ICR_CLRCKABF                    \ Clear the clock absence flag CLRCKABF[y]=0: Writing '0â has no effect CLRCKABF[y]=1: Writing '1â to position y clears the corresponding CKABF[y] bit in the DFSDM_FLTxISR register. When the transceiver is not yet synchronized, the clock absence flag is set and cannot be cleared by CLRCKABF[y]. Note: CLRCKABF[7:0] is present only in DFSDM_FLT0ICR register (filter x=0)
$ff000000 constant DFSDM1_DFSDM_FLT1ICR_CLRSCDF                     \ Clear the short-circuit detector flag CLRSCDF[y]=0: Writing '0â has no effect CLRSCDF[y]=1: Writing '1â to position y clears the corresponding SCDF[y] bit in the DFSDM_FLTxISR register Note: CLRSCDF[7:0] is present only in DFSDM_FLT0ICR register (filter x=0)


\
\ @brief Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
\ Address offset: 0x190
\ Reset value: 0x00000001
\

$000000ff constant DFSDM1_DFSDM_FLT1JCHGR_JCHG                      \ Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.


\
\ @brief Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT1FCR_IOSR                        \ Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
$03ff0000 constant DFSDM1_DFSDM_FLT1FCR_FOSR                        \ Sinc filter oversampling ratio (decimation rate) number is also the decimation ratio of the output data rate from filter. This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If FOSR = 0, then the filter has no effect (filter bypass). 0 - 1023: Defines the length of the Sinc type filter in the range 1 - 1024 (FOSR = FOSR[9:0] +1). This
$e0000000 constant DFSDM1_DFSDM_FLT1FCR_FORD                        \ Sinc filter order 2: Sinc2 filter type 3: Sinc3 filter type 4: Sinc4 filter type 5: Sinc5 filter type 6-7: Reserved Sincx filter type transfer function: FastSinc filter type transfer function: This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1).


\
\ @brief Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT1JDATAR_JDATACH                  \ Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
$ffffff00 constant DFSDM1_DFSDM_FLT1JDATAR_JDATA                    \ Injected group conversion data When each conversion of a channel in the injected group finishes, its resulting data is stored in this field. The data is valid when JEOCF=1. Reading this register clears the corresponding JEOCF.


\
\ @brief Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT1RDATAR_RDATACH                  \ Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
$00000010 constant DFSDM1_DFSDM_FLT1RDATAR_RPEND                    \ Regular channel pending data Regular data in RDATA[23:0] was delayed due to an injected channel trigger during the conversion
$ffffff00 constant DFSDM1_DFSDM_FLT1RDATAR_RDATA                    \ Regular channel conversion data When each regular conversion finishes, its data is stored in this register. The data is valid when REOCF=1. Reading this register clears the corresponding REOCF.


\
\ @brief Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT1AWHTR_BKAWH                     \ Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
$ffffff00 constant DFSDM1_DFSDM_FLT1AWHTR_AWHT                      \ Analog watchdog high threshold These bits are written by software to define the high threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), the higher 16 bits (AWHT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWHT[7:0] are not taken into comparison in this case.


\
\ @brief Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT1AWLTR_BKAWL                     \ Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
$ffffff00 constant DFSDM1_DFSDM_FLT1AWLTR_AWLT                      \ Analog watchdog low threshold These bits are written by software to define the low threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), only the higher 16 bits (AWLT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWLT[7:0] are not taken into comparison in this case.


\
\ @brief Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT1AWSR_AWLTF                      \ Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
$0000ff00 constant DFSDM1_DFSDM_FLT1AWSR_AWHTF                      \ Analog watchdog high threshold flag AWHTF[y]=1 indicates a high threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWHTF[y] bit in the DFSDM_FLTxAWCFR register.


\
\ @brief Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT1AWCFR_CLRAWLTF                  \ Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
$0000ff00 constant DFSDM1_DFSDM_FLT1AWCFR_CLRAWHTF                  \ Clear the analog watchdog high threshold flag CLRAWHTF[y]=0: Writing '0â has no effect CLRAWHTF[y]=1: Writing '1â to position y clears the corresponding AWHTF[y] bit in the DFSDM_FLTxAWSR register


\
\ @brief Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
\ Address offset: 0x1B0
\ Reset value: 0x80000000
\

$00000007 constant DFSDM1_DFSDM_FLT1EXMAX_EXMAXCH                   \ Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
$ffffff00 constant DFSDM1_DFSDM_FLT1EXMAX_EXMAX                     \ Extremes detector maximum value These bits are set by hardware and indicate the highest value converted by DFSDM_FLTx. EXMAX[23:0] bits are reset to value (0x800000) by reading of this register.


\
\ @brief Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
\ Address offset: 0x1B4
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM1_DFSDM_FLT1EXMIN_EXMINCH                   \ Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
$ffffff00 constant DFSDM1_DFSDM_FLT1EXMIN_EXMIN                     \ Extremes detector minimum value These bits are set by hardware and indicate the lowest value converted by DFSDM_FLTx. EXMIN[23:0] bits are reset to value (0x7FFFFF) by reading of this register.


\
\ @brief 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
\ Address offset: 0x1B8
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM1_DFSDM_FLT1CNVTIMR_CNVCNT                  \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.


\
\ @brief DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT2CR1_DFEN                        \ DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
$00000002 constant DFSDM1_DFSDM_FLT2CR1_JSWSTART                    \ Start a conversion of the injected group of channels This bit is always read as '0â.
$00000008 constant DFSDM1_DFSDM_FLT2CR1_JSYNC                       \ Launch an injected conversion synchronously with the DFSDM_FLT0 JSWSTART trigger This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00000010 constant DFSDM1_DFSDM_FLT2CR1_JSCAN                       \ Scanning conversion mode for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Writing JCHG if JSCAN=0 resets the channel selection to the lowest selected channel.
$00000020 constant DFSDM1_DFSDM_FLT2CR1_JDMAEN                      \ DMA channel enabled to read data for the injected channel group This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00001f00 constant DFSDM1_DFSDM_FLT2CR1_JEXTSEL                     \ Trigger signal selection for launching injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Note: synchronous trigger has latency up to one fDFSDMCLK clock cycle (with deterministic jitter), asynchronous trigger has latency 2-3 fDFSDMCLK clock cycles (with jitter up to 1 cycle). DFSDM_FLTx 0x00 dfsdm_jtrg0 0x01 dfsdm_jtrg1 ... 0x1E dfsdm_jtrg30 0x1F dfsdm_jtrg31 Refer to . 0x0-0x1F: Trigger inputs selected by the following table (internal or external trigger).
$00006000 constant DFSDM1_DFSDM_FLT2CR1_JEXTEN                      \ Trigger enable and trigger edge selection for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00020000 constant DFSDM1_DFSDM_FLT2CR1_RSWSTART                    \ Software start of a conversion on the regular channel This bit is always read as '0â.
$00040000 constant DFSDM1_DFSDM_FLT2CR1_RCONT                       \ Continuous mode selection for regular conversions Writing '0â to this bit while a continuous regular conversion is already in progress stops the continuous mode immediately.
$00080000 constant DFSDM1_DFSDM_FLT2CR1_RSYNC                       \ Launch regular conversion synchronously with DFSDM_FLT0 This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00200000 constant DFSDM1_DFSDM_FLT2CR1_RDMAEN                      \ DMA channel enabled to read data for the regular conversion This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$07000000 constant DFSDM1_DFSDM_FLT2CR1_RCH                         \ Regular channel selection ... 7: Channel 7 is selected as the regular channel Writing these bits when RCIP=1 takes effect when the next regular conversion begins. This is especially useful in continuous mode (when RCONT=1). It also affects regular conversions which are pending (due to ongoing injected conversion).
$20000000 constant DFSDM1_DFSDM_FLT2CR1_FAST                        \ Fast conversion mode selection for regular conversions When converting a regular conversion in continuous mode, having enabled the fast mode causes each conversion (except the first) to execute faster than in standard mode. This bit has no effect on conversions which are not continuous. This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): t = IOSR / fCKIN (... but CNVCNT=0) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input.
$40000000 constant DFSDM1_DFSDM_FLT2CR1_AWFSEL                      \ Analog watchdog fast mode select


\
\ @brief Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT2CR2_JEOCIE                      \ Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
$00000002 constant DFSDM1_DFSDM_FLT2CR2_REOCIE                      \ Regular end of conversion interrupt enable Please see the explanation of REOCF in DFSDM_FLTxISR.
$00000004 constant DFSDM1_DFSDM_FLT2CR2_JOVRIE                      \ Injected data overrun interrupt enable Please see the explanation of JOVRF in DFSDM_FLTxISR.
$00000008 constant DFSDM1_DFSDM_FLT2CR2_ROVRIE                      \ Regular data overrun interrupt enable Please see the explanation of ROVRF in DFSDM_FLTxISR.
$00000010 constant DFSDM1_DFSDM_FLT2CR2_AWDIE                       \ Analog watchdog interrupt enable Please see the explanation of AWDF in DFSDM_FLTxISR.
$00000020 constant DFSDM1_DFSDM_FLT2CR2_SCDIE                       \ Short-circuit detector interrupt enable Please see the explanation of SCDF[7:0] in DFSDM_FLTxISR. Note: SCDIE is present only in DFSDM_FLT0CR2 register (filter x=0)
$00000040 constant DFSDM1_DFSDM_FLT2CR2_CKABIE                      \ Clock absence interrupt enable Please see the explanation of CKABF[7:0] in DFSDM_FLTxISR. Note: CKABIE is present only in DFSDM_FLT0CR2 register (filter x=0)
$0000ff00 constant DFSDM1_DFSDM_FLT2CR2_EXCH                        \ Extremes detector channel selection These bits select the input channels to be taken by the Extremes detector. EXCH[y] = 0: Extremes detector does not accept data from channel y EXCH[y] = 1: Extremes detector accepts data from channel y
$00ff0000 constant DFSDM1_DFSDM_FLT2CR2_AWDCH                       \ Analog watchdog channel selection These bits select the input channel to be guarded continuously by the analog watchdog. AWDCH[y] = 0: Analog watchdog is disabled on channel y AWDCH[y] = 1: Analog watchdog is enabled on channel y


\
\ @brief End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
\ Address offset: 0x208
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM1_DFSDM_FLT2ISR_JEOCF                       \ End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
$00000002 constant DFSDM1_DFSDM_FLT2ISR_REOCF                       \ End of regular conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxRDATAR.
$00000004 constant DFSDM1_DFSDM_FLT2ISR_JOVRF                       \ Injected conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRJOVRF bit in the DFSDM_FLTxICR register.
$00000008 constant DFSDM1_DFSDM_FLT2ISR_ROVRF                       \ Regular conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRROVRF bit in the DFSDM_FLTxICR register.
$00000010 constant DFSDM1_DFSDM_FLT2ISR_AWDF                        \ Analog watchdog This bit is set by hardware. It is cleared by software by clearing all source flag bits AWHTF[7:0] and AWLTF[7:0] in DFSDM_FLTxAWSR register (by writing '1â into the clear bits in DFSDM_FLTxAWCFR register).
$00002000 constant DFSDM1_DFSDM_FLT2ISR_JCIP                        \ Injected conversion in progress status A request to start an injected conversion is ignored when JCIP=1.
$00004000 constant DFSDM1_DFSDM_FLT2ISR_RCIP                        \ Regular conversion in progress status A request to start a regular conversion is ignored when RCIP=1.
$00ff0000 constant DFSDM1_DFSDM_FLT2ISR_CKABF                       \ Clock absence flag CKABF[y]=0: Clock signal on channel y is present. CKABF[y]=1: Clock signal on channel y is not present. Given y bit is set by hardware when clock absence is detected on channel y. It is held at CKABF[y]=1 state by hardware when CHEN=0 (see DFSDM_CHyCFGR1 register). It is held at CKABF[y]=1 state by hardware when the transceiver is not yet synchronized.It can be cleared by software using the corresponding CLRCKABF[y] bit in the DFSDM_FLTxICR register. Note: CKABF[7:0] is present only in DFSDM_FLT0ISR register (filter x=0)
$ff000000 constant DFSDM1_DFSDM_FLT2ISR_SCDF                        \ short-circuit detector flag SDCF[y]=0: No short-circuit detector event occurred on channel y SDCF[y]=1: The short-circuit detector counter reaches, on channel y, the value programmed in the DFSDM_CHyAWSCDR registers This bit is set by hardware. It can be cleared by software using the corresponding CLRSCDF[y] bit in the DFSDM_FLTxICR register. SCDF[y] is cleared also by hardware when CHEN[y] = 0 (given channel is disabled). Note: SCDF[7:0] is present only in DFSDM_FLT0ISR register (filter x=0)


\
\ @brief Clear the injected conversion overrun flag
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM1_DFSDM_FLT2ICR_CLRJOVRF                    \ Clear the injected conversion overrun flag
$00000008 constant DFSDM1_DFSDM_FLT2ICR_CLRROVRF                    \ Clear the regular conversion overrun flag
$00ff0000 constant DFSDM1_DFSDM_FLT2ICR_CLRCKABF                    \ Clear the clock absence flag CLRCKABF[y]=0: Writing '0â has no effect CLRCKABF[y]=1: Writing '1â to position y clears the corresponding CKABF[y] bit in the DFSDM_FLTxISR register. When the transceiver is not yet synchronized, the clock absence flag is set and cannot be cleared by CLRCKABF[y]. Note: CLRCKABF[7:0] is present only in DFSDM_FLT0ICR register (filter x=0)
$ff000000 constant DFSDM1_DFSDM_FLT2ICR_CLRSCDF                     \ Clear the short-circuit detector flag CLRSCDF[y]=0: Writing '0â has no effect CLRSCDF[y]=1: Writing '1â to position y clears the corresponding SCDF[y] bit in the DFSDM_FLTxISR register Note: CLRSCDF[7:0] is present only in DFSDM_FLT0ICR register (filter x=0)


\
\ @brief Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
\ Address offset: 0x210
\ Reset value: 0x00000001
\

$000000ff constant DFSDM1_DFSDM_FLT2JCHGR_JCHG                      \ Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.


\
\ @brief Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT2FCR_IOSR                        \ Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
$03ff0000 constant DFSDM1_DFSDM_FLT2FCR_FOSR                        \ Sinc filter oversampling ratio (decimation rate) number is also the decimation ratio of the output data rate from filter. This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If FOSR = 0, then the filter has no effect (filter bypass). 0 - 1023: Defines the length of the Sinc type filter in the range 1 - 1024 (FOSR = FOSR[9:0] +1). This
$e0000000 constant DFSDM1_DFSDM_FLT2FCR_FORD                        \ Sinc filter order 2: Sinc2 filter type 3: Sinc3 filter type 4: Sinc4 filter type 5: Sinc5 filter type 6-7: Reserved Sincx filter type transfer function: FastSinc filter type transfer function: This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1).


\
\ @brief Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT2JDATAR_JDATACH                  \ Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
$ffffff00 constant DFSDM1_DFSDM_FLT2JDATAR_JDATA                    \ Injected group conversion data When each conversion of a channel in the injected group finishes, its resulting data is stored in this field. The data is valid when JEOCF=1. Reading this register clears the corresponding JEOCF.


\
\ @brief Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT2RDATAR_RDATACH                  \ Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
$00000010 constant DFSDM1_DFSDM_FLT2RDATAR_RPEND                    \ Regular channel pending data Regular data in RDATA[23:0] was delayed due to an injected channel trigger during the conversion
$ffffff00 constant DFSDM1_DFSDM_FLT2RDATAR_RDATA                    \ Regular channel conversion data When each regular conversion finishes, its data is stored in this register. The data is valid when REOCF=1. Reading this register clears the corresponding REOCF.


\
\ @brief Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT2AWHTR_BKAWH                     \ Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
$ffffff00 constant DFSDM1_DFSDM_FLT2AWHTR_AWHT                      \ Analog watchdog high threshold These bits are written by software to define the high threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), the higher 16 bits (AWHT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWHT[7:0] are not taken into comparison in this case.


\
\ @brief Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT2AWLTR_BKAWL                     \ Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
$ffffff00 constant DFSDM1_DFSDM_FLT2AWLTR_AWLT                      \ Analog watchdog low threshold These bits are written by software to define the low threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), only the higher 16 bits (AWLT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWLT[7:0] are not taken into comparison in this case.


\
\ @brief Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT2AWSR_AWLTF                      \ Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
$0000ff00 constant DFSDM1_DFSDM_FLT2AWSR_AWHTF                      \ Analog watchdog high threshold flag AWHTF[y]=1 indicates a high threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWHTF[y] bit in the DFSDM_FLTxAWCFR register.


\
\ @brief Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT2AWCFR_CLRAWLTF                  \ Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
$0000ff00 constant DFSDM1_DFSDM_FLT2AWCFR_CLRAWHTF                  \ Clear the analog watchdog high threshold flag CLRAWHTF[y]=0: Writing '0â has no effect CLRAWHTF[y]=1: Writing '1â to position y clears the corresponding AWHTF[y] bit in the DFSDM_FLTxAWSR register


\
\ @brief Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
\ Address offset: 0x230
\ Reset value: 0x80000000
\

$00000007 constant DFSDM1_DFSDM_FLT2EXMAX_EXMAXCH                   \ Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
$ffffff00 constant DFSDM1_DFSDM_FLT2EXMAX_EXMAX                     \ Extremes detector maximum value These bits are set by hardware and indicate the highest value converted by DFSDM_FLTx. EXMAX[23:0] bits are reset to value (0x800000) by reading of this register.


\
\ @brief Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
\ Address offset: 0x234
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM1_DFSDM_FLT2EXMIN_EXMINCH                   \ Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
$ffffff00 constant DFSDM1_DFSDM_FLT2EXMIN_EXMIN                     \ Extremes detector minimum value These bits are set by hardware and indicate the lowest value converted by DFSDM_FLTx. EXMIN[23:0] bits are reset to value (0x7FFFFF) by reading of this register.


\
\ @brief 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
\ Address offset: 0x238
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM1_DFSDM_FLT2CNVTIMR_CNVCNT                  \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.


\
\ @brief DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT3CR1_DFEN                        \ DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
$00000002 constant DFSDM1_DFSDM_FLT3CR1_JSWSTART                    \ Start a conversion of the injected group of channels This bit is always read as '0â.
$00000008 constant DFSDM1_DFSDM_FLT3CR1_JSYNC                       \ Launch an injected conversion synchronously with the DFSDM_FLT0 JSWSTART trigger This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00000010 constant DFSDM1_DFSDM_FLT3CR1_JSCAN                       \ Scanning conversion mode for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Writing JCHG if JSCAN=0 resets the channel selection to the lowest selected channel.
$00000020 constant DFSDM1_DFSDM_FLT3CR1_JDMAEN                      \ DMA channel enabled to read data for the injected channel group This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00001f00 constant DFSDM1_DFSDM_FLT3CR1_JEXTSEL                     \ Trigger signal selection for launching injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Note: synchronous trigger has latency up to one fDFSDMCLK clock cycle (with deterministic jitter), asynchronous trigger has latency 2-3 fDFSDMCLK clock cycles (with jitter up to 1 cycle). DFSDM_FLTx 0x00 dfsdm_jtrg0 0x01 dfsdm_jtrg1 ... 0x1E dfsdm_jtrg30 0x1F dfsdm_jtrg31 Refer to . 0x0-0x1F: Trigger inputs selected by the following table (internal or external trigger).
$00006000 constant DFSDM1_DFSDM_FLT3CR1_JEXTEN                      \ Trigger enable and trigger edge selection for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00020000 constant DFSDM1_DFSDM_FLT3CR1_RSWSTART                    \ Software start of a conversion on the regular channel This bit is always read as '0â.
$00040000 constant DFSDM1_DFSDM_FLT3CR1_RCONT                       \ Continuous mode selection for regular conversions Writing '0â to this bit while a continuous regular conversion is already in progress stops the continuous mode immediately.
$00080000 constant DFSDM1_DFSDM_FLT3CR1_RSYNC                       \ Launch regular conversion synchronously with DFSDM_FLT0 This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00200000 constant DFSDM1_DFSDM_FLT3CR1_RDMAEN                      \ DMA channel enabled to read data for the regular conversion This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$07000000 constant DFSDM1_DFSDM_FLT3CR1_RCH                         \ Regular channel selection ... 7: Channel 7 is selected as the regular channel Writing these bits when RCIP=1 takes effect when the next regular conversion begins. This is especially useful in continuous mode (when RCONT=1). It also affects regular conversions which are pending (due to ongoing injected conversion).
$20000000 constant DFSDM1_DFSDM_FLT3CR1_FAST                        \ Fast conversion mode selection for regular conversions When converting a regular conversion in continuous mode, having enabled the fast mode causes each conversion (except the first) to execute faster than in standard mode. This bit has no effect on conversions which are not continuous. This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): t = IOSR / fCKIN (... but CNVCNT=0) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input.
$40000000 constant DFSDM1_DFSDM_FLT3CR1_AWFSEL                      \ Analog watchdog fast mode select


\
\ @brief Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT3CR2_JEOCIE                      \ Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
$00000002 constant DFSDM1_DFSDM_FLT3CR2_REOCIE                      \ Regular end of conversion interrupt enable Please see the explanation of REOCF in DFSDM_FLTxISR.
$00000004 constant DFSDM1_DFSDM_FLT3CR2_JOVRIE                      \ Injected data overrun interrupt enable Please see the explanation of JOVRF in DFSDM_FLTxISR.
$00000008 constant DFSDM1_DFSDM_FLT3CR2_ROVRIE                      \ Regular data overrun interrupt enable Please see the explanation of ROVRF in DFSDM_FLTxISR.
$00000010 constant DFSDM1_DFSDM_FLT3CR2_AWDIE                       \ Analog watchdog interrupt enable Please see the explanation of AWDF in DFSDM_FLTxISR.
$00000020 constant DFSDM1_DFSDM_FLT3CR2_SCDIE                       \ Short-circuit detector interrupt enable Please see the explanation of SCDF[7:0] in DFSDM_FLTxISR. Note: SCDIE is present only in DFSDM_FLT0CR2 register (filter x=0)
$00000040 constant DFSDM1_DFSDM_FLT3CR2_CKABIE                      \ Clock absence interrupt enable Please see the explanation of CKABF[7:0] in DFSDM_FLTxISR. Note: CKABIE is present only in DFSDM_FLT0CR2 register (filter x=0)
$0000ff00 constant DFSDM1_DFSDM_FLT3CR2_EXCH                        \ Extremes detector channel selection These bits select the input channels to be taken by the Extremes detector. EXCH[y] = 0: Extremes detector does not accept data from channel y EXCH[y] = 1: Extremes detector accepts data from channel y
$00ff0000 constant DFSDM1_DFSDM_FLT3CR2_AWDCH                       \ Analog watchdog channel selection These bits select the input channel to be guarded continuously by the analog watchdog. AWDCH[y] = 0: Analog watchdog is disabled on channel y AWDCH[y] = 1: Analog watchdog is enabled on channel y


\
\ @brief End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
\ Address offset: 0x288
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM1_DFSDM_FLT3ISR_JEOCF                       \ End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
$00000002 constant DFSDM1_DFSDM_FLT3ISR_REOCF                       \ End of regular conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxRDATAR.
$00000004 constant DFSDM1_DFSDM_FLT3ISR_JOVRF                       \ Injected conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRJOVRF bit in the DFSDM_FLTxICR register.
$00000008 constant DFSDM1_DFSDM_FLT3ISR_ROVRF                       \ Regular conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRROVRF bit in the DFSDM_FLTxICR register.
$00000010 constant DFSDM1_DFSDM_FLT3ISR_AWDF                        \ Analog watchdog This bit is set by hardware. It is cleared by software by clearing all source flag bits AWHTF[7:0] and AWLTF[7:0] in DFSDM_FLTxAWSR register (by writing '1â into the clear bits in DFSDM_FLTxAWCFR register).
$00002000 constant DFSDM1_DFSDM_FLT3ISR_JCIP                        \ Injected conversion in progress status A request to start an injected conversion is ignored when JCIP=1.
$00004000 constant DFSDM1_DFSDM_FLT3ISR_RCIP                        \ Regular conversion in progress status A request to start a regular conversion is ignored when RCIP=1.
$00ff0000 constant DFSDM1_DFSDM_FLT3ISR_CKABF                       \ Clock absence flag CKABF[y]=0: Clock signal on channel y is present. CKABF[y]=1: Clock signal on channel y is not present. Given y bit is set by hardware when clock absence is detected on channel y. It is held at CKABF[y]=1 state by hardware when CHEN=0 (see DFSDM_CHyCFGR1 register). It is held at CKABF[y]=1 state by hardware when the transceiver is not yet synchronized.It can be cleared by software using the corresponding CLRCKABF[y] bit in the DFSDM_FLTxICR register. Note: CKABF[7:0] is present only in DFSDM_FLT0ISR register (filter x=0)
$ff000000 constant DFSDM1_DFSDM_FLT3ISR_SCDF                        \ short-circuit detector flag SDCF[y]=0: No short-circuit detector event occurred on channel y SDCF[y]=1: The short-circuit detector counter reaches, on channel y, the value programmed in the DFSDM_CHyAWSCDR registers This bit is set by hardware. It can be cleared by software using the corresponding CLRSCDF[y] bit in the DFSDM_FLTxICR register. SCDF[y] is cleared also by hardware when CHEN[y] = 0 (given channel is disabled). Note: SCDF[7:0] is present only in DFSDM_FLT0ISR register (filter x=0)


\
\ @brief Clear the injected conversion overrun flag
\ Address offset: 0x28C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM1_DFSDM_FLT3ICR_CLRJOVRF                    \ Clear the injected conversion overrun flag
$00000008 constant DFSDM1_DFSDM_FLT3ICR_CLRROVRF                    \ Clear the regular conversion overrun flag
$00ff0000 constant DFSDM1_DFSDM_FLT3ICR_CLRCKABF                    \ Clear the clock absence flag CLRCKABF[y]=0: Writing '0â has no effect CLRCKABF[y]=1: Writing '1â to position y clears the corresponding CKABF[y] bit in the DFSDM_FLTxISR register. When the transceiver is not yet synchronized, the clock absence flag is set and cannot be cleared by CLRCKABF[y]. Note: CLRCKABF[7:0] is present only in DFSDM_FLT0ICR register (filter x=0)
$ff000000 constant DFSDM1_DFSDM_FLT3ICR_CLRSCDF                     \ Clear the short-circuit detector flag CLRSCDF[y]=0: Writing '0â has no effect CLRSCDF[y]=1: Writing '1â to position y clears the corresponding SCDF[y] bit in the DFSDM_FLTxISR register Note: CLRSCDF[7:0] is present only in DFSDM_FLT0ICR register (filter x=0)


\
\ @brief Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
\ Address offset: 0x290
\ Reset value: 0x00000001
\

$000000ff constant DFSDM1_DFSDM_FLT3JCHGR_JCHG                      \ Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.


\
\ @brief Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
\ Address offset: 0x294
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT3FCR_IOSR                        \ Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
$03ff0000 constant DFSDM1_DFSDM_FLT3FCR_FOSR                        \ Sinc filter oversampling ratio (decimation rate) number is also the decimation ratio of the output data rate from filter. This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If FOSR = 0, then the filter has no effect (filter bypass). 0 - 1023: Defines the length of the Sinc type filter in the range 1 - 1024 (FOSR = FOSR[9:0] +1). This
$e0000000 constant DFSDM1_DFSDM_FLT3FCR_FORD                        \ Sinc filter order 2: Sinc2 filter type 3: Sinc3 filter type 4: Sinc4 filter type 5: Sinc5 filter type 6-7: Reserved Sincx filter type transfer function: FastSinc filter type transfer function: This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1).


\
\ @brief Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
\ Address offset: 0x298
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT3JDATAR_JDATACH                  \ Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
$ffffff00 constant DFSDM1_DFSDM_FLT3JDATAR_JDATA                    \ Injected group conversion data When each conversion of a channel in the injected group finishes, its resulting data is stored in this field. The data is valid when JEOCF=1. Reading this register clears the corresponding JEOCF.


\
\ @brief Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
\ Address offset: 0x29C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT3RDATAR_RDATACH                  \ Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
$00000010 constant DFSDM1_DFSDM_FLT3RDATAR_RPEND                    \ Regular channel pending data Regular data in RDATA[23:0] was delayed due to an injected channel trigger during the conversion
$ffffff00 constant DFSDM1_DFSDM_FLT3RDATAR_RDATA                    \ Regular channel conversion data When each regular conversion finishes, its data is stored in this register. The data is valid when REOCF=1. Reading this register clears the corresponding REOCF.


\
\ @brief Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
\ Address offset: 0x2A0
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT3AWHTR_BKAWH                     \ Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
$ffffff00 constant DFSDM1_DFSDM_FLT3AWHTR_AWHT                      \ Analog watchdog high threshold These bits are written by software to define the high threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), the higher 16 bits (AWHT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWHT[7:0] are not taken into comparison in this case.


\
\ @brief Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
\ Address offset: 0x2A4
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT3AWLTR_BKAWL                     \ Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
$ffffff00 constant DFSDM1_DFSDM_FLT3AWLTR_AWLT                      \ Analog watchdog low threshold These bits are written by software to define the low threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), only the higher 16 bits (AWLT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWLT[7:0] are not taken into comparison in this case.


\
\ @brief Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
\ Address offset: 0x2A8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT3AWSR_AWLTF                      \ Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
$0000ff00 constant DFSDM1_DFSDM_FLT3AWSR_AWHTF                      \ Analog watchdog high threshold flag AWHTF[y]=1 indicates a high threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWHTF[y] bit in the DFSDM_FLTxAWCFR register.


\
\ @brief Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
\ Address offset: 0x2AC
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT3AWCFR_CLRAWLTF                  \ Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
$0000ff00 constant DFSDM1_DFSDM_FLT3AWCFR_CLRAWHTF                  \ Clear the analog watchdog high threshold flag CLRAWHTF[y]=0: Writing '0â has no effect CLRAWHTF[y]=1: Writing '1â to position y clears the corresponding AWHTF[y] bit in the DFSDM_FLTxAWSR register


\
\ @brief Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
\ Address offset: 0x2B0
\ Reset value: 0x80000000
\

$00000007 constant DFSDM1_DFSDM_FLT3EXMAX_EXMAXCH                   \ Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
$ffffff00 constant DFSDM1_DFSDM_FLT3EXMAX_EXMAX                     \ Extremes detector maximum value These bits are set by hardware and indicate the highest value converted by DFSDM_FLTx. EXMAX[23:0] bits are reset to value (0x800000) by reading of this register.


\
\ @brief Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
\ Address offset: 0x2B4
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM1_DFSDM_FLT3EXMIN_EXMINCH                   \ Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
$ffffff00 constant DFSDM1_DFSDM_FLT3EXMIN_EXMIN                     \ Extremes detector minimum value These bits are set by hardware and indicate the lowest value converted by DFSDM_FLTx. EXMIN[23:0] bits are reset to value (0x7FFFFF) by reading of this register.


\
\ @brief 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
\ Address offset: 0x2B8
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM1_DFSDM_FLT3CNVTIMR_CNVCNT                  \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.


\
\ @brief DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT4CR1_DFEN                        \ DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
$00000002 constant DFSDM1_DFSDM_FLT4CR1_JSWSTART                    \ Start a conversion of the injected group of channels This bit is always read as '0â.
$00000008 constant DFSDM1_DFSDM_FLT4CR1_JSYNC                       \ Launch an injected conversion synchronously with the DFSDM_FLT0 JSWSTART trigger This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00000010 constant DFSDM1_DFSDM_FLT4CR1_JSCAN                       \ Scanning conversion mode for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Writing JCHG if JSCAN=0 resets the channel selection to the lowest selected channel.
$00000020 constant DFSDM1_DFSDM_FLT4CR1_JDMAEN                      \ DMA channel enabled to read data for the injected channel group This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00001f00 constant DFSDM1_DFSDM_FLT4CR1_JEXTSEL                     \ Trigger signal selection for launching injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Note: synchronous trigger has latency up to one fDFSDMCLK clock cycle (with deterministic jitter), asynchronous trigger has latency 2-3 fDFSDMCLK clock cycles (with jitter up to 1 cycle). DFSDM_FLTx 0x00 dfsdm_jtrg0 0x01 dfsdm_jtrg1 ... 0x1E dfsdm_jtrg30 0x1F dfsdm_jtrg31 Refer to . 0x0-0x1F: Trigger inputs selected by the following table (internal or external trigger).
$00006000 constant DFSDM1_DFSDM_FLT4CR1_JEXTEN                      \ Trigger enable and trigger edge selection for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00020000 constant DFSDM1_DFSDM_FLT4CR1_RSWSTART                    \ Software start of a conversion on the regular channel This bit is always read as '0â.
$00040000 constant DFSDM1_DFSDM_FLT4CR1_RCONT                       \ Continuous mode selection for regular conversions Writing '0â to this bit while a continuous regular conversion is already in progress stops the continuous mode immediately.
$00080000 constant DFSDM1_DFSDM_FLT4CR1_RSYNC                       \ Launch regular conversion synchronously with DFSDM_FLT0 This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00200000 constant DFSDM1_DFSDM_FLT4CR1_RDMAEN                      \ DMA channel enabled to read data for the regular conversion This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$07000000 constant DFSDM1_DFSDM_FLT4CR1_RCH                         \ Regular channel selection ... 7: Channel 7 is selected as the regular channel Writing these bits when RCIP=1 takes effect when the next regular conversion begins. This is especially useful in continuous mode (when RCONT=1). It also affects regular conversions which are pending (due to ongoing injected conversion).
$20000000 constant DFSDM1_DFSDM_FLT4CR1_FAST                        \ Fast conversion mode selection for regular conversions When converting a regular conversion in continuous mode, having enabled the fast mode causes each conversion (except the first) to execute faster than in standard mode. This bit has no effect on conversions which are not continuous. This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): t = IOSR / fCKIN (... but CNVCNT=0) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input.
$40000000 constant DFSDM1_DFSDM_FLT4CR1_AWFSEL                      \ Analog watchdog fast mode select


\
\ @brief Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT4CR2_JEOCIE                      \ Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
$00000002 constant DFSDM1_DFSDM_FLT4CR2_REOCIE                      \ Regular end of conversion interrupt enable Please see the explanation of REOCF in DFSDM_FLTxISR.
$00000004 constant DFSDM1_DFSDM_FLT4CR2_JOVRIE                      \ Injected data overrun interrupt enable Please see the explanation of JOVRF in DFSDM_FLTxISR.
$00000008 constant DFSDM1_DFSDM_FLT4CR2_ROVRIE                      \ Regular data overrun interrupt enable Please see the explanation of ROVRF in DFSDM_FLTxISR.
$00000010 constant DFSDM1_DFSDM_FLT4CR2_AWDIE                       \ Analog watchdog interrupt enable Please see the explanation of AWDF in DFSDM_FLTxISR.
$00000020 constant DFSDM1_DFSDM_FLT4CR2_SCDIE                       \ Short-circuit detector interrupt enable Please see the explanation of SCDF[7:0] in DFSDM_FLTxISR. Note: SCDIE is present only in DFSDM_FLT0CR2 register (filter x=0)
$00000040 constant DFSDM1_DFSDM_FLT4CR2_CKABIE                      \ Clock absence interrupt enable Please see the explanation of CKABF[7:0] in DFSDM_FLTxISR. Note: CKABIE is present only in DFSDM_FLT0CR2 register (filter x=0)
$0000ff00 constant DFSDM1_DFSDM_FLT4CR2_EXCH                        \ Extremes detector channel selection These bits select the input channels to be taken by the Extremes detector. EXCH[y] = 0: Extremes detector does not accept data from channel y EXCH[y] = 1: Extremes detector accepts data from channel y
$00ff0000 constant DFSDM1_DFSDM_FLT4CR2_AWDCH                       \ Analog watchdog channel selection These bits select the input channel to be guarded continuously by the analog watchdog. AWDCH[y] = 0: Analog watchdog is disabled on channel y AWDCH[y] = 1: Analog watchdog is enabled on channel y


\
\ @brief End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
\ Address offset: 0x308
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM1_DFSDM_FLT4ISR_JEOCF                       \ End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
$00000002 constant DFSDM1_DFSDM_FLT4ISR_REOCF                       \ End of regular conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxRDATAR.
$00000004 constant DFSDM1_DFSDM_FLT4ISR_JOVRF                       \ Injected conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRJOVRF bit in the DFSDM_FLTxICR register.
$00000008 constant DFSDM1_DFSDM_FLT4ISR_ROVRF                       \ Regular conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRROVRF bit in the DFSDM_FLTxICR register.
$00000010 constant DFSDM1_DFSDM_FLT4ISR_AWDF                        \ Analog watchdog This bit is set by hardware. It is cleared by software by clearing all source flag bits AWHTF[7:0] and AWLTF[7:0] in DFSDM_FLTxAWSR register (by writing '1â into the clear bits in DFSDM_FLTxAWCFR register).
$00002000 constant DFSDM1_DFSDM_FLT4ISR_JCIP                        \ Injected conversion in progress status A request to start an injected conversion is ignored when JCIP=1.
$00004000 constant DFSDM1_DFSDM_FLT4ISR_RCIP                        \ Regular conversion in progress status A request to start a regular conversion is ignored when RCIP=1.
$00ff0000 constant DFSDM1_DFSDM_FLT4ISR_CKABF                       \ Clock absence flag CKABF[y]=0: Clock signal on channel y is present. CKABF[y]=1: Clock signal on channel y is not present. Given y bit is set by hardware when clock absence is detected on channel y. It is held at CKABF[y]=1 state by hardware when CHEN=0 (see DFSDM_CHyCFGR1 register). It is held at CKABF[y]=1 state by hardware when the transceiver is not yet synchronized.It can be cleared by software using the corresponding CLRCKABF[y] bit in the DFSDM_FLTxICR register. Note: CKABF[7:0] is present only in DFSDM_FLT0ISR register (filter x=0)
$ff000000 constant DFSDM1_DFSDM_FLT4ISR_SCDF                        \ short-circuit detector flag SDCF[y]=0: No short-circuit detector event occurred on channel y SDCF[y]=1: The short-circuit detector counter reaches, on channel y, the value programmed in the DFSDM_CHyAWSCDR registers This bit is set by hardware. It can be cleared by software using the corresponding CLRSCDF[y] bit in the DFSDM_FLTxICR register. SCDF[y] is cleared also by hardware when CHEN[y] = 0 (given channel is disabled). Note: SCDF[7:0] is present only in DFSDM_FLT0ISR register (filter x=0)


\
\ @brief Clear the injected conversion overrun flag
\ Address offset: 0x30C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM1_DFSDM_FLT4ICR_CLRJOVRF                    \ Clear the injected conversion overrun flag
$00000008 constant DFSDM1_DFSDM_FLT4ICR_CLRROVRF                    \ Clear the regular conversion overrun flag
$00ff0000 constant DFSDM1_DFSDM_FLT4ICR_CLRCKABF                    \ Clear the clock absence flag CLRCKABF[y]=0: Writing '0â has no effect CLRCKABF[y]=1: Writing '1â to position y clears the corresponding CKABF[y] bit in the DFSDM_FLTxISR register. When the transceiver is not yet synchronized, the clock absence flag is set and cannot be cleared by CLRCKABF[y]. Note: CLRCKABF[7:0] is present only in DFSDM_FLT0ICR register (filter x=0)
$ff000000 constant DFSDM1_DFSDM_FLT4ICR_CLRSCDF                     \ Clear the short-circuit detector flag CLRSCDF[y]=0: Writing '0â has no effect CLRSCDF[y]=1: Writing '1â to position y clears the corresponding SCDF[y] bit in the DFSDM_FLTxISR register Note: CLRSCDF[7:0] is present only in DFSDM_FLT0ICR register (filter x=0)


\
\ @brief Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
\ Address offset: 0x310
\ Reset value: 0x00000001
\

$000000ff constant DFSDM1_DFSDM_FLT4JCHGR_JCHG                      \ Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.


\
\ @brief Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT4FCR_IOSR                        \ Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
$03ff0000 constant DFSDM1_DFSDM_FLT4FCR_FOSR                        \ Sinc filter oversampling ratio (decimation rate) number is also the decimation ratio of the output data rate from filter. This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If FOSR = 0, then the filter has no effect (filter bypass). 0 - 1023: Defines the length of the Sinc type filter in the range 1 - 1024 (FOSR = FOSR[9:0] +1). This
$e0000000 constant DFSDM1_DFSDM_FLT4FCR_FORD                        \ Sinc filter order 2: Sinc2 filter type 3: Sinc3 filter type 4: Sinc4 filter type 5: Sinc5 filter type 6-7: Reserved Sincx filter type transfer function: FastSinc filter type transfer function: This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1).


\
\ @brief Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT4JDATAR_JDATACH                  \ Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
$ffffff00 constant DFSDM1_DFSDM_FLT4JDATAR_JDATA                    \ Injected group conversion data When each conversion of a channel in the injected group finishes, its resulting data is stored in this field. The data is valid when JEOCF=1. Reading this register clears the corresponding JEOCF.


\
\ @brief Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT4RDATAR_RDATACH                  \ Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
$00000010 constant DFSDM1_DFSDM_FLT4RDATAR_RPEND                    \ Regular channel pending data Regular data in RDATA[23:0] was delayed due to an injected channel trigger during the conversion
$ffffff00 constant DFSDM1_DFSDM_FLT4RDATAR_RDATA                    \ Regular channel conversion data When each regular conversion finishes, its data is stored in this register. The data is valid when REOCF=1. Reading this register clears the corresponding REOCF.


\
\ @brief Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT4AWHTR_BKAWH                     \ Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
$ffffff00 constant DFSDM1_DFSDM_FLT4AWHTR_AWHT                      \ Analog watchdog high threshold These bits are written by software to define the high threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), the higher 16 bits (AWHT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWHT[7:0] are not taken into comparison in this case.


\
\ @brief Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
\ Address offset: 0x324
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT4AWLTR_BKAWL                     \ Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
$ffffff00 constant DFSDM1_DFSDM_FLT4AWLTR_AWLT                      \ Analog watchdog low threshold These bits are written by software to define the low threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), only the higher 16 bits (AWLT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWLT[7:0] are not taken into comparison in this case.


\
\ @brief Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT4AWSR_AWLTF                      \ Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
$0000ff00 constant DFSDM1_DFSDM_FLT4AWSR_AWHTF                      \ Analog watchdog high threshold flag AWHTF[y]=1 indicates a high threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWHTF[y] bit in the DFSDM_FLTxAWCFR register.


\
\ @brief Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
\ Address offset: 0x32C
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT4AWCFR_CLRAWLTF                  \ Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
$0000ff00 constant DFSDM1_DFSDM_FLT4AWCFR_CLRAWHTF                  \ Clear the analog watchdog high threshold flag CLRAWHTF[y]=0: Writing '0â has no effect CLRAWHTF[y]=1: Writing '1â to position y clears the corresponding AWHTF[y] bit in the DFSDM_FLTxAWSR register


\
\ @brief Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
\ Address offset: 0x330
\ Reset value: 0x80000000
\

$00000007 constant DFSDM1_DFSDM_FLT4EXMAX_EXMAXCH                   \ Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
$ffffff00 constant DFSDM1_DFSDM_FLT4EXMAX_EXMAX                     \ Extremes detector maximum value These bits are set by hardware and indicate the highest value converted by DFSDM_FLTx. EXMAX[23:0] bits are reset to value (0x800000) by reading of this register.


\
\ @brief Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
\ Address offset: 0x334
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM1_DFSDM_FLT4EXMIN_EXMINCH                   \ Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
$ffffff00 constant DFSDM1_DFSDM_FLT4EXMIN_EXMIN                     \ Extremes detector minimum value These bits are set by hardware and indicate the lowest value converted by DFSDM_FLTx. EXMIN[23:0] bits are reset to value (0x7FFFFF) by reading of this register.


\
\ @brief 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
\ Address offset: 0x338
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM1_DFSDM_FLT4CNVTIMR_CNVCNT                  \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.


\
\ @brief DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
\ Address offset: 0x380
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT5CR1_DFEN                        \ DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
$00000002 constant DFSDM1_DFSDM_FLT5CR1_JSWSTART                    \ Start a conversion of the injected group of channels This bit is always read as '0â.
$00000008 constant DFSDM1_DFSDM_FLT5CR1_JSYNC                       \ Launch an injected conversion synchronously with the DFSDM_FLT0 JSWSTART trigger This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00000010 constant DFSDM1_DFSDM_FLT5CR1_JSCAN                       \ Scanning conversion mode for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Writing JCHG if JSCAN=0 resets the channel selection to the lowest selected channel.
$00000020 constant DFSDM1_DFSDM_FLT5CR1_JDMAEN                      \ DMA channel enabled to read data for the injected channel group This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00001f00 constant DFSDM1_DFSDM_FLT5CR1_JEXTSEL                     \ Trigger signal selection for launching injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Note: synchronous trigger has latency up to one fDFSDMCLK clock cycle (with deterministic jitter), asynchronous trigger has latency 2-3 fDFSDMCLK clock cycles (with jitter up to 1 cycle). DFSDM_FLTx 0x00 dfsdm_jtrg0 0x01 dfsdm_jtrg1 ... 0x1E dfsdm_jtrg30 0x1F dfsdm_jtrg31 Refer to . 0x0-0x1F: Trigger inputs selected by the following table (internal or external trigger).
$00006000 constant DFSDM1_DFSDM_FLT5CR1_JEXTEN                      \ Trigger enable and trigger edge selection for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00020000 constant DFSDM1_DFSDM_FLT5CR1_RSWSTART                    \ Software start of a conversion on the regular channel This bit is always read as '0â.
$00040000 constant DFSDM1_DFSDM_FLT5CR1_RCONT                       \ Continuous mode selection for regular conversions Writing '0â to this bit while a continuous regular conversion is already in progress stops the continuous mode immediately.
$00080000 constant DFSDM1_DFSDM_FLT5CR1_RSYNC                       \ Launch regular conversion synchronously with DFSDM_FLT0 This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00200000 constant DFSDM1_DFSDM_FLT5CR1_RDMAEN                      \ DMA channel enabled to read data for the regular conversion This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$07000000 constant DFSDM1_DFSDM_FLT5CR1_RCH                         \ Regular channel selection ... 7: Channel 7 is selected as the regular channel Writing these bits when RCIP=1 takes effect when the next regular conversion begins. This is especially useful in continuous mode (when RCONT=1). It also affects regular conversions which are pending (due to ongoing injected conversion).
$20000000 constant DFSDM1_DFSDM_FLT5CR1_FAST                        \ Fast conversion mode selection for regular conversions When converting a regular conversion in continuous mode, having enabled the fast mode causes each conversion (except the first) to execute faster than in standard mode. This bit has no effect on conversions which are not continuous. This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): t = IOSR / fCKIN (... but CNVCNT=0) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input.
$40000000 constant DFSDM1_DFSDM_FLT5CR1_AWFSEL                      \ Analog watchdog fast mode select


\
\ @brief Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
\ Address offset: 0x384
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT5CR2_JEOCIE                      \ Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
$00000002 constant DFSDM1_DFSDM_FLT5CR2_REOCIE                      \ Regular end of conversion interrupt enable Please see the explanation of REOCF in DFSDM_FLTxISR.
$00000004 constant DFSDM1_DFSDM_FLT5CR2_JOVRIE                      \ Injected data overrun interrupt enable Please see the explanation of JOVRF in DFSDM_FLTxISR.
$00000008 constant DFSDM1_DFSDM_FLT5CR2_ROVRIE                      \ Regular data overrun interrupt enable Please see the explanation of ROVRF in DFSDM_FLTxISR.
$00000010 constant DFSDM1_DFSDM_FLT5CR2_AWDIE                       \ Analog watchdog interrupt enable Please see the explanation of AWDF in DFSDM_FLTxISR.
$00000020 constant DFSDM1_DFSDM_FLT5CR2_SCDIE                       \ Short-circuit detector interrupt enable Please see the explanation of SCDF[7:0] in DFSDM_FLTxISR. Note: SCDIE is present only in DFSDM_FLT0CR2 register (filter x=0)
$00000040 constant DFSDM1_DFSDM_FLT5CR2_CKABIE                      \ Clock absence interrupt enable Please see the explanation of CKABF[7:0] in DFSDM_FLTxISR. Note: CKABIE is present only in DFSDM_FLT0CR2 register (filter x=0)
$0000ff00 constant DFSDM1_DFSDM_FLT5CR2_EXCH                        \ Extremes detector channel selection These bits select the input channels to be taken by the Extremes detector. EXCH[y] = 0: Extremes detector does not accept data from channel y EXCH[y] = 1: Extremes detector accepts data from channel y
$00ff0000 constant DFSDM1_DFSDM_FLT5CR2_AWDCH                       \ Analog watchdog channel selection These bits select the input channel to be guarded continuously by the analog watchdog. AWDCH[y] = 0: Analog watchdog is disabled on channel y AWDCH[y] = 1: Analog watchdog is enabled on channel y


\
\ @brief End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
\ Address offset: 0x388
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM1_DFSDM_FLT5ISR_JEOCF                       \ End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
$00000002 constant DFSDM1_DFSDM_FLT5ISR_REOCF                       \ End of regular conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxRDATAR.
$00000004 constant DFSDM1_DFSDM_FLT5ISR_JOVRF                       \ Injected conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRJOVRF bit in the DFSDM_FLTxICR register.
$00000008 constant DFSDM1_DFSDM_FLT5ISR_ROVRF                       \ Regular conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRROVRF bit in the DFSDM_FLTxICR register.
$00000010 constant DFSDM1_DFSDM_FLT5ISR_AWDF                        \ Analog watchdog This bit is set by hardware. It is cleared by software by clearing all source flag bits AWHTF[7:0] and AWLTF[7:0] in DFSDM_FLTxAWSR register (by writing '1â into the clear bits in DFSDM_FLTxAWCFR register).
$00002000 constant DFSDM1_DFSDM_FLT5ISR_JCIP                        \ Injected conversion in progress status A request to start an injected conversion is ignored when JCIP=1.
$00004000 constant DFSDM1_DFSDM_FLT5ISR_RCIP                        \ Regular conversion in progress status A request to start a regular conversion is ignored when RCIP=1.
$00ff0000 constant DFSDM1_DFSDM_FLT5ISR_CKABF                       \ Clock absence flag CKABF[y]=0: Clock signal on channel y is present. CKABF[y]=1: Clock signal on channel y is not present. Given y bit is set by hardware when clock absence is detected on channel y. It is held at CKABF[y]=1 state by hardware when CHEN=0 (see DFSDM_CHyCFGR1 register). It is held at CKABF[y]=1 state by hardware when the transceiver is not yet synchronized.It can be cleared by software using the corresponding CLRCKABF[y] bit in the DFSDM_FLTxICR register. Note: CKABF[7:0] is present only in DFSDM_FLT0ISR register (filter x=0)
$ff000000 constant DFSDM1_DFSDM_FLT5ISR_SCDF                        \ short-circuit detector flag SDCF[y]=0: No short-circuit detector event occurred on channel y SDCF[y]=1: The short-circuit detector counter reaches, on channel y, the value programmed in the DFSDM_CHyAWSCDR registers This bit is set by hardware. It can be cleared by software using the corresponding CLRSCDF[y] bit in the DFSDM_FLTxICR register. SCDF[y] is cleared also by hardware when CHEN[y] = 0 (given channel is disabled). Note: SCDF[7:0] is present only in DFSDM_FLT0ISR register (filter x=0)


\
\ @brief Clear the injected conversion overrun flag
\ Address offset: 0x38C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM1_DFSDM_FLT5ICR_CLRJOVRF                    \ Clear the injected conversion overrun flag
$00000008 constant DFSDM1_DFSDM_FLT5ICR_CLRROVRF                    \ Clear the regular conversion overrun flag
$00ff0000 constant DFSDM1_DFSDM_FLT5ICR_CLRCKABF                    \ Clear the clock absence flag CLRCKABF[y]=0: Writing '0â has no effect CLRCKABF[y]=1: Writing '1â to position y clears the corresponding CKABF[y] bit in the DFSDM_FLTxISR register. When the transceiver is not yet synchronized, the clock absence flag is set and cannot be cleared by CLRCKABF[y]. Note: CLRCKABF[7:0] is present only in DFSDM_FLT0ICR register (filter x=0)
$ff000000 constant DFSDM1_DFSDM_FLT5ICR_CLRSCDF                     \ Clear the short-circuit detector flag CLRSCDF[y]=0: Writing '0â has no effect CLRSCDF[y]=1: Writing '1â to position y clears the corresponding SCDF[y] bit in the DFSDM_FLTxISR register Note: CLRSCDF[7:0] is present only in DFSDM_FLT0ICR register (filter x=0)


\
\ @brief Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
\ Address offset: 0x390
\ Reset value: 0x00000001
\

$000000ff constant DFSDM1_DFSDM_FLT5JCHGR_JCHG                      \ Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.


\
\ @brief Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
\ Address offset: 0x394
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT5FCR_IOSR                        \ Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
$03ff0000 constant DFSDM1_DFSDM_FLT5FCR_FOSR                        \ Sinc filter oversampling ratio (decimation rate) number is also the decimation ratio of the output data rate from filter. This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If FOSR = 0, then the filter has no effect (filter bypass). 0 - 1023: Defines the length of the Sinc type filter in the range 1 - 1024 (FOSR = FOSR[9:0] +1). This
$e0000000 constant DFSDM1_DFSDM_FLT5FCR_FORD                        \ Sinc filter order 2: Sinc2 filter type 3: Sinc3 filter type 4: Sinc4 filter type 5: Sinc5 filter type 6-7: Reserved Sincx filter type transfer function: FastSinc filter type transfer function: This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1).


\
\ @brief Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
\ Address offset: 0x398
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT5JDATAR_JDATACH                  \ Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
$ffffff00 constant DFSDM1_DFSDM_FLT5JDATAR_JDATA                    \ Injected group conversion data When each conversion of a channel in the injected group finishes, its resulting data is stored in this field. The data is valid when JEOCF=1. Reading this register clears the corresponding JEOCF.


\
\ @brief Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
\ Address offset: 0x39C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT5RDATAR_RDATACH                  \ Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
$00000010 constant DFSDM1_DFSDM_FLT5RDATAR_RPEND                    \ Regular channel pending data Regular data in RDATA[23:0] was delayed due to an injected channel trigger during the conversion
$ffffff00 constant DFSDM1_DFSDM_FLT5RDATAR_RDATA                    \ Regular channel conversion data When each regular conversion finishes, its data is stored in this register. The data is valid when REOCF=1. Reading this register clears the corresponding REOCF.


\
\ @brief Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
\ Address offset: 0x3A0
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT5AWHTR_BKAWH                     \ Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
$ffffff00 constant DFSDM1_DFSDM_FLT5AWHTR_AWHT                      \ Analog watchdog high threshold These bits are written by software to define the high threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), the higher 16 bits (AWHT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWHT[7:0] are not taken into comparison in this case.


\
\ @brief Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
\ Address offset: 0x3A4
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT5AWLTR_BKAWL                     \ Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
$ffffff00 constant DFSDM1_DFSDM_FLT5AWLTR_AWLT                      \ Analog watchdog low threshold These bits are written by software to define the low threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), only the higher 16 bits (AWLT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWLT[7:0] are not taken into comparison in this case.


\
\ @brief Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
\ Address offset: 0x3A8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT5AWSR_AWLTF                      \ Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
$0000ff00 constant DFSDM1_DFSDM_FLT5AWSR_AWHTF                      \ Analog watchdog high threshold flag AWHTF[y]=1 indicates a high threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWHTF[y] bit in the DFSDM_FLTxAWCFR register.


\
\ @brief Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
\ Address offset: 0x3AC
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT5AWCFR_CLRAWLTF                  \ Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
$0000ff00 constant DFSDM1_DFSDM_FLT5AWCFR_CLRAWHTF                  \ Clear the analog watchdog high threshold flag CLRAWHTF[y]=0: Writing '0â has no effect CLRAWHTF[y]=1: Writing '1â to position y clears the corresponding AWHTF[y] bit in the DFSDM_FLTxAWSR register


\
\ @brief Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
\ Address offset: 0x3B0
\ Reset value: 0x80000000
\

$00000007 constant DFSDM1_DFSDM_FLT5EXMAX_EXMAXCH                   \ Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
$ffffff00 constant DFSDM1_DFSDM_FLT5EXMAX_EXMAX                     \ Extremes detector maximum value These bits are set by hardware and indicate the highest value converted by DFSDM_FLTx. EXMAX[23:0] bits are reset to value (0x800000) by reading of this register.


\
\ @brief Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
\ Address offset: 0x3B4
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM1_DFSDM_FLT5EXMIN_EXMINCH                   \ Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
$ffffff00 constant DFSDM1_DFSDM_FLT5EXMIN_EXMIN                     \ Extremes detector minimum value These bits are set by hardware and indicate the lowest value converted by DFSDM_FLTx. EXMIN[23:0] bits are reset to value (0x7FFFFF) by reading of this register.


\
\ @brief 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
\ Address offset: 0x3B8
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM1_DFSDM_FLT5CNVTIMR_CNVCNT                  \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.


\
\ @brief DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT6CR1_DFEN                        \ DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
$00000002 constant DFSDM1_DFSDM_FLT6CR1_JSWSTART                    \ Start a conversion of the injected group of channels This bit is always read as '0â.
$00000008 constant DFSDM1_DFSDM_FLT6CR1_JSYNC                       \ Launch an injected conversion synchronously with the DFSDM_FLT0 JSWSTART trigger This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00000010 constant DFSDM1_DFSDM_FLT6CR1_JSCAN                       \ Scanning conversion mode for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Writing JCHG if JSCAN=0 resets the channel selection to the lowest selected channel.
$00000020 constant DFSDM1_DFSDM_FLT6CR1_JDMAEN                      \ DMA channel enabled to read data for the injected channel group This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00001f00 constant DFSDM1_DFSDM_FLT6CR1_JEXTSEL                     \ Trigger signal selection for launching injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Note: synchronous trigger has latency up to one fDFSDMCLK clock cycle (with deterministic jitter), asynchronous trigger has latency 2-3 fDFSDMCLK clock cycles (with jitter up to 1 cycle). DFSDM_FLTx 0x00 dfsdm_jtrg0 0x01 dfsdm_jtrg1 ... 0x1E dfsdm_jtrg30 0x1F dfsdm_jtrg31 Refer to . 0x0-0x1F: Trigger inputs selected by the following table (internal or external trigger).
$00006000 constant DFSDM1_DFSDM_FLT6CR1_JEXTEN                      \ Trigger enable and trigger edge selection for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00020000 constant DFSDM1_DFSDM_FLT6CR1_RSWSTART                    \ Software start of a conversion on the regular channel This bit is always read as '0â.
$00040000 constant DFSDM1_DFSDM_FLT6CR1_RCONT                       \ Continuous mode selection for regular conversions Writing '0â to this bit while a continuous regular conversion is already in progress stops the continuous mode immediately.
$00080000 constant DFSDM1_DFSDM_FLT6CR1_RSYNC                       \ Launch regular conversion synchronously with DFSDM_FLT0 This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00200000 constant DFSDM1_DFSDM_FLT6CR1_RDMAEN                      \ DMA channel enabled to read data for the regular conversion This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$07000000 constant DFSDM1_DFSDM_FLT6CR1_RCH                         \ Regular channel selection ... 7: Channel 7 is selected as the regular channel Writing these bits when RCIP=1 takes effect when the next regular conversion begins. This is especially useful in continuous mode (when RCONT=1). It also affects regular conversions which are pending (due to ongoing injected conversion).
$20000000 constant DFSDM1_DFSDM_FLT6CR1_FAST                        \ Fast conversion mode selection for regular conversions When converting a regular conversion in continuous mode, having enabled the fast mode causes each conversion (except the first) to execute faster than in standard mode. This bit has no effect on conversions which are not continuous. This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): t = IOSR / fCKIN (... but CNVCNT=0) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input.
$40000000 constant DFSDM1_DFSDM_FLT6CR1_AWFSEL                      \ Analog watchdog fast mode select


\
\ @brief Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
\ Address offset: 0x404
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT6CR2_JEOCIE                      \ Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
$00000002 constant DFSDM1_DFSDM_FLT6CR2_REOCIE                      \ Regular end of conversion interrupt enable Please see the explanation of REOCF in DFSDM_FLTxISR.
$00000004 constant DFSDM1_DFSDM_FLT6CR2_JOVRIE                      \ Injected data overrun interrupt enable Please see the explanation of JOVRF in DFSDM_FLTxISR.
$00000008 constant DFSDM1_DFSDM_FLT6CR2_ROVRIE                      \ Regular data overrun interrupt enable Please see the explanation of ROVRF in DFSDM_FLTxISR.
$00000010 constant DFSDM1_DFSDM_FLT6CR2_AWDIE                       \ Analog watchdog interrupt enable Please see the explanation of AWDF in DFSDM_FLTxISR.
$00000020 constant DFSDM1_DFSDM_FLT6CR2_SCDIE                       \ Short-circuit detector interrupt enable Please see the explanation of SCDF[7:0] in DFSDM_FLTxISR. Note: SCDIE is present only in DFSDM_FLT0CR2 register (filter x=0)
$00000040 constant DFSDM1_DFSDM_FLT6CR2_CKABIE                      \ Clock absence interrupt enable Please see the explanation of CKABF[7:0] in DFSDM_FLTxISR. Note: CKABIE is present only in DFSDM_FLT0CR2 register (filter x=0)
$0000ff00 constant DFSDM1_DFSDM_FLT6CR2_EXCH                        \ Extremes detector channel selection These bits select the input channels to be taken by the Extremes detector. EXCH[y] = 0: Extremes detector does not accept data from channel y EXCH[y] = 1: Extremes detector accepts data from channel y
$00ff0000 constant DFSDM1_DFSDM_FLT6CR2_AWDCH                       \ Analog watchdog channel selection These bits select the input channel to be guarded continuously by the analog watchdog. AWDCH[y] = 0: Analog watchdog is disabled on channel y AWDCH[y] = 1: Analog watchdog is enabled on channel y


\
\ @brief End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
\ Address offset: 0x408
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM1_DFSDM_FLT6ISR_JEOCF                       \ End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
$00000002 constant DFSDM1_DFSDM_FLT6ISR_REOCF                       \ End of regular conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxRDATAR.
$00000004 constant DFSDM1_DFSDM_FLT6ISR_JOVRF                       \ Injected conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRJOVRF bit in the DFSDM_FLTxICR register.
$00000008 constant DFSDM1_DFSDM_FLT6ISR_ROVRF                       \ Regular conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRROVRF bit in the DFSDM_FLTxICR register.
$00000010 constant DFSDM1_DFSDM_FLT6ISR_AWDF                        \ Analog watchdog This bit is set by hardware. It is cleared by software by clearing all source flag bits AWHTF[7:0] and AWLTF[7:0] in DFSDM_FLTxAWSR register (by writing '1â into the clear bits in DFSDM_FLTxAWCFR register).
$00002000 constant DFSDM1_DFSDM_FLT6ISR_JCIP                        \ Injected conversion in progress status A request to start an injected conversion is ignored when JCIP=1.
$00004000 constant DFSDM1_DFSDM_FLT6ISR_RCIP                        \ Regular conversion in progress status A request to start a regular conversion is ignored when RCIP=1.
$00ff0000 constant DFSDM1_DFSDM_FLT6ISR_CKABF                       \ Clock absence flag CKABF[y]=0: Clock signal on channel y is present. CKABF[y]=1: Clock signal on channel y is not present. Given y bit is set by hardware when clock absence is detected on channel y. It is held at CKABF[y]=1 state by hardware when CHEN=0 (see DFSDM_CHyCFGR1 register). It is held at CKABF[y]=1 state by hardware when the transceiver is not yet synchronized.It can be cleared by software using the corresponding CLRCKABF[y] bit in the DFSDM_FLTxICR register. Note: CKABF[7:0] is present only in DFSDM_FLT0ISR register (filter x=0)
$ff000000 constant DFSDM1_DFSDM_FLT6ISR_SCDF                        \ short-circuit detector flag SDCF[y]=0: No short-circuit detector event occurred on channel y SDCF[y]=1: The short-circuit detector counter reaches, on channel y, the value programmed in the DFSDM_CHyAWSCDR registers This bit is set by hardware. It can be cleared by software using the corresponding CLRSCDF[y] bit in the DFSDM_FLTxICR register. SCDF[y] is cleared also by hardware when CHEN[y] = 0 (given channel is disabled). Note: SCDF[7:0] is present only in DFSDM_FLT0ISR register (filter x=0)


\
\ @brief Clear the injected conversion overrun flag
\ Address offset: 0x40C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM1_DFSDM_FLT6ICR_CLRJOVRF                    \ Clear the injected conversion overrun flag
$00000008 constant DFSDM1_DFSDM_FLT6ICR_CLRROVRF                    \ Clear the regular conversion overrun flag
$00ff0000 constant DFSDM1_DFSDM_FLT6ICR_CLRCKABF                    \ Clear the clock absence flag CLRCKABF[y]=0: Writing '0â has no effect CLRCKABF[y]=1: Writing '1â to position y clears the corresponding CKABF[y] bit in the DFSDM_FLTxISR register. When the transceiver is not yet synchronized, the clock absence flag is set and cannot be cleared by CLRCKABF[y]. Note: CLRCKABF[7:0] is present only in DFSDM_FLT0ICR register (filter x=0)
$ff000000 constant DFSDM1_DFSDM_FLT6ICR_CLRSCDF                     \ Clear the short-circuit detector flag CLRSCDF[y]=0: Writing '0â has no effect CLRSCDF[y]=1: Writing '1â to position y clears the corresponding SCDF[y] bit in the DFSDM_FLTxISR register Note: CLRSCDF[7:0] is present only in DFSDM_FLT0ICR register (filter x=0)


\
\ @brief Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
\ Address offset: 0x410
\ Reset value: 0x00000001
\

$000000ff constant DFSDM1_DFSDM_FLT6JCHGR_JCHG                      \ Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.


\
\ @brief Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
\ Address offset: 0x414
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT6FCR_IOSR                        \ Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
$03ff0000 constant DFSDM1_DFSDM_FLT6FCR_FOSR                        \ Sinc filter oversampling ratio (decimation rate) number is also the decimation ratio of the output data rate from filter. This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If FOSR = 0, then the filter has no effect (filter bypass). 0 - 1023: Defines the length of the Sinc type filter in the range 1 - 1024 (FOSR = FOSR[9:0] +1). This
$e0000000 constant DFSDM1_DFSDM_FLT6FCR_FORD                        \ Sinc filter order 2: Sinc2 filter type 3: Sinc3 filter type 4: Sinc4 filter type 5: Sinc5 filter type 6-7: Reserved Sincx filter type transfer function: FastSinc filter type transfer function: This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1).


\
\ @brief Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT6JDATAR_JDATACH                  \ Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
$ffffff00 constant DFSDM1_DFSDM_FLT6JDATAR_JDATA                    \ Injected group conversion data When each conversion of a channel in the injected group finishes, its resulting data is stored in this field. The data is valid when JEOCF=1. Reading this register clears the corresponding JEOCF.


\
\ @brief Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
\ Address offset: 0x41C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT6RDATAR_RDATACH                  \ Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
$00000010 constant DFSDM1_DFSDM_FLT6RDATAR_RPEND                    \ Regular channel pending data Regular data in RDATA[23:0] was delayed due to an injected channel trigger during the conversion
$ffffff00 constant DFSDM1_DFSDM_FLT6RDATAR_RDATA                    \ Regular channel conversion data When each regular conversion finishes, its data is stored in this register. The data is valid when REOCF=1. Reading this register clears the corresponding REOCF.


\
\ @brief Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
\ Address offset: 0x420
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT6AWHTR_BKAWH                     \ Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
$ffffff00 constant DFSDM1_DFSDM_FLT6AWHTR_AWHT                      \ Analog watchdog high threshold These bits are written by software to define the high threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), the higher 16 bits (AWHT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWHT[7:0] are not taken into comparison in this case.


\
\ @brief Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
\ Address offset: 0x424
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT6AWLTR_BKAWL                     \ Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
$ffffff00 constant DFSDM1_DFSDM_FLT6AWLTR_AWLT                      \ Analog watchdog low threshold These bits are written by software to define the low threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), only the higher 16 bits (AWLT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWLT[7:0] are not taken into comparison in this case.


\
\ @brief Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
\ Address offset: 0x428
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT6AWSR_AWLTF                      \ Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
$0000ff00 constant DFSDM1_DFSDM_FLT6AWSR_AWHTF                      \ Analog watchdog high threshold flag AWHTF[y]=1 indicates a high threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWHTF[y] bit in the DFSDM_FLTxAWCFR register.


\
\ @brief Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
\ Address offset: 0x42C
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT6AWCFR_CLRAWLTF                  \ Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
$0000ff00 constant DFSDM1_DFSDM_FLT6AWCFR_CLRAWHTF                  \ Clear the analog watchdog high threshold flag CLRAWHTF[y]=0: Writing '0â has no effect CLRAWHTF[y]=1: Writing '1â to position y clears the corresponding AWHTF[y] bit in the DFSDM_FLTxAWSR register


\
\ @brief Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
\ Address offset: 0x430
\ Reset value: 0x80000000
\

$00000007 constant DFSDM1_DFSDM_FLT6EXMAX_EXMAXCH                   \ Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
$ffffff00 constant DFSDM1_DFSDM_FLT6EXMAX_EXMAX                     \ Extremes detector maximum value These bits are set by hardware and indicate the highest value converted by DFSDM_FLTx. EXMAX[23:0] bits are reset to value (0x800000) by reading of this register.


\
\ @brief Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
\ Address offset: 0x434
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM1_DFSDM_FLT6EXMIN_EXMINCH                   \ Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
$ffffff00 constant DFSDM1_DFSDM_FLT6EXMIN_EXMIN                     \ Extremes detector minimum value These bits are set by hardware and indicate the lowest value converted by DFSDM_FLTx. EXMIN[23:0] bits are reset to value (0x7FFFFF) by reading of this register.


\
\ @brief 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
\ Address offset: 0x438
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM1_DFSDM_FLT6CNVTIMR_CNVCNT                  \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.


\
\ @brief DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
\ Address offset: 0x480
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT7CR1_DFEN                        \ DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
$00000002 constant DFSDM1_DFSDM_FLT7CR1_JSWSTART                    \ Start a conversion of the injected group of channels This bit is always read as '0â.
$00000008 constant DFSDM1_DFSDM_FLT7CR1_JSYNC                       \ Launch an injected conversion synchronously with the DFSDM_FLT0 JSWSTART trigger This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00000010 constant DFSDM1_DFSDM_FLT7CR1_JSCAN                       \ Scanning conversion mode for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Writing JCHG if JSCAN=0 resets the channel selection to the lowest selected channel.
$00000020 constant DFSDM1_DFSDM_FLT7CR1_JDMAEN                      \ DMA channel enabled to read data for the injected channel group This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00001f00 constant DFSDM1_DFSDM_FLT7CR1_JEXTSEL                     \ Trigger signal selection for launching injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Note: synchronous trigger has latency up to one fDFSDMCLK clock cycle (with deterministic jitter), asynchronous trigger has latency 2-3 fDFSDMCLK clock cycles (with jitter up to 1 cycle). DFSDM_FLTx 0x00 dfsdm_jtrg0 0x01 dfsdm_jtrg1 ... 0x1E dfsdm_jtrg30 0x1F dfsdm_jtrg31 Refer to . 0x0-0x1F: Trigger inputs selected by the following table (internal or external trigger).
$00006000 constant DFSDM1_DFSDM_FLT7CR1_JEXTEN                      \ Trigger enable and trigger edge selection for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00020000 constant DFSDM1_DFSDM_FLT7CR1_RSWSTART                    \ Software start of a conversion on the regular channel This bit is always read as '0â.
$00040000 constant DFSDM1_DFSDM_FLT7CR1_RCONT                       \ Continuous mode selection for regular conversions Writing '0â to this bit while a continuous regular conversion is already in progress stops the continuous mode immediately.
$00080000 constant DFSDM1_DFSDM_FLT7CR1_RSYNC                       \ Launch regular conversion synchronously with DFSDM_FLT0 This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00200000 constant DFSDM1_DFSDM_FLT7CR1_RDMAEN                      \ DMA channel enabled to read data for the regular conversion This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$07000000 constant DFSDM1_DFSDM_FLT7CR1_RCH                         \ Regular channel selection ... 7: Channel 7 is selected as the regular channel Writing these bits when RCIP=1 takes effect when the next regular conversion begins. This is especially useful in continuous mode (when RCONT=1). It also affects regular conversions which are pending (due to ongoing injected conversion).
$20000000 constant DFSDM1_DFSDM_FLT7CR1_FAST                        \ Fast conversion mode selection for regular conversions When converting a regular conversion in continuous mode, having enabled the fast mode causes each conversion (except the first) to execute faster than in standard mode. This bit has no effect on conversions which are not continuous. This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): t = IOSR / fCKIN (... but CNVCNT=0) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input.
$40000000 constant DFSDM1_DFSDM_FLT7CR1_AWFSEL                      \ Analog watchdog fast mode select


\
\ @brief Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
\ Address offset: 0x484
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT7CR2_JEOCIE                      \ Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
$00000002 constant DFSDM1_DFSDM_FLT7CR2_REOCIE                      \ Regular end of conversion interrupt enable Please see the explanation of REOCF in DFSDM_FLTxISR.
$00000004 constant DFSDM1_DFSDM_FLT7CR2_JOVRIE                      \ Injected data overrun interrupt enable Please see the explanation of JOVRF in DFSDM_FLTxISR.
$00000008 constant DFSDM1_DFSDM_FLT7CR2_ROVRIE                      \ Regular data overrun interrupt enable Please see the explanation of ROVRF in DFSDM_FLTxISR.
$00000010 constant DFSDM1_DFSDM_FLT7CR2_AWDIE                       \ Analog watchdog interrupt enable Please see the explanation of AWDF in DFSDM_FLTxISR.
$00000020 constant DFSDM1_DFSDM_FLT7CR2_SCDIE                       \ Short-circuit detector interrupt enable Please see the explanation of SCDF[7:0] in DFSDM_FLTxISR. Note: SCDIE is present only in DFSDM_FLT0CR2 register (filter x=0)
$00000040 constant DFSDM1_DFSDM_FLT7CR2_CKABIE                      \ Clock absence interrupt enable Please see the explanation of CKABF[7:0] in DFSDM_FLTxISR. Note: CKABIE is present only in DFSDM_FLT0CR2 register (filter x=0)
$0000ff00 constant DFSDM1_DFSDM_FLT7CR2_EXCH                        \ Extremes detector channel selection These bits select the input channels to be taken by the Extremes detector. EXCH[y] = 0: Extremes detector does not accept data from channel y EXCH[y] = 1: Extremes detector accepts data from channel y
$00ff0000 constant DFSDM1_DFSDM_FLT7CR2_AWDCH                       \ Analog watchdog channel selection These bits select the input channel to be guarded continuously by the analog watchdog. AWDCH[y] = 0: Analog watchdog is disabled on channel y AWDCH[y] = 1: Analog watchdog is enabled on channel y


\
\ @brief End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
\ Address offset: 0x488
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM1_DFSDM_FLT7ISR_JEOCF                       \ End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
$00000002 constant DFSDM1_DFSDM_FLT7ISR_REOCF                       \ End of regular conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxRDATAR.
$00000004 constant DFSDM1_DFSDM_FLT7ISR_JOVRF                       \ Injected conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRJOVRF bit in the DFSDM_FLTxICR register.
$00000008 constant DFSDM1_DFSDM_FLT7ISR_ROVRF                       \ Regular conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRROVRF bit in the DFSDM_FLTxICR register.
$00000010 constant DFSDM1_DFSDM_FLT7ISR_AWDF                        \ Analog watchdog This bit is set by hardware. It is cleared by software by clearing all source flag bits AWHTF[7:0] and AWLTF[7:0] in DFSDM_FLTxAWSR register (by writing '1â into the clear bits in DFSDM_FLTxAWCFR register).
$00002000 constant DFSDM1_DFSDM_FLT7ISR_JCIP                        \ Injected conversion in progress status A request to start an injected conversion is ignored when JCIP=1.
$00004000 constant DFSDM1_DFSDM_FLT7ISR_RCIP                        \ Regular conversion in progress status A request to start a regular conversion is ignored when RCIP=1.
$00ff0000 constant DFSDM1_DFSDM_FLT7ISR_CKABF                       \ Clock absence flag CKABF[y]=0: Clock signal on channel y is present. CKABF[y]=1: Clock signal on channel y is not present. Given y bit is set by hardware when clock absence is detected on channel y. It is held at CKABF[y]=1 state by hardware when CHEN=0 (see DFSDM_CHyCFGR1 register). It is held at CKABF[y]=1 state by hardware when the transceiver is not yet synchronized.It can be cleared by software using the corresponding CLRCKABF[y] bit in the DFSDM_FLTxICR register. Note: CKABF[7:0] is present only in DFSDM_FLT0ISR register (filter x=0)
$ff000000 constant DFSDM1_DFSDM_FLT7ISR_SCDF                        \ short-circuit detector flag SDCF[y]=0: No short-circuit detector event occurred on channel y SDCF[y]=1: The short-circuit detector counter reaches, on channel y, the value programmed in the DFSDM_CHyAWSCDR registers This bit is set by hardware. It can be cleared by software using the corresponding CLRSCDF[y] bit in the DFSDM_FLTxICR register. SCDF[y] is cleared also by hardware when CHEN[y] = 0 (given channel is disabled). Note: SCDF[7:0] is present only in DFSDM_FLT0ISR register (filter x=0)


\
\ @brief Clear the injected conversion overrun flag
\ Address offset: 0x48C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM1_DFSDM_FLT7ICR_CLRJOVRF                    \ Clear the injected conversion overrun flag
$00000008 constant DFSDM1_DFSDM_FLT7ICR_CLRROVRF                    \ Clear the regular conversion overrun flag
$00ff0000 constant DFSDM1_DFSDM_FLT7ICR_CLRCKABF                    \ Clear the clock absence flag CLRCKABF[y]=0: Writing '0â has no effect CLRCKABF[y]=1: Writing '1â to position y clears the corresponding CKABF[y] bit in the DFSDM_FLTxISR register. When the transceiver is not yet synchronized, the clock absence flag is set and cannot be cleared by CLRCKABF[y]. Note: CLRCKABF[7:0] is present only in DFSDM_FLT0ICR register (filter x=0)
$ff000000 constant DFSDM1_DFSDM_FLT7ICR_CLRSCDF                     \ Clear the short-circuit detector flag CLRSCDF[y]=0: Writing '0â has no effect CLRSCDF[y]=1: Writing '1â to position y clears the corresponding SCDF[y] bit in the DFSDM_FLTxISR register Note: CLRSCDF[7:0] is present only in DFSDM_FLT0ICR register (filter x=0)


\
\ @brief Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
\ Address offset: 0x490
\ Reset value: 0x00000001
\

$000000ff constant DFSDM1_DFSDM_FLT7JCHGR_JCHG                      \ Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.


\
\ @brief Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
\ Address offset: 0x494
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT7FCR_IOSR                        \ Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
$03ff0000 constant DFSDM1_DFSDM_FLT7FCR_FOSR                        \ Sinc filter oversampling ratio (decimation rate) number is also the decimation ratio of the output data rate from filter. This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If FOSR = 0, then the filter has no effect (filter bypass). 0 - 1023: Defines the length of the Sinc type filter in the range 1 - 1024 (FOSR = FOSR[9:0] +1). This
$e0000000 constant DFSDM1_DFSDM_FLT7FCR_FORD                        \ Sinc filter order 2: Sinc2 filter type 3: Sinc3 filter type 4: Sinc4 filter type 5: Sinc5 filter type 6-7: Reserved Sincx filter type transfer function: FastSinc filter type transfer function: This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1).


\
\ @brief Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
\ Address offset: 0x498
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT7JDATAR_JDATACH                  \ Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
$ffffff00 constant DFSDM1_DFSDM_FLT7JDATAR_JDATA                    \ Injected group conversion data When each conversion of a channel in the injected group finishes, its resulting data is stored in this field. The data is valid when JEOCF=1. Reading this register clears the corresponding JEOCF.


\
\ @brief Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
\ Address offset: 0x49C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT7RDATAR_RDATACH                  \ Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
$00000010 constant DFSDM1_DFSDM_FLT7RDATAR_RPEND                    \ Regular channel pending data Regular data in RDATA[23:0] was delayed due to an injected channel trigger during the conversion
$ffffff00 constant DFSDM1_DFSDM_FLT7RDATAR_RDATA                    \ Regular channel conversion data When each regular conversion finishes, its data is stored in this register. The data is valid when REOCF=1. Reading this register clears the corresponding REOCF.


\
\ @brief Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
\ Address offset: 0x4A0
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT7AWHTR_BKAWH                     \ Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
$ffffff00 constant DFSDM1_DFSDM_FLT7AWHTR_AWHT                      \ Analog watchdog high threshold These bits are written by software to define the high threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), the higher 16 bits (AWHT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWHT[7:0] are not taken into comparison in this case.


\
\ @brief Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
\ Address offset: 0x4A4
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT7AWLTR_BKAWL                     \ Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
$ffffff00 constant DFSDM1_DFSDM_FLT7AWLTR_AWLT                      \ Analog watchdog low threshold These bits are written by software to define the low threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), only the higher 16 bits (AWLT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWLT[7:0] are not taken into comparison in this case.


\
\ @brief Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
\ Address offset: 0x4A8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT7AWSR_AWLTF                      \ Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
$0000ff00 constant DFSDM1_DFSDM_FLT7AWSR_AWHTF                      \ Analog watchdog high threshold flag AWHTF[y]=1 indicates a high threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWHTF[y] bit in the DFSDM_FLTxAWCFR register.


\
\ @brief Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
\ Address offset: 0x4AC
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT7AWCFR_CLRAWLTF                  \ Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
$0000ff00 constant DFSDM1_DFSDM_FLT7AWCFR_CLRAWHTF                  \ Clear the analog watchdog high threshold flag CLRAWHTF[y]=0: Writing '0â has no effect CLRAWHTF[y]=1: Writing '1â to position y clears the corresponding AWHTF[y] bit in the DFSDM_FLTxAWSR register


\
\ @brief Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
\ Address offset: 0x4B0
\ Reset value: 0x80000000
\

$00000007 constant DFSDM1_DFSDM_FLT7EXMAX_EXMAXCH                   \ Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
$ffffff00 constant DFSDM1_DFSDM_FLT7EXMAX_EXMAX                     \ Extremes detector maximum value These bits are set by hardware and indicate the highest value converted by DFSDM_FLTx. EXMAX[23:0] bits are reset to value (0x800000) by reading of this register.


\
\ @brief Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
\ Address offset: 0x4B4
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM1_DFSDM_FLT7EXMIN_EXMINCH                   \ Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
$ffffff00 constant DFSDM1_DFSDM_FLT7EXMIN_EXMIN                     \ Extremes detector minimum value These bits are set by hardware and indicate the lowest value converted by DFSDM_FLTx. EXMIN[23:0] bits are reset to value (0x7FFFFF) by reading of this register.


\
\ @brief 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
\ Address offset: 0x4B8
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM1_DFSDM_FLT7CNVTIMR_CNVCNT                  \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.


\
\ @brief Digital filter for sigma delta modulators
\
$40017800 constant DFSDM1_DFSDM_CH0CFGR1  \ offset: 0x00 : DFSDM channel 0 configuration register
$40017804 constant DFSDM1_DFSDM_CH0CFGR2  \ offset: 0x04 : DFSDM channel 0 configuration register
$40017808 constant DFSDM1_DFSDM_CH0AWSCDR  \ offset: 0x08 : DFSDM channel 0 analog watchdog and short-circuit detector register
$4001780c constant DFSDM1_DFSDM_CH0WDATR  \ offset: 0x0C : DFSDM channel 0 watchdog filter data register
$40017810 constant DFSDM1_DFSDM_CH0DATINR  \ offset: 0x10 : DFSDM channel 0 data input register
$40017814 constant DFSDM1_DFSDM_CH0DLYR  \ offset: 0x14 : Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
$40017820 constant DFSDM1_DFSDM_CH1CFGR1  \ offset: 0x20 : DFSDM channel 1 configuration register
$40017824 constant DFSDM1_DFSDM_CH1CFGR2  \ offset: 0x24 : DFSDM channel 1 configuration register
$40017828 constant DFSDM1_DFSDM_CH1AWSCDR  \ offset: 0x28 : DFSDM channel 1 analog watchdog and short-circuit detector register
$4001782c constant DFSDM1_DFSDM_CH1WDATR  \ offset: 0x2C : DFSDM channel 1 watchdog filter data register
$40017830 constant DFSDM1_DFSDM_CH1DATINR  \ offset: 0x30 : DFSDM channel 1 data input register
$40017834 constant DFSDM1_DFSDM_CH1DLYR  \ offset: 0x34 : Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
$40017840 constant DFSDM1_DFSDM_CH2CFGR1  \ offset: 0x40 : DFSDM channel 2 configuration register
$40017844 constant DFSDM1_DFSDM_CH2CFGR2  \ offset: 0x44 : DFSDM channel 2 configuration register
$40017848 constant DFSDM1_DFSDM_CH2AWSCDR  \ offset: 0x48 : DFSDM channel 2 analog watchdog and short-circuit detector register
$4001784c constant DFSDM1_DFSDM_CH2WDATR  \ offset: 0x4C : DFSDM channel 2 watchdog filter data register
$40017850 constant DFSDM1_DFSDM_CH2DATINR  \ offset: 0x50 : DFSDM channel 2 data input register
$40017854 constant DFSDM1_DFSDM_CH2DLYR  \ offset: 0x54 : Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
$40017860 constant DFSDM1_DFSDM_CH3CFGR1  \ offset: 0x60 : DFSDM channel 3 configuration register
$40017864 constant DFSDM1_DFSDM_CH3CFGR2  \ offset: 0x64 : DFSDM channel 3 configuration register
$40017868 constant DFSDM1_DFSDM_CH3AWSCDR  \ offset: 0x68 : DFSDM channel 3 analog watchdog and short-circuit detector register
$4001786c constant DFSDM1_DFSDM_CH3WDATR  \ offset: 0x6C : DFSDM channel 3 watchdog filter data register
$40017870 constant DFSDM1_DFSDM_CH3DATINR  \ offset: 0x70 : DFSDM channel 3 data input register
$40017874 constant DFSDM1_DFSDM_CH3DLYR  \ offset: 0x74 : Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
$40017880 constant DFSDM1_DFSDM_CH4CFGR1  \ offset: 0x80 : DFSDM channel 4 configuration register
$40017884 constant DFSDM1_DFSDM_CH4CFGR2  \ offset: 0x84 : DFSDM channel 4 configuration register
$40017888 constant DFSDM1_DFSDM_CH4AWSCDR  \ offset: 0x88 : DFSDM channel 4 analog watchdog and short-circuit detector register
$4001788c constant DFSDM1_DFSDM_CH4WDATR  \ offset: 0x8C : DFSDM channel 4 watchdog filter data register
$40017890 constant DFSDM1_DFSDM_CH4DATINR  \ offset: 0x90 : DFSDM channel 4 data input register
$40017894 constant DFSDM1_DFSDM_CH4DLYR  \ offset: 0x94 : Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
$400178a0 constant DFSDM1_DFSDM_CH5CFGR1  \ offset: 0xA0 : DFSDM channel 5 configuration register
$400178a4 constant DFSDM1_DFSDM_CH5CFGR2  \ offset: 0xA4 : DFSDM channel 5 configuration register
$400178a8 constant DFSDM1_DFSDM_CH5AWSCDR  \ offset: 0xA8 : DFSDM channel 5 analog watchdog and short-circuit detector register
$400178ac constant DFSDM1_DFSDM_CH5WDATR  \ offset: 0xAC : DFSDM channel 5 watchdog filter data register
$400178b0 constant DFSDM1_DFSDM_CH5DATINR  \ offset: 0xB0 : DFSDM channel 5 data input register
$400178b4 constant DFSDM1_DFSDM_CH5DLYR  \ offset: 0xB4 : Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
$400178c0 constant DFSDM1_DFSDM_CH6CFGR1  \ offset: 0xC0 : DFSDM channel 6 configuration register
$400178c4 constant DFSDM1_DFSDM_CH6CFGR2  \ offset: 0xC4 : DFSDM channel 6 configuration register
$400178c8 constant DFSDM1_DFSDM_CH6AWSCDR  \ offset: 0xC8 : DFSDM channel 6 analog watchdog and short-circuit detector register
$400178cc constant DFSDM1_DFSDM_CH6WDATR  \ offset: 0xCC : DFSDM channel 6 watchdog filter data register
$400178d0 constant DFSDM1_DFSDM_CH6DATINR  \ offset: 0xD0 : DFSDM channel 6 data input register
$400178d4 constant DFSDM1_DFSDM_CH6DLYR  \ offset: 0xD4 : Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
$400178e0 constant DFSDM1_DFSDM_CH7CFGR1  \ offset: 0xE0 : DFSDM channel 7 configuration register
$400178e4 constant DFSDM1_DFSDM_CH7CFGR2  \ offset: 0xE4 : DFSDM channel 7 configuration register
$400178e8 constant DFSDM1_DFSDM_CH7AWSCDR  \ offset: 0xE8 : DFSDM channel 7 analog watchdog and short-circuit detector register
$400178ec constant DFSDM1_DFSDM_CH7WDATR  \ offset: 0xEC : DFSDM channel 7 watchdog filter data register
$400178f0 constant DFSDM1_DFSDM_CH7DATINR  \ offset: 0xF0 : DFSDM channel 7 data input register
$400178f4 constant DFSDM1_DFSDM_CH7DLYR  \ offset: 0xF4 : Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
$40017900 constant DFSDM1_DFSDM_FLT0CR1  \ offset: 0x100 : DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
$40017904 constant DFSDM1_DFSDM_FLT0CR2  \ offset: 0x104 : Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
$40017908 constant DFSDM1_DFSDM_FLT0ISR  \ offset: 0x108 : End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
$4001790c constant DFSDM1_DFSDM_FLT0ICR  \ offset: 0x10C : Clear the injected conversion overrun flag
$40017910 constant DFSDM1_DFSDM_FLT0JCHGR  \ offset: 0x110 : Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
$40017914 constant DFSDM1_DFSDM_FLT0FCR  \ offset: 0x114 : Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
$40017918 constant DFSDM1_DFSDM_FLT0JDATAR  \ offset: 0x118 : Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
$4001791c constant DFSDM1_DFSDM_FLT0RDATAR  \ offset: 0x11C : Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
$40017920 constant DFSDM1_DFSDM_FLT0AWHTR  \ offset: 0x120 : Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
$40017924 constant DFSDM1_DFSDM_FLT0AWLTR  \ offset: 0x124 : Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
$40017928 constant DFSDM1_DFSDM_FLT0AWSR  \ offset: 0x128 : Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
$4001792c constant DFSDM1_DFSDM_FLT0AWCFR  \ offset: 0x12C : Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
$40017930 constant DFSDM1_DFSDM_FLT0EXMAX  \ offset: 0x130 : Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
$40017934 constant DFSDM1_DFSDM_FLT0EXMIN  \ offset: 0x134 : Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
$40017938 constant DFSDM1_DFSDM_FLT0CNVTIMR  \ offset: 0x138 : 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
$40017980 constant DFSDM1_DFSDM_FLT1CR1  \ offset: 0x180 : DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
$40017984 constant DFSDM1_DFSDM_FLT1CR2  \ offset: 0x184 : Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
$40017988 constant DFSDM1_DFSDM_FLT1ISR  \ offset: 0x188 : End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
$4001798c constant DFSDM1_DFSDM_FLT1ICR  \ offset: 0x18C : Clear the injected conversion overrun flag
$40017990 constant DFSDM1_DFSDM_FLT1JCHGR  \ offset: 0x190 : Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
$40017994 constant DFSDM1_DFSDM_FLT1FCR  \ offset: 0x194 : Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
$40017998 constant DFSDM1_DFSDM_FLT1JDATAR  \ offset: 0x198 : Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
$4001799c constant DFSDM1_DFSDM_FLT1RDATAR  \ offset: 0x19C : Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
$400179a0 constant DFSDM1_DFSDM_FLT1AWHTR  \ offset: 0x1A0 : Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
$400179a4 constant DFSDM1_DFSDM_FLT1AWLTR  \ offset: 0x1A4 : Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
$400179a8 constant DFSDM1_DFSDM_FLT1AWSR  \ offset: 0x1A8 : Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
$400179ac constant DFSDM1_DFSDM_FLT1AWCFR  \ offset: 0x1AC : Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
$400179b0 constant DFSDM1_DFSDM_FLT1EXMAX  \ offset: 0x1B0 : Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
$400179b4 constant DFSDM1_DFSDM_FLT1EXMIN  \ offset: 0x1B4 : Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
$400179b8 constant DFSDM1_DFSDM_FLT1CNVTIMR  \ offset: 0x1B8 : 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
$40017a00 constant DFSDM1_DFSDM_FLT2CR1  \ offset: 0x200 : DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
$40017a04 constant DFSDM1_DFSDM_FLT2CR2  \ offset: 0x204 : Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
$40017a08 constant DFSDM1_DFSDM_FLT2ISR  \ offset: 0x208 : End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
$40017a0c constant DFSDM1_DFSDM_FLT2ICR  \ offset: 0x20C : Clear the injected conversion overrun flag
$40017a10 constant DFSDM1_DFSDM_FLT2JCHGR  \ offset: 0x210 : Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
$40017a14 constant DFSDM1_DFSDM_FLT2FCR  \ offset: 0x214 : Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
$40017a18 constant DFSDM1_DFSDM_FLT2JDATAR  \ offset: 0x218 : Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
$40017a1c constant DFSDM1_DFSDM_FLT2RDATAR  \ offset: 0x21C : Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
$40017a20 constant DFSDM1_DFSDM_FLT2AWHTR  \ offset: 0x220 : Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
$40017a24 constant DFSDM1_DFSDM_FLT2AWLTR  \ offset: 0x224 : Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
$40017a28 constant DFSDM1_DFSDM_FLT2AWSR  \ offset: 0x228 : Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
$40017a2c constant DFSDM1_DFSDM_FLT2AWCFR  \ offset: 0x22C : Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
$40017a30 constant DFSDM1_DFSDM_FLT2EXMAX  \ offset: 0x230 : Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
$40017a34 constant DFSDM1_DFSDM_FLT2EXMIN  \ offset: 0x234 : Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
$40017a38 constant DFSDM1_DFSDM_FLT2CNVTIMR  \ offset: 0x238 : 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
$40017a80 constant DFSDM1_DFSDM_FLT3CR1  \ offset: 0x280 : DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
$40017a84 constant DFSDM1_DFSDM_FLT3CR2  \ offset: 0x284 : Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
$40017a88 constant DFSDM1_DFSDM_FLT3ISR  \ offset: 0x288 : End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
$40017a8c constant DFSDM1_DFSDM_FLT3ICR  \ offset: 0x28C : Clear the injected conversion overrun flag
$40017a90 constant DFSDM1_DFSDM_FLT3JCHGR  \ offset: 0x290 : Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
$40017a94 constant DFSDM1_DFSDM_FLT3FCR  \ offset: 0x294 : Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
$40017a98 constant DFSDM1_DFSDM_FLT3JDATAR  \ offset: 0x298 : Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
$40017a9c constant DFSDM1_DFSDM_FLT3RDATAR  \ offset: 0x29C : Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
$40017aa0 constant DFSDM1_DFSDM_FLT3AWHTR  \ offset: 0x2A0 : Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
$40017aa4 constant DFSDM1_DFSDM_FLT3AWLTR  \ offset: 0x2A4 : Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
$40017aa8 constant DFSDM1_DFSDM_FLT3AWSR  \ offset: 0x2A8 : Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
$40017aac constant DFSDM1_DFSDM_FLT3AWCFR  \ offset: 0x2AC : Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
$40017ab0 constant DFSDM1_DFSDM_FLT3EXMAX  \ offset: 0x2B0 : Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
$40017ab4 constant DFSDM1_DFSDM_FLT3EXMIN  \ offset: 0x2B4 : Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
$40017ab8 constant DFSDM1_DFSDM_FLT3CNVTIMR  \ offset: 0x2B8 : 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
$40017b00 constant DFSDM1_DFSDM_FLT4CR1  \ offset: 0x300 : DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
$40017b04 constant DFSDM1_DFSDM_FLT4CR2  \ offset: 0x304 : Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
$40017b08 constant DFSDM1_DFSDM_FLT4ISR  \ offset: 0x308 : End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
$40017b0c constant DFSDM1_DFSDM_FLT4ICR  \ offset: 0x30C : Clear the injected conversion overrun flag
$40017b10 constant DFSDM1_DFSDM_FLT4JCHGR  \ offset: 0x310 : Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
$40017b14 constant DFSDM1_DFSDM_FLT4FCR  \ offset: 0x314 : Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
$40017b18 constant DFSDM1_DFSDM_FLT4JDATAR  \ offset: 0x318 : Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
$40017b1c constant DFSDM1_DFSDM_FLT4RDATAR  \ offset: 0x31C : Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
$40017b20 constant DFSDM1_DFSDM_FLT4AWHTR  \ offset: 0x320 : Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
$40017b24 constant DFSDM1_DFSDM_FLT4AWLTR  \ offset: 0x324 : Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
$40017b28 constant DFSDM1_DFSDM_FLT4AWSR  \ offset: 0x328 : Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
$40017b2c constant DFSDM1_DFSDM_FLT4AWCFR  \ offset: 0x32C : Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
$40017b30 constant DFSDM1_DFSDM_FLT4EXMAX  \ offset: 0x330 : Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
$40017b34 constant DFSDM1_DFSDM_FLT4EXMIN  \ offset: 0x334 : Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
$40017b38 constant DFSDM1_DFSDM_FLT4CNVTIMR  \ offset: 0x338 : 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
$40017b80 constant DFSDM1_DFSDM_FLT5CR1  \ offset: 0x380 : DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
$40017b84 constant DFSDM1_DFSDM_FLT5CR2  \ offset: 0x384 : Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
$40017b88 constant DFSDM1_DFSDM_FLT5ISR  \ offset: 0x388 : End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
$40017b8c constant DFSDM1_DFSDM_FLT5ICR  \ offset: 0x38C : Clear the injected conversion overrun flag
$40017b90 constant DFSDM1_DFSDM_FLT5JCHGR  \ offset: 0x390 : Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
$40017b94 constant DFSDM1_DFSDM_FLT5FCR  \ offset: 0x394 : Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
$40017b98 constant DFSDM1_DFSDM_FLT5JDATAR  \ offset: 0x398 : Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
$40017b9c constant DFSDM1_DFSDM_FLT5RDATAR  \ offset: 0x39C : Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
$40017ba0 constant DFSDM1_DFSDM_FLT5AWHTR  \ offset: 0x3A0 : Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
$40017ba4 constant DFSDM1_DFSDM_FLT5AWLTR  \ offset: 0x3A4 : Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
$40017ba8 constant DFSDM1_DFSDM_FLT5AWSR  \ offset: 0x3A8 : Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
$40017bac constant DFSDM1_DFSDM_FLT5AWCFR  \ offset: 0x3AC : Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
$40017bb0 constant DFSDM1_DFSDM_FLT5EXMAX  \ offset: 0x3B0 : Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
$40017bb4 constant DFSDM1_DFSDM_FLT5EXMIN  \ offset: 0x3B4 : Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
$40017bb8 constant DFSDM1_DFSDM_FLT5CNVTIMR  \ offset: 0x3B8 : 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
$40017c00 constant DFSDM1_DFSDM_FLT6CR1  \ offset: 0x400 : DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
$40017c04 constant DFSDM1_DFSDM_FLT6CR2  \ offset: 0x404 : Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
$40017c08 constant DFSDM1_DFSDM_FLT6ISR  \ offset: 0x408 : End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
$40017c0c constant DFSDM1_DFSDM_FLT6ICR  \ offset: 0x40C : Clear the injected conversion overrun flag
$40017c10 constant DFSDM1_DFSDM_FLT6JCHGR  \ offset: 0x410 : Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
$40017c14 constant DFSDM1_DFSDM_FLT6FCR  \ offset: 0x414 : Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
$40017c18 constant DFSDM1_DFSDM_FLT6JDATAR  \ offset: 0x418 : Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
$40017c1c constant DFSDM1_DFSDM_FLT6RDATAR  \ offset: 0x41C : Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
$40017c20 constant DFSDM1_DFSDM_FLT6AWHTR  \ offset: 0x420 : Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
$40017c24 constant DFSDM1_DFSDM_FLT6AWLTR  \ offset: 0x424 : Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
$40017c28 constant DFSDM1_DFSDM_FLT6AWSR  \ offset: 0x428 : Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
$40017c2c constant DFSDM1_DFSDM_FLT6AWCFR  \ offset: 0x42C : Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
$40017c30 constant DFSDM1_DFSDM_FLT6EXMAX  \ offset: 0x430 : Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
$40017c34 constant DFSDM1_DFSDM_FLT6EXMIN  \ offset: 0x434 : Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
$40017c38 constant DFSDM1_DFSDM_FLT6CNVTIMR  \ offset: 0x438 : 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
$40017c80 constant DFSDM1_DFSDM_FLT7CR1  \ offset: 0x480 : DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
$40017c84 constant DFSDM1_DFSDM_FLT7CR2  \ offset: 0x484 : Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
$40017c88 constant DFSDM1_DFSDM_FLT7ISR  \ offset: 0x488 : End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
$40017c8c constant DFSDM1_DFSDM_FLT7ICR  \ offset: 0x48C : Clear the injected conversion overrun flag
$40017c90 constant DFSDM1_DFSDM_FLT7JCHGR  \ offset: 0x490 : Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
$40017c94 constant DFSDM1_DFSDM_FLT7FCR  \ offset: 0x494 : Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
$40017c98 constant DFSDM1_DFSDM_FLT7JDATAR  \ offset: 0x498 : Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[2:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[2:0].
$40017c9c constant DFSDM1_DFSDM_FLT7RDATAR  \ offset: 0x49C : Regular channel most recently converted When each regular conversion finishes, RDATACH[2:0] is updated to indicate which channel was converted (because regular channel selection RCH[2:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[2:0].
$40017ca0 constant DFSDM1_DFSDM_FLT7AWHTR  \ offset: 0x4A0 : Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
$40017ca4 constant DFSDM1_DFSDM_FLT7AWLTR  \ offset: 0x4A4 : Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
$40017ca8 constant DFSDM1_DFSDM_FLT7AWSR  \ offset: 0x4A8 : Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
$40017cac constant DFSDM1_DFSDM_FLT7AWCFR  \ offset: 0x4AC : Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
$40017cb0 constant DFSDM1_DFSDM_FLT7EXMAX  \ offset: 0x4B0 : Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
$40017cb4 constant DFSDM1_DFSDM_FLT7EXMIN  \ offset: 0x4B4 : Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
$40017cb8 constant DFSDM1_DFSDM_FLT7CNVTIMR  \ offset: 0x4B8 : 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.

