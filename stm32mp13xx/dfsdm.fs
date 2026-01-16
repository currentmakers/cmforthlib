\
\ @file dfsdm.fs
\ @brief DFSDM
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

$00000003 constant DFSDM_DFSDM_CH0CFGR1_SITP                        \ Serial interface type for channel y This value can only be modified when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000000c constant DFSDM_DFSDM_CH0CFGR1_SPICKSEL                    \ SPI clock select for channel y 2: clock coming from internal CKOUT - sampling point on each second CKOUT falling edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input rising edge). 3: clock coming from internal CKOUT output - sampling point on each second CKOUT rising edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input falling edge). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00000020 constant DFSDM_DFSDM_CH0CFGR1_SCDEN                       \ Short-circuit detector enable on channel y
$00000040 constant DFSDM_DFSDM_CH0CFGR1_CKABEN                      \ Clock absence detector enable on channel y
$00000080 constant DFSDM_DFSDM_CH0CFGR1_CHEN                        \ Channel y enable If channel y is enabled, then serial data receiving is started according to the given channel setting.
$00000100 constant DFSDM_DFSDM_CH0CFGR1_CHINSEL                     \ Channel inputs selection This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00003000 constant DFSDM_DFSDM_CH0CFGR1_DATMPX                      \ Input data multiplexer for channel y 2: Data to channel y are taken from internal DFSDM_CHyDATINR register by direct CPU/DMA write. There can be written one or two 16-bit data samples according DATPACK[1:0] bit field setting. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000c000 constant DFSDM_DFSDM_CH0CFGR1_DATPACK                     \ Data packing mode in DFSDM_CHyDATINR register. first sample in INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y) To empty DFSDM_CHyDATINR register, two samples must be read by the digital filter from channel y (INDAT0[15:0] part is read as first sample and then INDAT1[15:0] part is read as next sample). 2: Dual: input data in DFSDM_CHyDATINR register are stored as two samples: first sample INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y+1) To empty DFSDM_CHyDATINR register first sample must be read by the digital filter from channel y and second sample must be read by another digital filter from channel y+1. Dual mode is available only on even channel numbers (y = 0, 2), for odd channel numbers (y = 1, 3) DFSDM_CHyDATINR is write protected. If an even channel is set to dual mode then the following odd channel must be set into standard mode (DATPACK[1:0]=0) for correct cooperation with even channel. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00ff0000 constant DFSDM_DFSDM_CH0CFGR1_CKOUTDIV                    \ Output serial clock divider Â 256 (Divider = CKOUTDIV+1). CKOUTDIV also defines the threshold for a clock absence detection. This value can only be modified when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). If DFSDMEN=0 (in DFSDM_CH0CFGR1 register) then CKOUT signal is set to low state (setting is performed one DFSDM clock cycle after DFSDMEN=0). Note: CKOUTDIV is present only in DFSDM_CH0CFGR1 register (channel y=0) 1- 255: Defines the division of system clock for the serial clock output for CKOUT signal in range 2Â -
$40000000 constant DFSDM_DFSDM_CH0CFGR1_CKOUTSRC                    \ Output serial clock source selection This value can be modified only when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). Note: CKOUTSRC is present only in DFSDM_CH0CFGR1 register (channel y=0)
$80000000 constant DFSDM_DFSDM_CH0CFGR1_DFSDMEN                     \ Global enable for DFSDM interface If DFSDM interface is enabled, then it is started to operate according to enabled y channels and enabled x filters settings (CHEN bit in DFSDM_CHyCFGR1 and DFEN bit in DFSDM_FLTxCR1). Data cleared by setting DFSDMEN=0: all registers DFSDM_FLTxISR are set to reset state (x = 0..1) all registers DFSDM_FLTxAWSR are set to reset state (x = 0..1) Note: DFSDMEN is present only in DFSDM_CH0CFGR1 register (channel y=0)


\
\ @brief DFSDM channel 0 configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_DFSDM_CH0CFGR2_DTRBS                       \ Data right bit-shift for channel y will be performed to have final results. Bit-shift is performed before offset correction. The data shift is rounding the result to nearest integer value. The sign of shifted result is maintained (to have valid 24-bit signed format of result data). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). 0-31: Defines the shift of the data result coming from the integrator - how many bit shifts to the right
$ffffff00 constant DFSDM_DFSDM_CH0CFGR2_OFFSET                      \ 24-bit calibration offset for channel y For channel y, OFFSET is applied to the results of each conversion from this channel. This value is set by software.


\
\ @brief DFSDM channel 0 analog watchdog and short-circuit detector register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_CH0AWSCDR_SCDT                       \ short-circuit detector threshold for channel y These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given channel.
$0000f000 constant DFSDM_DFSDM_CH0AWSCDR_BKSCD                      \ Break signal assignment for short-circuit detector on channel y BKSCD[i] = 0: Break i signal not assigned to short-circuit detector on channel y BKSCD[i] = 1: Break i signal assigned to short-circuit detector on channel y
$001f0000 constant DFSDM_DFSDM_CH0AWSCDR_AWFOSR                     \ Analog watchdog filter oversampling ratio (decimation rate) on channel y also the decimation ratio of the analog data rate. This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). Note: If AWFOSR = 0 then the filter has no effect (filter bypass). 0 - 31: Defines the length of the Sinc type filter in the range 1 - 32 (AWFOSR + 1). This number is
$00c00000 constant DFSDM_DFSDM_CH0AWSCDR_AWFORD                     \ Analog watchdog Sinc filter order on channel y 2: Sinc2 filter type 3: Sinc3 filter type Sincx filter type transfer function: FastSinc filter type transfer function: This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).


\
\ @brief DFSDM channel 0 watchdog filter data register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CH0WDATR_WDATA                       \ Input channel y watchdog data Data converted by the analog watchdog filter for input channel y. This data is continuously converted (no trigger) for this channel, with a limited resolution (OSR=1..32/sinc order = 1..3).


\
\ @brief DFSDM channel 0 data input register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CH0DATINR_INDAT0                     \ Input data for channel y Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) Channel y data sample is stored into INDAT0[15:0]. If DATPACK[1:0]=1 (interleaved mode) First channel y data sample is stored into INDAT0[15:0]. Second channel y data sample is stored into INDAT1[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: Channel y data sample is stored into INDAT0[15:0]. For odd y channels: INDAT0[15:0] is write protected. See for more details. INDAT0[15:0] is in the16-bit signed format.
$ffff0000 constant DFSDM_DFSDM_CH0DATINR_INDAT1                     \ Input data for channel y or channel y+1 Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) INDAT0[15:0] is write protected (not used for input sample). If DATPACK[1:0]=1 (interleaved mode) Second channel y data sample is stored into INDAT1[15:0]. First channel y data sample is stored into INDAT0[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: sample in INDAT1[15:0] is automatically copied into INDAT0[15:0] of channel (y+1). For odd y channels: INDAT1[15:0] is write protected. See for more details. INDAT0[15:1] is in the16-bit signed format.


\
\ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000003f constant DFSDM_DFSDM_CH0DLYR_PLSSKP                       \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied


\
\ @brief DFSDM channel 1 configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_DFSDM_CH1CFGR1_SITP                        \ Serial interface type for channel y This value can only be modified when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000000c constant DFSDM_DFSDM_CH1CFGR1_SPICKSEL                    \ SPI clock select for channel y 2: clock coming from internal CKOUT - sampling point on each second CKOUT falling edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input rising edge). 3: clock coming from internal CKOUT output - sampling point on each second CKOUT rising edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input falling edge). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00000020 constant DFSDM_DFSDM_CH1CFGR1_SCDEN                       \ Short-circuit detector enable on channel y
$00000040 constant DFSDM_DFSDM_CH1CFGR1_CKABEN                      \ Clock absence detector enable on channel y
$00000080 constant DFSDM_DFSDM_CH1CFGR1_CHEN                        \ Channel y enable If channel y is enabled, then serial data receiving is started according to the given channel setting.
$00000100 constant DFSDM_DFSDM_CH1CFGR1_CHINSEL                     \ Channel inputs selection This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00003000 constant DFSDM_DFSDM_CH1CFGR1_DATMPX                      \ Input data multiplexer for channel y 2: Data to channel y are taken from internal DFSDM_CHyDATINR register by direct CPU/DMA write. There can be written one or two 16-bit data samples according DATPACK[1:0] bit field setting. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000c000 constant DFSDM_DFSDM_CH1CFGR1_DATPACK                     \ Data packing mode in DFSDM_CHyDATINR register. first sample in INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y) To empty DFSDM_CHyDATINR register, two samples must be read by the digital filter from channel y (INDAT0[15:0] part is read as first sample and then INDAT1[15:0] part is read as next sample). 2: Dual: input data in DFSDM_CHyDATINR register are stored as two samples: first sample INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y+1) To empty DFSDM_CHyDATINR register first sample must be read by the digital filter from channel y and second sample must be read by another digital filter from channel y+1. Dual mode is available only on even channel numbers (y = 0, 2), for odd channel numbers (y = 1, 3) DFSDM_CHyDATINR is write protected. If an even channel is set to dual mode then the following odd channel must be set into standard mode (DATPACK[1:0]=0) for correct cooperation with even channel. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00ff0000 constant DFSDM_DFSDM_CH1CFGR1_CKOUTDIV                    \ Output serial clock divider Â 256 (Divider = CKOUTDIV+1). CKOUTDIV also defines the threshold for a clock absence detection. This value can only be modified when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). If DFSDMEN=0 (in DFSDM_CH0CFGR1 register) then CKOUT signal is set to low state (setting is performed one DFSDM clock cycle after DFSDMEN=0). Note: CKOUTDIV is present only in DFSDM_CH0CFGR1 register (channel y=0) 1- 255: Defines the division of system clock for the serial clock output for CKOUT signal in range 2Â -
$40000000 constant DFSDM_DFSDM_CH1CFGR1_CKOUTSRC                    \ Output serial clock source selection This value can be modified only when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). Note: CKOUTSRC is present only in DFSDM_CH0CFGR1 register (channel y=0)
$80000000 constant DFSDM_DFSDM_CH1CFGR1_DFSDMEN                     \ Global enable for DFSDM interface If DFSDM interface is enabled, then it is started to operate according to enabled y channels and enabled x filters settings (CHEN bit in DFSDM_CHyCFGR1 and DFEN bit in DFSDM_FLTxCR1). Data cleared by setting DFSDMEN=0: all registers DFSDM_FLTxISR are set to reset state (x = 0..1) all registers DFSDM_FLTxAWSR are set to reset state (x = 0..1) Note: DFSDMEN is present only in DFSDM_CH0CFGR1 register (channel y=0)


\
\ @brief DFSDM channel 1 configuration register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_DFSDM_CH1CFGR2_DTRBS                       \ Data right bit-shift for channel y will be performed to have final results. Bit-shift is performed before offset correction. The data shift is rounding the result to nearest integer value. The sign of shifted result is maintained (to have valid 24-bit signed format of result data). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). 0-31: Defines the shift of the data result coming from the integrator - how many bit shifts to the right
$ffffff00 constant DFSDM_DFSDM_CH1CFGR2_OFFSET                      \ 24-bit calibration offset for channel y For channel y, OFFSET is applied to the results of each conversion from this channel. This value is set by software.


\
\ @brief DFSDM channel 1 analog watchdog and short-circuit detector register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_CH1AWSCDR_SCDT                       \ short-circuit detector threshold for channel y These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given channel.
$0000f000 constant DFSDM_DFSDM_CH1AWSCDR_BKSCD                      \ Break signal assignment for short-circuit detector on channel y BKSCD[i] = 0: Break i signal not assigned to short-circuit detector on channel y BKSCD[i] = 1: Break i signal assigned to short-circuit detector on channel y
$001f0000 constant DFSDM_DFSDM_CH1AWSCDR_AWFOSR                     \ Analog watchdog filter oversampling ratio (decimation rate) on channel y also the decimation ratio of the analog data rate. This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). Note: If AWFOSR = 0 then the filter has no effect (filter bypass). 0 - 31: Defines the length of the Sinc type filter in the range 1 - 32 (AWFOSR + 1). This number is
$00c00000 constant DFSDM_DFSDM_CH1AWSCDR_AWFORD                     \ Analog watchdog Sinc filter order on channel y 2: Sinc2 filter type 3: Sinc3 filter type Sincx filter type transfer function: FastSinc filter type transfer function: This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).


\
\ @brief DFSDM channel 1 watchdog filter data register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CH1WDATR_WDATA                       \ Input channel y watchdog data Data converted by the analog watchdog filter for input channel y. This data is continuously converted (no trigger) for this channel, with a limited resolution (OSR=1..32/sinc order = 1..3).


\
\ @brief DFSDM channel 1 data input register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CH1DATINR_INDAT0                     \ Input data for channel y Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) Channel y data sample is stored into INDAT0[15:0]. If DATPACK[1:0]=1 (interleaved mode) First channel y data sample is stored into INDAT0[15:0]. Second channel y data sample is stored into INDAT1[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: Channel y data sample is stored into INDAT0[15:0]. For odd y channels: INDAT0[15:0] is write protected. See for more details. INDAT0[15:0] is in the16-bit signed format.
$ffff0000 constant DFSDM_DFSDM_CH1DATINR_INDAT1                     \ Input data for channel y or channel y+1 Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) INDAT0[15:0] is write protected (not used for input sample). If DATPACK[1:0]=1 (interleaved mode) Second channel y data sample is stored into INDAT1[15:0]. First channel y data sample is stored into INDAT0[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: sample in INDAT1[15:0] is automatically copied into INDAT0[15:0] of channel (y+1). For odd y channels: INDAT1[15:0] is write protected. See for more details. INDAT0[15:1] is in the16-bit signed format.


\
\ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000003f constant DFSDM_DFSDM_CH1DLYR_PLSSKP                       \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied


\
\ @brief DFSDM channel 2 configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_DFSDM_CH2CFGR1_SITP                        \ Serial interface type for channel y This value can only be modified when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000000c constant DFSDM_DFSDM_CH2CFGR1_SPICKSEL                    \ SPI clock select for channel y 2: clock coming from internal CKOUT - sampling point on each second CKOUT falling edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input rising edge). 3: clock coming from internal CKOUT output - sampling point on each second CKOUT rising edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input falling edge). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00000020 constant DFSDM_DFSDM_CH2CFGR1_SCDEN                       \ Short-circuit detector enable on channel y
$00000040 constant DFSDM_DFSDM_CH2CFGR1_CKABEN                      \ Clock absence detector enable on channel y
$00000080 constant DFSDM_DFSDM_CH2CFGR1_CHEN                        \ Channel y enable If channel y is enabled, then serial data receiving is started according to the given channel setting.
$00000100 constant DFSDM_DFSDM_CH2CFGR1_CHINSEL                     \ Channel inputs selection This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00003000 constant DFSDM_DFSDM_CH2CFGR1_DATMPX                      \ Input data multiplexer for channel y 2: Data to channel y are taken from internal DFSDM_CHyDATINR register by direct CPU/DMA write. There can be written one or two 16-bit data samples according DATPACK[1:0] bit field setting. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000c000 constant DFSDM_DFSDM_CH2CFGR1_DATPACK                     \ Data packing mode in DFSDM_CHyDATINR register. first sample in INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y) To empty DFSDM_CHyDATINR register, two samples must be read by the digital filter from channel y (INDAT0[15:0] part is read as first sample and then INDAT1[15:0] part is read as next sample). 2: Dual: input data in DFSDM_CHyDATINR register are stored as two samples: first sample INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y+1) To empty DFSDM_CHyDATINR register first sample must be read by the digital filter from channel y and second sample must be read by another digital filter from channel y+1. Dual mode is available only on even channel numbers (y = 0, 2), for odd channel numbers (y = 1, 3) DFSDM_CHyDATINR is write protected. If an even channel is set to dual mode then the following odd channel must be set into standard mode (DATPACK[1:0]=0) for correct cooperation with even channel. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00ff0000 constant DFSDM_DFSDM_CH2CFGR1_CKOUTDIV                    \ Output serial clock divider Â 256 (Divider = CKOUTDIV+1). CKOUTDIV also defines the threshold for a clock absence detection. This value can only be modified when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). If DFSDMEN=0 (in DFSDM_CH0CFGR1 register) then CKOUT signal is set to low state (setting is performed one DFSDM clock cycle after DFSDMEN=0). Note: CKOUTDIV is present only in DFSDM_CH0CFGR1 register (channel y=0) 1- 255: Defines the division of system clock for the serial clock output for CKOUT signal in range 2Â -
$40000000 constant DFSDM_DFSDM_CH2CFGR1_CKOUTSRC                    \ Output serial clock source selection This value can be modified only when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). Note: CKOUTSRC is present only in DFSDM_CH0CFGR1 register (channel y=0)
$80000000 constant DFSDM_DFSDM_CH2CFGR1_DFSDMEN                     \ Global enable for DFSDM interface If DFSDM interface is enabled, then it is started to operate according to enabled y channels and enabled x filters settings (CHEN bit in DFSDM_CHyCFGR1 and DFEN bit in DFSDM_FLTxCR1). Data cleared by setting DFSDMEN=0: all registers DFSDM_FLTxISR are set to reset state (x = 0..1) all registers DFSDM_FLTxAWSR are set to reset state (x = 0..1) Note: DFSDMEN is present only in DFSDM_CH0CFGR1 register (channel y=0)


\
\ @brief DFSDM channel 2 configuration register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_DFSDM_CH2CFGR2_DTRBS                       \ Data right bit-shift for channel y will be performed to have final results. Bit-shift is performed before offset correction. The data shift is rounding the result to nearest integer value. The sign of shifted result is maintained (to have valid 24-bit signed format of result data). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). 0-31: Defines the shift of the data result coming from the integrator - how many bit shifts to the right
$ffffff00 constant DFSDM_DFSDM_CH2CFGR2_OFFSET                      \ 24-bit calibration offset for channel y For channel y, OFFSET is applied to the results of each conversion from this channel. This value is set by software.


\
\ @brief DFSDM channel 2 analog watchdog and short-circuit detector register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_CH2AWSCDR_SCDT                       \ short-circuit detector threshold for channel y These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given channel.
$0000f000 constant DFSDM_DFSDM_CH2AWSCDR_BKSCD                      \ Break signal assignment for short-circuit detector on channel y BKSCD[i] = 0: Break i signal not assigned to short-circuit detector on channel y BKSCD[i] = 1: Break i signal assigned to short-circuit detector on channel y
$001f0000 constant DFSDM_DFSDM_CH2AWSCDR_AWFOSR                     \ Analog watchdog filter oversampling ratio (decimation rate) on channel y also the decimation ratio of the analog data rate. This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). Note: If AWFOSR = 0 then the filter has no effect (filter bypass). 0 - 31: Defines the length of the Sinc type filter in the range 1 - 32 (AWFOSR + 1). This number is
$00c00000 constant DFSDM_DFSDM_CH2AWSCDR_AWFORD                     \ Analog watchdog Sinc filter order on channel y 2: Sinc2 filter type 3: Sinc3 filter type Sincx filter type transfer function: FastSinc filter type transfer function: This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).


\
\ @brief DFSDM channel 2 watchdog filter data register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CH2WDATR_WDATA                       \ Input channel y watchdog data Data converted by the analog watchdog filter for input channel y. This data is continuously converted (no trigger) for this channel, with a limited resolution (OSR=1..32/sinc order = 1..3).


\
\ @brief DFSDM channel 2 data input register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CH2DATINR_INDAT0                     \ Input data for channel y Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) Channel y data sample is stored into INDAT0[15:0]. If DATPACK[1:0]=1 (interleaved mode) First channel y data sample is stored into INDAT0[15:0]. Second channel y data sample is stored into INDAT1[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: Channel y data sample is stored into INDAT0[15:0]. For odd y channels: INDAT0[15:0] is write protected. See for more details. INDAT0[15:0] is in the16-bit signed format.
$ffff0000 constant DFSDM_DFSDM_CH2DATINR_INDAT1                     \ Input data for channel y or channel y+1 Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) INDAT0[15:0] is write protected (not used for input sample). If DATPACK[1:0]=1 (interleaved mode) Second channel y data sample is stored into INDAT1[15:0]. First channel y data sample is stored into INDAT0[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: sample in INDAT1[15:0] is automatically copied into INDAT0[15:0] of channel (y+1). For odd y channels: INDAT1[15:0] is write protected. See for more details. INDAT0[15:1] is in the16-bit signed format.


\
\ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$0000003f constant DFSDM_DFSDM_CH2DLYR_PLSSKP                       \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied


\
\ @brief DFSDM channel 3 configuration register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_DFSDM_CH3CFGR1_SITP                        \ Serial interface type for channel y This value can only be modified when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000000c constant DFSDM_DFSDM_CH3CFGR1_SPICKSEL                    \ SPI clock select for channel y 2: clock coming from internal CKOUT - sampling point on each second CKOUT falling edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input rising edge). 3: clock coming from internal CKOUT output - sampling point on each second CKOUT rising edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input falling edge). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00000020 constant DFSDM_DFSDM_CH3CFGR1_SCDEN                       \ Short-circuit detector enable on channel y
$00000040 constant DFSDM_DFSDM_CH3CFGR1_CKABEN                      \ Clock absence detector enable on channel y
$00000080 constant DFSDM_DFSDM_CH3CFGR1_CHEN                        \ Channel y enable If channel y is enabled, then serial data receiving is started according to the given channel setting.
$00000100 constant DFSDM_DFSDM_CH3CFGR1_CHINSEL                     \ Channel inputs selection This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00003000 constant DFSDM_DFSDM_CH3CFGR1_DATMPX                      \ Input data multiplexer for channel y 2: Data to channel y are taken from internal DFSDM_CHyDATINR register by direct CPU/DMA write. There can be written one or two 16-bit data samples according DATPACK[1:0] bit field setting. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$0000c000 constant DFSDM_DFSDM_CH3CFGR1_DATPACK                     \ Data packing mode in DFSDM_CHyDATINR register. first sample in INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y) To empty DFSDM_CHyDATINR register, two samples must be read by the digital filter from channel y (INDAT0[15:0] part is read as first sample and then INDAT1[15:0] part is read as next sample). 2: Dual: input data in DFSDM_CHyDATINR register are stored as two samples: first sample INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y+1) To empty DFSDM_CHyDATINR register first sample must be read by the digital filter from channel y and second sample must be read by another digital filter from channel y+1. Dual mode is available only on even channel numbers (y = 0, 2), for odd channel numbers (y = 1, 3) DFSDM_CHyDATINR is write protected. If an even channel is set to dual mode then the following odd channel must be set into standard mode (DATPACK[1:0]=0) for correct cooperation with even channel. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
$00ff0000 constant DFSDM_DFSDM_CH3CFGR1_CKOUTDIV                    \ Output serial clock divider Â 256 (Divider = CKOUTDIV+1). CKOUTDIV also defines the threshold for a clock absence detection. This value can only be modified when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). If DFSDMEN=0 (in DFSDM_CH0CFGR1 register) then CKOUT signal is set to low state (setting is performed one DFSDM clock cycle after DFSDMEN=0). Note: CKOUTDIV is present only in DFSDM_CH0CFGR1 register (channel y=0) 1- 255: Defines the division of system clock for the serial clock output for CKOUT signal in range 2Â -
$40000000 constant DFSDM_DFSDM_CH3CFGR1_CKOUTSRC                    \ Output serial clock source selection This value can be modified only when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). Note: CKOUTSRC is present only in DFSDM_CH0CFGR1 register (channel y=0)
$80000000 constant DFSDM_DFSDM_CH3CFGR1_DFSDMEN                     \ Global enable for DFSDM interface If DFSDM interface is enabled, then it is started to operate according to enabled y channels and enabled x filters settings (CHEN bit in DFSDM_CHyCFGR1 and DFEN bit in DFSDM_FLTxCR1). Data cleared by setting DFSDMEN=0: all registers DFSDM_FLTxISR are set to reset state (x = 0..1) all registers DFSDM_FLTxAWSR are set to reset state (x = 0..1) Note: DFSDMEN is present only in DFSDM_CH0CFGR1 register (channel y=0)


\
\ @brief DFSDM channel 3 configuration register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_DFSDM_CH3CFGR2_DTRBS                       \ Data right bit-shift for channel y will be performed to have final results. Bit-shift is performed before offset correction. The data shift is rounding the result to nearest integer value. The sign of shifted result is maintained (to have valid 24-bit signed format of result data). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). 0-31: Defines the shift of the data result coming from the integrator - how many bit shifts to the right
$ffffff00 constant DFSDM_DFSDM_CH3CFGR2_OFFSET                      \ 24-bit calibration offset for channel y For channel y, OFFSET is applied to the results of each conversion from this channel. This value is set by software.


\
\ @brief DFSDM channel 3 analog watchdog and short-circuit detector register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_CH3AWSCDR_SCDT                       \ short-circuit detector threshold for channel y These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given channel.
$0000f000 constant DFSDM_DFSDM_CH3AWSCDR_BKSCD                      \ Break signal assignment for short-circuit detector on channel y BKSCD[i] = 0: Break i signal not assigned to short-circuit detector on channel y BKSCD[i] = 1: Break i signal assigned to short-circuit detector on channel y
$001f0000 constant DFSDM_DFSDM_CH3AWSCDR_AWFOSR                     \ Analog watchdog filter oversampling ratio (decimation rate) on channel y also the decimation ratio of the analog data rate. This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). Note: If AWFOSR = 0 then the filter has no effect (filter bypass). 0 - 31: Defines the length of the Sinc type filter in the range 1 - 32 (AWFOSR + 1). This number is
$00c00000 constant DFSDM_DFSDM_CH3AWSCDR_AWFORD                     \ Analog watchdog Sinc filter order on channel y 2: Sinc2 filter type 3: Sinc3 filter type Sincx filter type transfer function: FastSinc filter type transfer function: This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).


\
\ @brief DFSDM channel 3 watchdog filter data register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CH3WDATR_WDATA                       \ Input channel y watchdog data Data converted by the analog watchdog filter for input channel y. This data is continuously converted (no trigger) for this channel, with a limited resolution (OSR=1..32/sinc order = 1..3).


\
\ @brief DFSDM channel 3 data input register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CH3DATINR_INDAT0                     \ Input data for channel y Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) Channel y data sample is stored into INDAT0[15:0]. If DATPACK[1:0]=1 (interleaved mode) First channel y data sample is stored into INDAT0[15:0]. Second channel y data sample is stored into INDAT1[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: Channel y data sample is stored into INDAT0[15:0]. For odd y channels: INDAT0[15:0] is write protected. See for more details. INDAT0[15:0] is in the16-bit signed format.
$ffff0000 constant DFSDM_DFSDM_CH3DATINR_INDAT1                     \ Input data for channel y or channel y+1 Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) INDAT0[15:0] is write protected (not used for input sample). If DATPACK[1:0]=1 (interleaved mode) Second channel y data sample is stored into INDAT1[15:0]. First channel y data sample is stored into INDAT0[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: sample in INDAT1[15:0] is automatically copied into INDAT0[15:0] of channel (y+1). For odd y channels: INDAT1[15:0] is write protected. See for more details. INDAT0[15:1] is in the16-bit signed format.


\
\ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$0000003f constant DFSDM_DFSDM_CH3DLYR_PLSSKP                       \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied


\
\ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$0000003f constant DFSDM_DFSDM_CH4DLYR_PLSSKP                       \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied


\
\ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$0000003f constant DFSDM_DFSDM_CH5DLYR_PLSSKP                       \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied


\
\ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$0000003f constant DFSDM_DFSDM_CH6DLYR_PLSSKP                       \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied


\
\ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$0000003f constant DFSDM_DFSDM_CH7DLYR_PLSSKP                       \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied


\
\ @brief DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM_FLT0CR1_DFEN                         \ DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
$00000002 constant DFSDM_DFSDM_FLT0CR1_JSWSTART                     \ Start a conversion of the injected group of channels This bit is always read as '0â.
$00000008 constant DFSDM_DFSDM_FLT0CR1_JSYNC                        \ Launch an injected conversion synchronously with the DFSDM_FLT0 JSWSTART trigger This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00000010 constant DFSDM_DFSDM_FLT0CR1_JSCAN                        \ Scanning conversion mode for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Writing JCHG if JSCAN=0 resets the channel selection to the lowest selected channel.
$00000020 constant DFSDM_DFSDM_FLT0CR1_JDMAEN                       \ DMA channel enabled to read data for the injected channel group This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00001f00 constant DFSDM_DFSDM_FLT0CR1_JEXTSEL                      \ Trigger signal selection for launching injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Note: synchronous trigger has latency up to one fDFSDMCLK clock cycle (with deterministic jitter), asynchronous trigger has latency 2-3 fDFSDMCLK clock cycles (with jitter up to 1 cycle). DFSDM_FLTx 0x00 dfsdm_jtrg0 0x01 dfsdm_jtrg1 ... 0x1E dfsdm_jtrg30 0x1F dfsdm_jtrg31 Refer to . 0x0-0x1F: Trigger inputs selected by the following table (internal or external trigger).
$00006000 constant DFSDM_DFSDM_FLT0CR1_JEXTEN                       \ Trigger enable and trigger edge selection for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00020000 constant DFSDM_DFSDM_FLT0CR1_RSWSTART                     \ Software start of a conversion on the regular channel This bit is always read as '0â.
$00040000 constant DFSDM_DFSDM_FLT0CR1_RCONT                        \ Continuous mode selection for regular conversions Writing '0â to this bit while a continuous regular conversion is already in progress stops the continuous mode immediately.
$00080000 constant DFSDM_DFSDM_FLT0CR1_RSYNC                        \ Launch regular conversion synchronously with DFSDM_FLT0 This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00200000 constant DFSDM_DFSDM_FLT0CR1_RDMAEN                       \ DMA channel enabled to read data for the regular conversion This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$03000000 constant DFSDM_DFSDM_FLT0CR1_RCH                          \ Regular channel selection ... 3: Chanel 3 is selected as the regular channel Writing this bit when RCIP=1 takes effect when the next regular conversion begins. This is especially useful in continuous mode (when RCONT=1). It also affects regular conversions which are pending (due to ongoing injected conversion).
$20000000 constant DFSDM_DFSDM_FLT0CR1_FAST                         \ Fast conversion mode selection for regular conversions When converting a regular conversion in continuous mode, having enabled the fast mode causes each conversion (except the first) to execute faster than in standard mode. This bit has no effect on conversions which are not continuous. This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): t = IOSR / fCKIN (... but CNVCNT=0) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input.
$40000000 constant DFSDM_DFSDM_FLT0CR1_AWFSEL                       \ Analog watchdog fast mode select


\
\ @brief Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM_FLT0CR2_JEOCIE                       \ Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
$00000002 constant DFSDM_DFSDM_FLT0CR2_REOCIE                       \ Regular end of conversion interrupt enable Please see the explanation of REOCF in DFSDM_FLTxISR.
$00000004 constant DFSDM_DFSDM_FLT0CR2_JOVRIE                       \ Injected data overrun interrupt enable Please see the explanation of JOVRF in DFSDM_FLTxISR.
$00000008 constant DFSDM_DFSDM_FLT0CR2_ROVRIE                       \ Regular data overrun interrupt enable Please see the explanation of ROVRF in DFSDM_FLTxISR.
$00000010 constant DFSDM_DFSDM_FLT0CR2_AWDIE                        \ Analog watchdog interrupt enable Please see the explanation of AWDF in DFSDM_FLTxISR.
$00000020 constant DFSDM_DFSDM_FLT0CR2_SCDIE                        \ Short-circuit detector interrupt enable Please see the explanation of SCDF[3:0] in DFSDM_FLTxISR. Note: SCDIE is present only in DFSDM_FLT0CR2 register (filter x=0)
$00000040 constant DFSDM_DFSDM_FLT0CR2_CKABIE                       \ Clock absence interrupt enable Please see the explanation of CKABF[3:0] in DFSDM_FLTxISR. Note: CKABIE is present only in DFSDM_FLT0CR2 register (filter x=0)
$00000f00 constant DFSDM_DFSDM_FLT0CR2_EXCH                         \ Extremes detector channel selection These bits select the input channels to be taken by the Extremes detector. EXCH[y] = 0: Extremes detector does not accept data from channel y EXCH[y] = 1: Extremes detector accepts data from channel y
$000f0000 constant DFSDM_DFSDM_FLT0CR2_AWDCH                        \ Analog watchdog channel selection These bits select the input channel to be guarded continuously by the analog watchdog. AWDCH[y] = 0: Analog watchdog is disabled on channel y AWDCH[y] = 1: Analog watchdog is enabled on channel y


\
\ @brief End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
\ Address offset: 0x108
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM_DFSDM_FLT0ISR_JEOCF                        \ End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
$00000002 constant DFSDM_DFSDM_FLT0ISR_REOCF                        \ End of regular conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxRDATAR.
$00000004 constant DFSDM_DFSDM_FLT0ISR_JOVRF                        \ Injected conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRJOVRF bit in the DFSDM_FLTxICR register.
$00000008 constant DFSDM_DFSDM_FLT0ISR_ROVRF                        \ Regular conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRROVRF bit in the DFSDM_FLTxICR register.
$00000010 constant DFSDM_DFSDM_FLT0ISR_AWDF                         \ Analog watchdog This bit is set by hardware. It is cleared by software by clearing all source flag bits AWHTF[3:0] and AWLTF[3:0] in DFSDM_FLTxAWSR register (by writing '1â into the clear bits in DFSDM_FLTxAWCFR register).
$00002000 constant DFSDM_DFSDM_FLT0ISR_JCIP                         \ Injected conversion in progress status A request to start an injected conversion is ignored when JCIP=1.
$00004000 constant DFSDM_DFSDM_FLT0ISR_RCIP                         \ Regular conversion in progress status A request to start a regular conversion is ignored when RCIP=1.
$000f0000 constant DFSDM_DFSDM_FLT0ISR_CKABF                        \ Clock absence flag CKABF[y]=0: Clock signal on channel y is present. CKABF[y]=1: Clock signal on channel y is not present. Given y bit is set by hardware when clock absence is detected on channel y. It is held at CKABF[y]=1 state by hardware when CHEN=0 (see DFSDM_CHyCFGR1 register). It is held at CKABF[y]=1 state by hardware when the transceiver is not yet synchronized.It can be cleared by software using the corresponding CLRCKABF[y] bit in the DFSDM_FLTxICR register. Note: CKABF[3:0] is present only in DFSDM_FLT0ISR register (filter x=0)
$0f000000 constant DFSDM_DFSDM_FLT0ISR_SCDF                         \ short-circuit detector flag SDCF[y]=0: No short-circuit detector event occurred on channel y SDCF[y]=1: The short-circuit detector counter reaches, on channel y, the value programmed in the DFSDM_CHyAWSCDR registers This bit is set by hardware. It can be cleared by software using the corresponding CLRSCDF[y] bit in the DFSDM_FLTxICR register. SCDF[y] is cleared also by hardware when CHEN[y] = 0 (given channel is disabled). Note: SCDF[3:0] is present only in DFSDM_FLT0ISR register (filter x=0)


\
\ @brief Clear the injected conversion overrun flag
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM_DFSDM_FLT0ICR_CLRJOVRF                     \ Clear the injected conversion overrun flag
$00000008 constant DFSDM_DFSDM_FLT0ICR_CLRROVRF                     \ Clear the regular conversion overrun flag
$000f0000 constant DFSDM_DFSDM_FLT0ICR_CLRCKABF                     \ Clear the clock absence flag CLRCKABF[y]=0: Writing '0â has no effect CLRCKABF[y]=1: Writing '1â to position y clears the corresponding CKABF[y] bit in the DFSDM_FLTxISR register. When the transceiver is not yet synchronized, the clock absence flag is set and cannot be cleared by CLRCKABF[y]. Note: CLRCKABF[3:0] is present only in DFSDM_FLT0ICR register (filter x=0)
$0f000000 constant DFSDM_DFSDM_FLT0ICR_CLRSCDF                      \ Clear the short-circuit detector flag CLRSCDF[y]=0: Writing '0â has no effect CLRSCDF[y]=1: Writing '1â to position y clears the corresponding SCDF[y] bit in the DFSDM_FLTxISR register Note: CLRSCDF[3:0] is present only in DFSDM_FLT0ICR register (filter x=0)


\
\ @brief Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
\ Address offset: 0x110
\ Reset value: 0x00000001
\

$0000000f constant DFSDM_DFSDM_FLT0JCHGR_JCHG                       \ Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.


\
\ @brief Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_FLT0FCR_IOSR                         \ Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
$03ff0000 constant DFSDM_DFSDM_FLT0FCR_FOSR                         \ Sinc filter oversampling ratio (decimation rate) number is also the decimation ratio of the output data rate from filter. This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If FOSR = 0, then the filter has no effect (filter bypass). 0 - 1023: Defines the length of the Sinc type filter in the range 1 - 1024 (FOSR = FOSR[9:0] +1). This
$e0000000 constant DFSDM_DFSDM_FLT0FCR_FORD                         \ Sinc filter order 2: Sinc2 filter type 3: Sinc3 filter type 4: Sinc4 filter type 5: Sinc5 filter type 6-7: Reserved Sincx filter type transfer function: FastSinc filter type transfer function: This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1).


\
\ @brief Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[1:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[1:0].
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_DFSDM_FLT0JDATAR_JDATACH                   \ Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[1:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[1:0].
$ffffff00 constant DFSDM_DFSDM_FLT0JDATAR_JDATA                     \ Injected group conversion data When each conversion of a channel in the injected group finishes, its resulting data is stored in this field. The data is valid when JEOCF=1. Reading this register clears the corresponding JEOCF.


\
\ @brief Regular channel most recently converted When each regular conversion finishes, RDATACH[1:0] is updated to indicate which channel was converted (because regular channel selection RCH[1:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[1:0].
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_DFSDM_FLT0RDATAR_RDATACH                   \ Regular channel most recently converted When each regular conversion finishes, RDATACH[1:0] is updated to indicate which channel was converted (because regular channel selection RCH[1:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[1:0].
$00000010 constant DFSDM_DFSDM_FLT0RDATAR_RPEND                     \ Regular channel pending data Regular data in RDATA[23:0] was delayed due to an injected channel trigger during the conversion
$ffffff00 constant DFSDM_DFSDM_FLT0RDATAR_RDATA                     \ Regular channel conversion data When each regular conversion finishes, its data is stored in this register. The data is valid when REOCF=1. Reading this register clears the corresponding REOCF.


\
\ @brief Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM_FLT0AWHTR_BKAWH                      \ Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
$ffffff00 constant DFSDM_DFSDM_FLT0AWHTR_AWHT                       \ Analog watchdog high threshold These bits are written by software to define the high threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), the higher 16 bits (AWHT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWHT[7:0] are not taken into comparison in this case.


\
\ @brief Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM_FLT0AWLTR_BKAWL                      \ Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
$ffffff00 constant DFSDM_DFSDM_FLT0AWLTR_AWLT                       \ Analog watchdog low threshold These bits are written by software to define the low threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), only the higher 16 bits (AWLT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWLT[7:0] are not taken into comparison in this case.


\
\ @brief Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM_FLT0AWSR_AWLTF                       \ Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
$00000f00 constant DFSDM_DFSDM_FLT0AWSR_AWHTF                       \ Analog watchdog high threshold flag AWHTF[y]=1 indicates a high threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWHTF[y] bit in the DFSDM_FLTxAWCFR register.


\
\ @brief Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM_FLT0AWCFR_CLRAWLTF                   \ Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
$00000f00 constant DFSDM_DFSDM_FLT0AWCFR_CLRAWHTF                   \ Clear the analog watchdog high threshold flag CLRAWHTF[y]=0: Writing '0â has no effect CLRAWHTF[y]=1: Writing '1â to position y clears the corresponding AWHTF[y] bit in the DFSDM_FLTxAWSR register


\
\ @brief Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
\ Address offset: 0x130
\ Reset value: 0x80000000
\

$00000003 constant DFSDM_DFSDM_FLT0EXMAX_EXMAXCH                    \ Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
$ffffff00 constant DFSDM_DFSDM_FLT0EXMAX_EXMAX                      \ Extremes detector maximum value These bits are set by hardware and indicate the highest value converted by DFSDM_FLTx. EXMAX[23:0] bits are reset to value (0x800000) by reading of this register.


\
\ @brief Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
\ Address offset: 0x134
\ Reset value: 0x7FFFFF00
\

$00000003 constant DFSDM_DFSDM_FLT0EXMIN_EXMINCH                    \ Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
$ffffff00 constant DFSDM_DFSDM_FLT0EXMIN_EXMIN                      \ Extremes detector minimum value These bits are set by hardware and indicate the lowest value converted by DFSDM_FLTx. EXMIN[23:0] bits are reset to value (0x7FFFFF) by reading of this register.


\
\ @brief 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM_DFSDM_FLT0CNVTIMR_CNVCNT                   \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.


\
\ @brief DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM_FLT1CR1_DFEN                         \ DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
$00000002 constant DFSDM_DFSDM_FLT1CR1_JSWSTART                     \ Start a conversion of the injected group of channels This bit is always read as '0â.
$00000008 constant DFSDM_DFSDM_FLT1CR1_JSYNC                        \ Launch an injected conversion synchronously with the DFSDM_FLT0 JSWSTART trigger This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00000010 constant DFSDM_DFSDM_FLT1CR1_JSCAN                        \ Scanning conversion mode for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Writing JCHG if JSCAN=0 resets the channel selection to the lowest selected channel.
$00000020 constant DFSDM_DFSDM_FLT1CR1_JDMAEN                       \ DMA channel enabled to read data for the injected channel group This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00001f00 constant DFSDM_DFSDM_FLT1CR1_JEXTSEL                      \ Trigger signal selection for launching injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Note: synchronous trigger has latency up to one fDFSDMCLK clock cycle (with deterministic jitter), asynchronous trigger has latency 2-3 fDFSDMCLK clock cycles (with jitter up to 1 cycle). DFSDM_FLTx 0x00 dfsdm_jtrg0 0x01 dfsdm_jtrg1 ... 0x1E dfsdm_jtrg30 0x1F dfsdm_jtrg31 Refer to . 0x0-0x1F: Trigger inputs selected by the following table (internal or external trigger).
$00006000 constant DFSDM_DFSDM_FLT1CR1_JEXTEN                       \ Trigger enable and trigger edge selection for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00020000 constant DFSDM_DFSDM_FLT1CR1_RSWSTART                     \ Software start of a conversion on the regular channel This bit is always read as '0â.
$00040000 constant DFSDM_DFSDM_FLT1CR1_RCONT                        \ Continuous mode selection for regular conversions Writing '0â to this bit while a continuous regular conversion is already in progress stops the continuous mode immediately.
$00080000 constant DFSDM_DFSDM_FLT1CR1_RSYNC                        \ Launch regular conversion synchronously with DFSDM_FLT0 This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$00200000 constant DFSDM_DFSDM_FLT1CR1_RDMAEN                       \ DMA channel enabled to read data for the regular conversion This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
$03000000 constant DFSDM_DFSDM_FLT1CR1_RCH                          \ Regular channel selection ... 3: Chanel 3 is selected as the regular channel Writing this bit when RCIP=1 takes effect when the next regular conversion begins. This is especially useful in continuous mode (when RCONT=1). It also affects regular conversions which are pending (due to ongoing injected conversion).
$20000000 constant DFSDM_DFSDM_FLT1CR1_FAST                         \ Fast conversion mode selection for regular conversions When converting a regular conversion in continuous mode, having enabled the fast mode causes each conversion (except the first) to execute faster than in standard mode. This bit has no effect on conversions which are not continuous. This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): t = IOSR / fCKIN (... but CNVCNT=0) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input.
$40000000 constant DFSDM_DFSDM_FLT1CR1_AWFSEL                       \ Analog watchdog fast mode select


\
\ @brief Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM_FLT1CR2_JEOCIE                       \ Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
$00000002 constant DFSDM_DFSDM_FLT1CR2_REOCIE                       \ Regular end of conversion interrupt enable Please see the explanation of REOCF in DFSDM_FLTxISR.
$00000004 constant DFSDM_DFSDM_FLT1CR2_JOVRIE                       \ Injected data overrun interrupt enable Please see the explanation of JOVRF in DFSDM_FLTxISR.
$00000008 constant DFSDM_DFSDM_FLT1CR2_ROVRIE                       \ Regular data overrun interrupt enable Please see the explanation of ROVRF in DFSDM_FLTxISR.
$00000010 constant DFSDM_DFSDM_FLT1CR2_AWDIE                        \ Analog watchdog interrupt enable Please see the explanation of AWDF in DFSDM_FLTxISR.
$00000020 constant DFSDM_DFSDM_FLT1CR2_SCDIE                        \ Short-circuit detector interrupt enable Please see the explanation of SCDF[3:0] in DFSDM_FLTxISR. Note: SCDIE is present only in DFSDM_FLT0CR2 register (filter x=0)
$00000040 constant DFSDM_DFSDM_FLT1CR2_CKABIE                       \ Clock absence interrupt enable Please see the explanation of CKABF[3:0] in DFSDM_FLTxISR. Note: CKABIE is present only in DFSDM_FLT0CR2 register (filter x=0)
$00000f00 constant DFSDM_DFSDM_FLT1CR2_EXCH                         \ Extremes detector channel selection These bits select the input channels to be taken by the Extremes detector. EXCH[y] = 0: Extremes detector does not accept data from channel y EXCH[y] = 1: Extremes detector accepts data from channel y
$000f0000 constant DFSDM_DFSDM_FLT1CR2_AWDCH                        \ Analog watchdog channel selection These bits select the input channel to be guarded continuously by the analog watchdog. AWDCH[y] = 0: Analog watchdog is disabled on channel y AWDCH[y] = 1: Analog watchdog is enabled on channel y


\
\ @brief End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
\ Address offset: 0x188
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM_DFSDM_FLT1ISR_JEOCF                        \ End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
$00000002 constant DFSDM_DFSDM_FLT1ISR_REOCF                        \ End of regular conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxRDATAR.
$00000004 constant DFSDM_DFSDM_FLT1ISR_JOVRF                        \ Injected conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRJOVRF bit in the DFSDM_FLTxICR register.
$00000008 constant DFSDM_DFSDM_FLT1ISR_ROVRF                        \ Regular conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRROVRF bit in the DFSDM_FLTxICR register.
$00000010 constant DFSDM_DFSDM_FLT1ISR_AWDF                         \ Analog watchdog This bit is set by hardware. It is cleared by software by clearing all source flag bits AWHTF[3:0] and AWLTF[3:0] in DFSDM_FLTxAWSR register (by writing '1â into the clear bits in DFSDM_FLTxAWCFR register).
$00002000 constant DFSDM_DFSDM_FLT1ISR_JCIP                         \ Injected conversion in progress status A request to start an injected conversion is ignored when JCIP=1.
$00004000 constant DFSDM_DFSDM_FLT1ISR_RCIP                         \ Regular conversion in progress status A request to start a regular conversion is ignored when RCIP=1.
$000f0000 constant DFSDM_DFSDM_FLT1ISR_CKABF                        \ Clock absence flag CKABF[y]=0: Clock signal on channel y is present. CKABF[y]=1: Clock signal on channel y is not present. Given y bit is set by hardware when clock absence is detected on channel y. It is held at CKABF[y]=1 state by hardware when CHEN=0 (see DFSDM_CHyCFGR1 register). It is held at CKABF[y]=1 state by hardware when the transceiver is not yet synchronized.It can be cleared by software using the corresponding CLRCKABF[y] bit in the DFSDM_FLTxICR register. Note: CKABF[3:0] is present only in DFSDM_FLT0ISR register (filter x=0)
$0f000000 constant DFSDM_DFSDM_FLT1ISR_SCDF                         \ short-circuit detector flag SDCF[y]=0: No short-circuit detector event occurred on channel y SDCF[y]=1: The short-circuit detector counter reaches, on channel y, the value programmed in the DFSDM_CHyAWSCDR registers This bit is set by hardware. It can be cleared by software using the corresponding CLRSCDF[y] bit in the DFSDM_FLTxICR register. SCDF[y] is cleared also by hardware when CHEN[y] = 0 (given channel is disabled). Note: SCDF[3:0] is present only in DFSDM_FLT0ISR register (filter x=0)


\
\ @brief Clear the injected conversion overrun flag
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM_DFSDM_FLT1ICR_CLRJOVRF                     \ Clear the injected conversion overrun flag
$00000008 constant DFSDM_DFSDM_FLT1ICR_CLRROVRF                     \ Clear the regular conversion overrun flag
$000f0000 constant DFSDM_DFSDM_FLT1ICR_CLRCKABF                     \ Clear the clock absence flag CLRCKABF[y]=0: Writing '0â has no effect CLRCKABF[y]=1: Writing '1â to position y clears the corresponding CKABF[y] bit in the DFSDM_FLTxISR register. When the transceiver is not yet synchronized, the clock absence flag is set and cannot be cleared by CLRCKABF[y]. Note: CLRCKABF[3:0] is present only in DFSDM_FLT0ICR register (filter x=0)
$0f000000 constant DFSDM_DFSDM_FLT1ICR_CLRSCDF                      \ Clear the short-circuit detector flag CLRSCDF[y]=0: Writing '0â has no effect CLRSCDF[y]=1: Writing '1â to position y clears the corresponding SCDF[y] bit in the DFSDM_FLTxISR register Note: CLRSCDF[3:0] is present only in DFSDM_FLT0ICR register (filter x=0)


\
\ @brief Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
\ Address offset: 0x190
\ Reset value: 0x00000001
\

$0000000f constant DFSDM_DFSDM_FLT1JCHGR_JCHG                       \ Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.


\
\ @brief Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_FLT1FCR_IOSR                         \ Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
$03ff0000 constant DFSDM_DFSDM_FLT1FCR_FOSR                         \ Sinc filter oversampling ratio (decimation rate) number is also the decimation ratio of the output data rate from filter. This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If FOSR = 0, then the filter has no effect (filter bypass). 0 - 1023: Defines the length of the Sinc type filter in the range 1 - 1024 (FOSR = FOSR[9:0] +1). This
$e0000000 constant DFSDM_DFSDM_FLT1FCR_FORD                         \ Sinc filter order 2: Sinc2 filter type 3: Sinc3 filter type 4: Sinc4 filter type 5: Sinc5 filter type 6-7: Reserved Sincx filter type transfer function: FastSinc filter type transfer function: This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1).


\
\ @brief Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[1:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[1:0].
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_DFSDM_FLT1JDATAR_JDATACH                   \ Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[1:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[1:0].
$ffffff00 constant DFSDM_DFSDM_FLT1JDATAR_JDATA                     \ Injected group conversion data When each conversion of a channel in the injected group finishes, its resulting data is stored in this field. The data is valid when JEOCF=1. Reading this register clears the corresponding JEOCF.


\
\ @brief Regular channel most recently converted When each regular conversion finishes, RDATACH[1:0] is updated to indicate which channel was converted (because regular channel selection RCH[1:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[1:0].
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_DFSDM_FLT1RDATAR_RDATACH                   \ Regular channel most recently converted When each regular conversion finishes, RDATACH[1:0] is updated to indicate which channel was converted (because regular channel selection RCH[1:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[1:0].
$00000010 constant DFSDM_DFSDM_FLT1RDATAR_RPEND                     \ Regular channel pending data Regular data in RDATA[23:0] was delayed due to an injected channel trigger during the conversion
$ffffff00 constant DFSDM_DFSDM_FLT1RDATAR_RDATA                     \ Regular channel conversion data When each regular conversion finishes, its data is stored in this register. The data is valid when REOCF=1. Reading this register clears the corresponding REOCF.


\
\ @brief Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM_FLT1AWHTR_BKAWH                      \ Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
$ffffff00 constant DFSDM_DFSDM_FLT1AWHTR_AWHT                       \ Analog watchdog high threshold These bits are written by software to define the high threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), the higher 16 bits (AWHT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWHT[7:0] are not taken into comparison in this case.


\
\ @brief Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM_FLT1AWLTR_BKAWL                      \ Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
$ffffff00 constant DFSDM_DFSDM_FLT1AWLTR_AWLT                       \ Analog watchdog low threshold These bits are written by software to define the low threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), only the higher 16 bits (AWLT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWLT[7:0] are not taken into comparison in this case.


\
\ @brief Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM_FLT1AWSR_AWLTF                       \ Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
$00000f00 constant DFSDM_DFSDM_FLT1AWSR_AWHTF                       \ Analog watchdog high threshold flag AWHTF[y]=1 indicates a high threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWHTF[y] bit in the DFSDM_FLTxAWCFR register.


\
\ @brief Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM_FLT1AWCFR_CLRAWLTF                   \ Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
$00000f00 constant DFSDM_DFSDM_FLT1AWCFR_CLRAWHTF                   \ Clear the analog watchdog high threshold flag CLRAWHTF[y]=0: Writing '0â has no effect CLRAWHTF[y]=1: Writing '1â to position y clears the corresponding AWHTF[y] bit in the DFSDM_FLTxAWSR register


\
\ @brief Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
\ Address offset: 0x1B0
\ Reset value: 0x80000000
\

$00000003 constant DFSDM_DFSDM_FLT1EXMAX_EXMAXCH                    \ Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
$ffffff00 constant DFSDM_DFSDM_FLT1EXMAX_EXMAX                      \ Extremes detector maximum value These bits are set by hardware and indicate the highest value converted by DFSDM_FLTx. EXMAX[23:0] bits are reset to value (0x800000) by reading of this register.


\
\ @brief Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
\ Address offset: 0x1B4
\ Reset value: 0x7FFFFF00
\

$00000003 constant DFSDM_DFSDM_FLT1EXMIN_EXMINCH                    \ Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
$ffffff00 constant DFSDM_DFSDM_FLT1EXMIN_EXMIN                      \ Extremes detector minimum value These bits are set by hardware and indicate the lowest value converted by DFSDM_FLTx. EXMIN[23:0] bits are reset to value (0x7FFFFF) by reading of this register.


\
\ @brief 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
\ Address offset: 0x1B8
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM_DFSDM_FLT1CNVTIMR_CNVCNT                   \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.


\
\ @brief DFSDM hardware configuration register
\ Address offset: 0x7F0
\ Reset value: 0x00000204
\

$000000ff constant DFSDM_DFSDM_HWCFGR_NBT                           \ Number of implemented transceivers Defines how many transceivers (input channels) are implemented in DFSDM peripheral.
$0000ff00 constant DFSDM_DFSDM_HWCFGR_NBF                           \ Number of implemented filters Defines how many filters are implemented in DFSDM peripheral.


\
\ @brief DFSDM version register
\ Address offset: 0x7F4
\ Reset value: 0x00000021
\

$0000000f constant DFSDM_DFSDM_VERR_MINREV                          \ Minor revision of the DFSDM peripheral These bits return the DFSDM minor revision (in range 0..15).
$000000f0 constant DFSDM_DFSDM_VERR_MAJREV                          \ Major revision of the DFSDM peripheral These bits return the DFSDM major revision (in range 0..15).


\
\ @brief DFSDM identification register
\ Address offset: 0x7F8
\ Reset value: 0x00110031
\

$00000000 constant DFSDM_DFSDM_IPIDR_ID                             \ Peripheral identifier Bits [31:0]: these bits returns the DFSDM identifier ID[31:0] = 0x0011 0031


\
\ @brief DFSDM size identification register
\ Address offset: 0x7FC
\ Reset value: 0xA3C5DD02
\

$00000000 constant DFSDM_DFSDM_SIDR_SID                             \ Size identification of DFSDM peripheral Bits [31:8]: fixed code = 0xA3C5DD Bits [7:0]: these bits returns the size of the memory region allocated to DFSDM registers.


\
\ @brief DFSDM
\
$4400d000 constant DFSDM_DFSDM_CH0CFGR1  \ offset: 0x00 : DFSDM channel 0 configuration register
$4400d004 constant DFSDM_DFSDM_CH0CFGR2  \ offset: 0x04 : DFSDM channel 0 configuration register
$4400d008 constant DFSDM_DFSDM_CH0AWSCDR  \ offset: 0x08 : DFSDM channel 0 analog watchdog and short-circuit detector register
$4400d00c constant DFSDM_DFSDM_CH0WDATR  \ offset: 0x0C : DFSDM channel 0 watchdog filter data register
$4400d010 constant DFSDM_DFSDM_CH0DATINR  \ offset: 0x10 : DFSDM channel 0 data input register
$4400d014 constant DFSDM_DFSDM_CH0DLYR  \ offset: 0x14 : Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
$4400d020 constant DFSDM_DFSDM_CH1CFGR1  \ offset: 0x20 : DFSDM channel 1 configuration register
$4400d024 constant DFSDM_DFSDM_CH1CFGR2  \ offset: 0x24 : DFSDM channel 1 configuration register
$4400d028 constant DFSDM_DFSDM_CH1AWSCDR  \ offset: 0x28 : DFSDM channel 1 analog watchdog and short-circuit detector register
$4400d02c constant DFSDM_DFSDM_CH1WDATR  \ offset: 0x2C : DFSDM channel 1 watchdog filter data register
$4400d030 constant DFSDM_DFSDM_CH1DATINR  \ offset: 0x30 : DFSDM channel 1 data input register
$4400d034 constant DFSDM_DFSDM_CH1DLYR  \ offset: 0x34 : Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
$4400d040 constant DFSDM_DFSDM_CH2CFGR1  \ offset: 0x40 : DFSDM channel 2 configuration register
$4400d044 constant DFSDM_DFSDM_CH2CFGR2  \ offset: 0x44 : DFSDM channel 2 configuration register
$4400d048 constant DFSDM_DFSDM_CH2AWSCDR  \ offset: 0x48 : DFSDM channel 2 analog watchdog and short-circuit detector register
$4400d04c constant DFSDM_DFSDM_CH2WDATR  \ offset: 0x4C : DFSDM channel 2 watchdog filter data register
$4400d050 constant DFSDM_DFSDM_CH2DATINR  \ offset: 0x50 : DFSDM channel 2 data input register
$4400d054 constant DFSDM_DFSDM_CH2DLYR  \ offset: 0x54 : Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
$4400d060 constant DFSDM_DFSDM_CH3CFGR1  \ offset: 0x60 : DFSDM channel 3 configuration register
$4400d064 constant DFSDM_DFSDM_CH3CFGR2  \ offset: 0x64 : DFSDM channel 3 configuration register
$4400d068 constant DFSDM_DFSDM_CH3AWSCDR  \ offset: 0x68 : DFSDM channel 3 analog watchdog and short-circuit detector register
$4400d06c constant DFSDM_DFSDM_CH3WDATR  \ offset: 0x6C : DFSDM channel 3 watchdog filter data register
$4400d070 constant DFSDM_DFSDM_CH3DATINR  \ offset: 0x70 : DFSDM channel 3 data input register
$4400d074 constant DFSDM_DFSDM_CH3DLYR  \ offset: 0x74 : Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
$4400d094 constant DFSDM_DFSDM_CH4DLYR  \ offset: 0x94 : Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
$4400d0b4 constant DFSDM_DFSDM_CH5DLYR  \ offset: 0xB4 : Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
$4400d0d4 constant DFSDM_DFSDM_CH6DLYR  \ offset: 0xD4 : Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
$4400d0f4 constant DFSDM_DFSDM_CH7DLYR  \ offset: 0xF4 : Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
$4400d100 constant DFSDM_DFSDM_FLT0CR1  \ offset: 0x100 : DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
$4400d104 constant DFSDM_DFSDM_FLT0CR2  \ offset: 0x104 : Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
$4400d108 constant DFSDM_DFSDM_FLT0ISR  \ offset: 0x108 : End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
$4400d10c constant DFSDM_DFSDM_FLT0ICR  \ offset: 0x10C : Clear the injected conversion overrun flag
$4400d110 constant DFSDM_DFSDM_FLT0JCHGR  \ offset: 0x110 : Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
$4400d114 constant DFSDM_DFSDM_FLT0FCR  \ offset: 0x114 : Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
$4400d118 constant DFSDM_DFSDM_FLT0JDATAR  \ offset: 0x118 : Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[1:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[1:0].
$4400d11c constant DFSDM_DFSDM_FLT0RDATAR  \ offset: 0x11C : Regular channel most recently converted When each regular conversion finishes, RDATACH[1:0] is updated to indicate which channel was converted (because regular channel selection RCH[1:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[1:0].
$4400d120 constant DFSDM_DFSDM_FLT0AWHTR  \ offset: 0x120 : Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
$4400d124 constant DFSDM_DFSDM_FLT0AWLTR  \ offset: 0x124 : Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
$4400d128 constant DFSDM_DFSDM_FLT0AWSR  \ offset: 0x128 : Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
$4400d12c constant DFSDM_DFSDM_FLT0AWCFR  \ offset: 0x12C : Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
$4400d130 constant DFSDM_DFSDM_FLT0EXMAX  \ offset: 0x130 : Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
$4400d134 constant DFSDM_DFSDM_FLT0EXMIN  \ offset: 0x134 : Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
$4400d138 constant DFSDM_DFSDM_FLT0CNVTIMR  \ offset: 0x138 : 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
$4400d180 constant DFSDM_DFSDM_FLT1CR1  \ offset: 0x180 : DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
$4400d184 constant DFSDM_DFSDM_FLT1CR2  \ offset: 0x184 : Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
$4400d188 constant DFSDM_DFSDM_FLT1ISR  \ offset: 0x188 : End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
$4400d18c constant DFSDM_DFSDM_FLT1ICR  \ offset: 0x18C : Clear the injected conversion overrun flag
$4400d190 constant DFSDM_DFSDM_FLT1JCHGR  \ offset: 0x190 : Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
$4400d194 constant DFSDM_DFSDM_FLT1FCR  \ offset: 0x194 : Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
$4400d198 constant DFSDM_DFSDM_FLT1JDATAR  \ offset: 0x198 : Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[1:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[1:0].
$4400d19c constant DFSDM_DFSDM_FLT1RDATAR  \ offset: 0x19C : Regular channel most recently converted When each regular conversion finishes, RDATACH[1:0] is updated to indicate which channel was converted (because regular channel selection RCH[1:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[1:0].
$4400d1a0 constant DFSDM_DFSDM_FLT1AWHTR  \ offset: 0x1A0 : Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
$4400d1a4 constant DFSDM_DFSDM_FLT1AWLTR  \ offset: 0x1A4 : Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
$4400d1a8 constant DFSDM_DFSDM_FLT1AWSR  \ offset: 0x1A8 : Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
$4400d1ac constant DFSDM_DFSDM_FLT1AWCFR  \ offset: 0x1AC : Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
$4400d1b0 constant DFSDM_DFSDM_FLT1EXMAX  \ offset: 0x1B0 : Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
$4400d1b4 constant DFSDM_DFSDM_FLT1EXMIN  \ offset: 0x1B4 : Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
$4400d1b8 constant DFSDM_DFSDM_FLT1CNVTIMR  \ offset: 0x1B8 : 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
$4400d7f0 constant DFSDM_DFSDM_HWCFGR  \ offset: 0x7F0 : DFSDM hardware configuration register
$4400d7f4 constant DFSDM_DFSDM_VERR  \ offset: 0x7F4 : DFSDM version register
$4400d7f8 constant DFSDM_DFSDM_IPIDR  \ offset: 0x7F8 : DFSDM identification register
$4400d7fc constant DFSDM_DFSDM_SIDR  \ offset: 0x7FC : DFSDM size identification register

