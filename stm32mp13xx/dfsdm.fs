\
\ @file dfsdm.fs
\ @brief DFSDM
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DFSDM_DEF

  [ifdef] DFSDM_DFSDM_CH0CFGR1_DEF
    \
    \ @brief DFSDM channel 0 configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SITP                     \ [0x00 : 2] Serial interface type for channel y This value can only be modified when CHEN=0 (in DFSDM_CHyCFGR1 register).
    $02 constant DFSDM_SPICKSEL                 \ [0x02 : 2] SPI clock select for channel y 2: clock coming from internal CKOUT - sampling point on each second CKOUT falling edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input rising edge). 3: clock coming from internal CKOUT output - sampling point on each second CKOUT rising edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input falling edge). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
    $05 constant DFSDM_SCDEN                    \ [0x05] Short-circuit detector enable on channel y
    $06 constant DFSDM_CKABEN                   \ [0x06] Clock absence detector enable on channel y
    $07 constant DFSDM_CHEN                     \ [0x07] Channel y enable If channel y is enabled, then serial data receiving is started according to the given channel setting.
    $08 constant DFSDM_CHINSEL                  \ [0x08] Channel inputs selection This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
    $0c constant DFSDM_DATMPX                   \ [0x0c : 2] Input data multiplexer for channel y 2: Data to channel y are taken from internal DFSDM_CHyDATINR register by direct CPU/DMA write. There can be written one or two 16-bit data samples according DATPACK[1:0] bit field setting. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
    $0e constant DFSDM_DATPACK                  \ [0x0e : 2] Data packing mode in DFSDM_CHyDATINR register. first sample in INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y) To empty DFSDM_CHyDATINR register, two samples must be read by the digital filter from channel y (INDAT0[15:0] part is read as first sample and then INDAT1[15:0] part is read as next sample). 2: Dual: input data in DFSDM_CHyDATINR register are stored as two samples: first sample INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y+1) To empty DFSDM_CHyDATINR register first sample must be read by the digital filter from channel y and second sample must be read by another digital filter from channel y+1. Dual mode is available only on even channel numbers (y = 0, 2), for odd channel numbers (y = 1, 3) DFSDM_CHyDATINR is write protected. If an even channel is set to dual mode then the following odd channel must be set into standard mode (DATPACK[1:0]=0) for correct cooperation with even channel. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
    $10 constant DFSDM_CKOUTDIV                 \ [0x10 : 8] Output serial clock divider Â 256 (Divider = CKOUTDIV+1). CKOUTDIV also defines the threshold for a clock absence detection. This value can only be modified when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). If DFSDMEN=0 (in DFSDM_CH0CFGR1 register) then CKOUT signal is set to low state (setting is performed one DFSDM clock cycle after DFSDMEN=0). Note: CKOUTDIV is present only in DFSDM_CH0CFGR1 register (channel y=0) 1- 255: Defines the division of system clock for the serial clock output for CKOUT signal in range 2Â -
    $1e constant DFSDM_CKOUTSRC                 \ [0x1e] Output serial clock source selection This value can be modified only when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). Note: CKOUTSRC is present only in DFSDM_CH0CFGR1 register (channel y=0)
    $1f constant DFSDM_DFSDMEN                  \ [0x1f] Global enable for DFSDM interface If DFSDM interface is enabled, then it is started to operate according to enabled y channels and enabled x filters settings (CHEN bit in DFSDM_CHyCFGR1 and DFEN bit in DFSDM_FLTxCR1). Data cleared by setting DFSDMEN=0: all registers DFSDM_FLTxISR are set to reset state (x = 0..1) all registers DFSDM_FLTxAWSR are set to reset state (x = 0..1) Note: DFSDMEN is present only in DFSDM_CH0CFGR1 register (channel y=0)
  [then]


  [ifdef] DFSDM_DFSDM_CH0CFGR2_DEF
    \
    \ @brief DFSDM channel 0 configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM_DTRBS                    \ [0x03 : 5] Data right bit-shift for channel y will be performed to have final results. Bit-shift is performed before offset correction. The data shift is rounding the result to nearest integer value. The sign of shifted result is maintained (to have valid 24-bit signed format of result data). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). 0-31: Defines the shift of the data result coming from the integrator - how many bit shifts to the right
    $08 constant DFSDM_OFFSET                   \ [0x08 : 24] 24-bit calibration offset for channel y For channel y, OFFSET is applied to the results of each conversion from this channel. This value is set by software.
  [then]


  [ifdef] DFSDM_DFSDM_CH0AWSCDR_DEF
    \
    \ @brief DFSDM channel 0 analog watchdog and short-circuit detector register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SCDT                     \ [0x00 : 8] short-circuit detector threshold for channel y These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given channel.
    $0c constant DFSDM_BKSCD                    \ [0x0c : 4] Break signal assignment for short-circuit detector on channel y BKSCD[i] = 0: Break i signal not assigned to short-circuit detector on channel y BKSCD[i] = 1: Break i signal assigned to short-circuit detector on channel y
    $10 constant DFSDM_AWFOSR                   \ [0x10 : 5] Analog watchdog filter oversampling ratio (decimation rate) on channel y also the decimation ratio of the analog data rate. This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). Note: If AWFOSR = 0 then the filter has no effect (filter bypass). 0 - 31: Defines the length of the Sinc type filter in the range 1 - 32 (AWFOSR + 1). This number is
    $16 constant DFSDM_AWFORD                   \ [0x16 : 2] Analog watchdog Sinc filter order on channel y 2: Sinc2 filter type 3: Sinc3 filter type Sincx filter type transfer function: FastSinc filter type transfer function: This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
  [then]


  [ifdef] DFSDM_DFSDM_CH0WDATR_DEF
    \
    \ @brief DFSDM channel 0 watchdog filter data register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_WDATA                    \ [0x00 : 16] Input channel y watchdog data Data converted by the analog watchdog filter for input channel y. This data is continuously converted (no trigger) for this channel, with a limited resolution (OSR=1..32/sinc order = 1..3).
  [then]


  [ifdef] DFSDM_DFSDM_CH0DATINR_DEF
    \
    \ @brief DFSDM channel 0 data input register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_INDAT0                   \ [0x00 : 16] Input data for channel y Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) Channel y data sample is stored into INDAT0[15:0]. If DATPACK[1:0]=1 (interleaved mode) First channel y data sample is stored into INDAT0[15:0]. Second channel y data sample is stored into INDAT1[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: Channel y data sample is stored into INDAT0[15:0]. For odd y channels: INDAT0[15:0] is write protected. See for more details. INDAT0[15:0] is in the16-bit signed format.
    $10 constant DFSDM_INDAT1                   \ [0x10 : 16] Input data for channel y or channel y+1 Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) INDAT0[15:0] is write protected (not used for input sample). If DATPACK[1:0]=1 (interleaved mode) Second channel y data sample is stored into INDAT1[15:0]. First channel y data sample is stored into INDAT0[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: sample in INDAT1[15:0] is automatically copied into INDAT0[15:0] of channel (y+1). For odd y channels: INDAT1[15:0] is write protected. See for more details. INDAT0[15:1] is in the16-bit signed format.
  [then]


  [ifdef] DFSDM_DFSDM_CH0DLYR_DEF
    \
    \ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_PLSSKP                   \ [0x00 : 6] Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
  [then]


  [ifdef] DFSDM_DFSDM_CH1CFGR1_DEF
    \
    \ @brief DFSDM channel 1 configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SITP                     \ [0x00 : 2] Serial interface type for channel y This value can only be modified when CHEN=0 (in DFSDM_CHyCFGR1 register).
    $02 constant DFSDM_SPICKSEL                 \ [0x02 : 2] SPI clock select for channel y 2: clock coming from internal CKOUT - sampling point on each second CKOUT falling edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input rising edge). 3: clock coming from internal CKOUT output - sampling point on each second CKOUT rising edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input falling edge). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
    $05 constant DFSDM_SCDEN                    \ [0x05] Short-circuit detector enable on channel y
    $06 constant DFSDM_CKABEN                   \ [0x06] Clock absence detector enable on channel y
    $07 constant DFSDM_CHEN                     \ [0x07] Channel y enable If channel y is enabled, then serial data receiving is started according to the given channel setting.
    $08 constant DFSDM_CHINSEL                  \ [0x08] Channel inputs selection This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
    $0c constant DFSDM_DATMPX                   \ [0x0c : 2] Input data multiplexer for channel y 2: Data to channel y are taken from internal DFSDM_CHyDATINR register by direct CPU/DMA write. There can be written one or two 16-bit data samples according DATPACK[1:0] bit field setting. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
    $0e constant DFSDM_DATPACK                  \ [0x0e : 2] Data packing mode in DFSDM_CHyDATINR register. first sample in INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y) To empty DFSDM_CHyDATINR register, two samples must be read by the digital filter from channel y (INDAT0[15:0] part is read as first sample and then INDAT1[15:0] part is read as next sample). 2: Dual: input data in DFSDM_CHyDATINR register are stored as two samples: first sample INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y+1) To empty DFSDM_CHyDATINR register first sample must be read by the digital filter from channel y and second sample must be read by another digital filter from channel y+1. Dual mode is available only on even channel numbers (y = 0, 2), for odd channel numbers (y = 1, 3) DFSDM_CHyDATINR is write protected. If an even channel is set to dual mode then the following odd channel must be set into standard mode (DATPACK[1:0]=0) for correct cooperation with even channel. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
    $10 constant DFSDM_CKOUTDIV                 \ [0x10 : 8] Output serial clock divider Â 256 (Divider = CKOUTDIV+1). CKOUTDIV also defines the threshold for a clock absence detection. This value can only be modified when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). If DFSDMEN=0 (in DFSDM_CH0CFGR1 register) then CKOUT signal is set to low state (setting is performed one DFSDM clock cycle after DFSDMEN=0). Note: CKOUTDIV is present only in DFSDM_CH0CFGR1 register (channel y=0) 1- 255: Defines the division of system clock for the serial clock output for CKOUT signal in range 2Â -
    $1e constant DFSDM_CKOUTSRC                 \ [0x1e] Output serial clock source selection This value can be modified only when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). Note: CKOUTSRC is present only in DFSDM_CH0CFGR1 register (channel y=0)
    $1f constant DFSDM_DFSDMEN                  \ [0x1f] Global enable for DFSDM interface If DFSDM interface is enabled, then it is started to operate according to enabled y channels and enabled x filters settings (CHEN bit in DFSDM_CHyCFGR1 and DFEN bit in DFSDM_FLTxCR1). Data cleared by setting DFSDMEN=0: all registers DFSDM_FLTxISR are set to reset state (x = 0..1) all registers DFSDM_FLTxAWSR are set to reset state (x = 0..1) Note: DFSDMEN is present only in DFSDM_CH0CFGR1 register (channel y=0)
  [then]


  [ifdef] DFSDM_DFSDM_CH1CFGR2_DEF
    \
    \ @brief DFSDM channel 1 configuration register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM_DTRBS                    \ [0x03 : 5] Data right bit-shift for channel y will be performed to have final results. Bit-shift is performed before offset correction. The data shift is rounding the result to nearest integer value. The sign of shifted result is maintained (to have valid 24-bit signed format of result data). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). 0-31: Defines the shift of the data result coming from the integrator - how many bit shifts to the right
    $08 constant DFSDM_OFFSET                   \ [0x08 : 24] 24-bit calibration offset for channel y For channel y, OFFSET is applied to the results of each conversion from this channel. This value is set by software.
  [then]


  [ifdef] DFSDM_DFSDM_CH1AWSCDR_DEF
    \
    \ @brief DFSDM channel 1 analog watchdog and short-circuit detector register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SCDT                     \ [0x00 : 8] short-circuit detector threshold for channel y These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given channel.
    $0c constant DFSDM_BKSCD                    \ [0x0c : 4] Break signal assignment for short-circuit detector on channel y BKSCD[i] = 0: Break i signal not assigned to short-circuit detector on channel y BKSCD[i] = 1: Break i signal assigned to short-circuit detector on channel y
    $10 constant DFSDM_AWFOSR                   \ [0x10 : 5] Analog watchdog filter oversampling ratio (decimation rate) on channel y also the decimation ratio of the analog data rate. This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). Note: If AWFOSR = 0 then the filter has no effect (filter bypass). 0 - 31: Defines the length of the Sinc type filter in the range 1 - 32 (AWFOSR + 1). This number is
    $16 constant DFSDM_AWFORD                   \ [0x16 : 2] Analog watchdog Sinc filter order on channel y 2: Sinc2 filter type 3: Sinc3 filter type Sincx filter type transfer function: FastSinc filter type transfer function: This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
  [then]


  [ifdef] DFSDM_DFSDM_CH1WDATR_DEF
    \
    \ @brief DFSDM channel 1 watchdog filter data register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_WDATA                    \ [0x00 : 16] Input channel y watchdog data Data converted by the analog watchdog filter for input channel y. This data is continuously converted (no trigger) for this channel, with a limited resolution (OSR=1..32/sinc order = 1..3).
  [then]


  [ifdef] DFSDM_DFSDM_CH1DATINR_DEF
    \
    \ @brief DFSDM channel 1 data input register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_INDAT0                   \ [0x00 : 16] Input data for channel y Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) Channel y data sample is stored into INDAT0[15:0]. If DATPACK[1:0]=1 (interleaved mode) First channel y data sample is stored into INDAT0[15:0]. Second channel y data sample is stored into INDAT1[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: Channel y data sample is stored into INDAT0[15:0]. For odd y channels: INDAT0[15:0] is write protected. See for more details. INDAT0[15:0] is in the16-bit signed format.
    $10 constant DFSDM_INDAT1                   \ [0x10 : 16] Input data for channel y or channel y+1 Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) INDAT0[15:0] is write protected (not used for input sample). If DATPACK[1:0]=1 (interleaved mode) Second channel y data sample is stored into INDAT1[15:0]. First channel y data sample is stored into INDAT0[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: sample in INDAT1[15:0] is automatically copied into INDAT0[15:0] of channel (y+1). For odd y channels: INDAT1[15:0] is write protected. See for more details. INDAT0[15:1] is in the16-bit signed format.
  [then]


  [ifdef] DFSDM_DFSDM_CH1DLYR_DEF
    \
    \ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_PLSSKP                   \ [0x00 : 6] Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
  [then]


  [ifdef] DFSDM_DFSDM_CH2CFGR1_DEF
    \
    \ @brief DFSDM channel 2 configuration register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SITP                     \ [0x00 : 2] Serial interface type for channel y This value can only be modified when CHEN=0 (in DFSDM_CHyCFGR1 register).
    $02 constant DFSDM_SPICKSEL                 \ [0x02 : 2] SPI clock select for channel y 2: clock coming from internal CKOUT - sampling point on each second CKOUT falling edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input rising edge). 3: clock coming from internal CKOUT output - sampling point on each second CKOUT rising edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input falling edge). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
    $05 constant DFSDM_SCDEN                    \ [0x05] Short-circuit detector enable on channel y
    $06 constant DFSDM_CKABEN                   \ [0x06] Clock absence detector enable on channel y
    $07 constant DFSDM_CHEN                     \ [0x07] Channel y enable If channel y is enabled, then serial data receiving is started according to the given channel setting.
    $08 constant DFSDM_CHINSEL                  \ [0x08] Channel inputs selection This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
    $0c constant DFSDM_DATMPX                   \ [0x0c : 2] Input data multiplexer for channel y 2: Data to channel y are taken from internal DFSDM_CHyDATINR register by direct CPU/DMA write. There can be written one or two 16-bit data samples according DATPACK[1:0] bit field setting. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
    $0e constant DFSDM_DATPACK                  \ [0x0e : 2] Data packing mode in DFSDM_CHyDATINR register. first sample in INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y) To empty DFSDM_CHyDATINR register, two samples must be read by the digital filter from channel y (INDAT0[15:0] part is read as first sample and then INDAT1[15:0] part is read as next sample). 2: Dual: input data in DFSDM_CHyDATINR register are stored as two samples: first sample INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y+1) To empty DFSDM_CHyDATINR register first sample must be read by the digital filter from channel y and second sample must be read by another digital filter from channel y+1. Dual mode is available only on even channel numbers (y = 0, 2), for odd channel numbers (y = 1, 3) DFSDM_CHyDATINR is write protected. If an even channel is set to dual mode then the following odd channel must be set into standard mode (DATPACK[1:0]=0) for correct cooperation with even channel. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
    $10 constant DFSDM_CKOUTDIV                 \ [0x10 : 8] Output serial clock divider Â 256 (Divider = CKOUTDIV+1). CKOUTDIV also defines the threshold for a clock absence detection. This value can only be modified when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). If DFSDMEN=0 (in DFSDM_CH0CFGR1 register) then CKOUT signal is set to low state (setting is performed one DFSDM clock cycle after DFSDMEN=0). Note: CKOUTDIV is present only in DFSDM_CH0CFGR1 register (channel y=0) 1- 255: Defines the division of system clock for the serial clock output for CKOUT signal in range 2Â -
    $1e constant DFSDM_CKOUTSRC                 \ [0x1e] Output serial clock source selection This value can be modified only when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). Note: CKOUTSRC is present only in DFSDM_CH0CFGR1 register (channel y=0)
    $1f constant DFSDM_DFSDMEN                  \ [0x1f] Global enable for DFSDM interface If DFSDM interface is enabled, then it is started to operate according to enabled y channels and enabled x filters settings (CHEN bit in DFSDM_CHyCFGR1 and DFEN bit in DFSDM_FLTxCR1). Data cleared by setting DFSDMEN=0: all registers DFSDM_FLTxISR are set to reset state (x = 0..1) all registers DFSDM_FLTxAWSR are set to reset state (x = 0..1) Note: DFSDMEN is present only in DFSDM_CH0CFGR1 register (channel y=0)
  [then]


  [ifdef] DFSDM_DFSDM_CH2CFGR2_DEF
    \
    \ @brief DFSDM channel 2 configuration register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM_DTRBS                    \ [0x03 : 5] Data right bit-shift for channel y will be performed to have final results. Bit-shift is performed before offset correction. The data shift is rounding the result to nearest integer value. The sign of shifted result is maintained (to have valid 24-bit signed format of result data). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). 0-31: Defines the shift of the data result coming from the integrator - how many bit shifts to the right
    $08 constant DFSDM_OFFSET                   \ [0x08 : 24] 24-bit calibration offset for channel y For channel y, OFFSET is applied to the results of each conversion from this channel. This value is set by software.
  [then]


  [ifdef] DFSDM_DFSDM_CH2AWSCDR_DEF
    \
    \ @brief DFSDM channel 2 analog watchdog and short-circuit detector register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SCDT                     \ [0x00 : 8] short-circuit detector threshold for channel y These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given channel.
    $0c constant DFSDM_BKSCD                    \ [0x0c : 4] Break signal assignment for short-circuit detector on channel y BKSCD[i] = 0: Break i signal not assigned to short-circuit detector on channel y BKSCD[i] = 1: Break i signal assigned to short-circuit detector on channel y
    $10 constant DFSDM_AWFOSR                   \ [0x10 : 5] Analog watchdog filter oversampling ratio (decimation rate) on channel y also the decimation ratio of the analog data rate. This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). Note: If AWFOSR = 0 then the filter has no effect (filter bypass). 0 - 31: Defines the length of the Sinc type filter in the range 1 - 32 (AWFOSR + 1). This number is
    $16 constant DFSDM_AWFORD                   \ [0x16 : 2] Analog watchdog Sinc filter order on channel y 2: Sinc2 filter type 3: Sinc3 filter type Sincx filter type transfer function: FastSinc filter type transfer function: This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
  [then]


  [ifdef] DFSDM_DFSDM_CH2WDATR_DEF
    \
    \ @brief DFSDM channel 2 watchdog filter data register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_WDATA                    \ [0x00 : 16] Input channel y watchdog data Data converted by the analog watchdog filter for input channel y. This data is continuously converted (no trigger) for this channel, with a limited resolution (OSR=1..32/sinc order = 1..3).
  [then]


  [ifdef] DFSDM_DFSDM_CH2DATINR_DEF
    \
    \ @brief DFSDM channel 2 data input register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_INDAT0                   \ [0x00 : 16] Input data for channel y Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) Channel y data sample is stored into INDAT0[15:0]. If DATPACK[1:0]=1 (interleaved mode) First channel y data sample is stored into INDAT0[15:0]. Second channel y data sample is stored into INDAT1[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: Channel y data sample is stored into INDAT0[15:0]. For odd y channels: INDAT0[15:0] is write protected. See for more details. INDAT0[15:0] is in the16-bit signed format.
    $10 constant DFSDM_INDAT1                   \ [0x10 : 16] Input data for channel y or channel y+1 Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) INDAT0[15:0] is write protected (not used for input sample). If DATPACK[1:0]=1 (interleaved mode) Second channel y data sample is stored into INDAT1[15:0]. First channel y data sample is stored into INDAT0[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: sample in INDAT1[15:0] is automatically copied into INDAT0[15:0] of channel (y+1). For odd y channels: INDAT1[15:0] is write protected. See for more details. INDAT0[15:1] is in the16-bit signed format.
  [then]


  [ifdef] DFSDM_DFSDM_CH2DLYR_DEF
    \
    \ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_PLSSKP                   \ [0x00 : 6] Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
  [then]


  [ifdef] DFSDM_DFSDM_CH3CFGR1_DEF
    \
    \ @brief DFSDM channel 3 configuration register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SITP                     \ [0x00 : 2] Serial interface type for channel y This value can only be modified when CHEN=0 (in DFSDM_CHyCFGR1 register).
    $02 constant DFSDM_SPICKSEL                 \ [0x02 : 2] SPI clock select for channel y 2: clock coming from internal CKOUT - sampling point on each second CKOUT falling edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input rising edge). 3: clock coming from internal CKOUT output - sampling point on each second CKOUT rising edge. For connection to external Î£â modulator which divides its clock input (from CKOUT) by 2 to generate its output serial communication clock (and this output clock change is active on each clock input falling edge). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
    $05 constant DFSDM_SCDEN                    \ [0x05] Short-circuit detector enable on channel y
    $06 constant DFSDM_CKABEN                   \ [0x06] Clock absence detector enable on channel y
    $07 constant DFSDM_CHEN                     \ [0x07] Channel y enable If channel y is enabled, then serial data receiving is started according to the given channel setting.
    $08 constant DFSDM_CHINSEL                  \ [0x08] Channel inputs selection This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
    $0c constant DFSDM_DATMPX                   \ [0x0c : 2] Input data multiplexer for channel y 2: Data to channel y are taken from internal DFSDM_CHyDATINR register by direct CPU/DMA write. There can be written one or two 16-bit data samples according DATPACK[1:0] bit field setting. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
    $0e constant DFSDM_DATPACK                  \ [0x0e : 2] Data packing mode in DFSDM_CHyDATINR register. first sample in INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y) To empty DFSDM_CHyDATINR register, two samples must be read by the digital filter from channel y (INDAT0[15:0] part is read as first sample and then INDAT1[15:0] part is read as next sample). 2: Dual: input data in DFSDM_CHyDATINR register are stored as two samples: first sample INDAT0[15:0] (assigned to channel y) second sample INDAT1[15:0] (assigned to channel y+1) To empty DFSDM_CHyDATINR register first sample must be read by the digital filter from channel y and second sample must be read by another digital filter from channel y+1. Dual mode is available only on even channel numbers (y = 0, 2), for odd channel numbers (y = 1, 3) DFSDM_CHyDATINR is write protected. If an even channel is set to dual mode then the following odd channel must be set into standard mode (DATPACK[1:0]=0) for correct cooperation with even channel. 3: Reserved This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
    $10 constant DFSDM_CKOUTDIV                 \ [0x10 : 8] Output serial clock divider Â 256 (Divider = CKOUTDIV+1). CKOUTDIV also defines the threshold for a clock absence detection. This value can only be modified when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). If DFSDMEN=0 (in DFSDM_CH0CFGR1 register) then CKOUT signal is set to low state (setting is performed one DFSDM clock cycle after DFSDMEN=0). Note: CKOUTDIV is present only in DFSDM_CH0CFGR1 register (channel y=0) 1- 255: Defines the division of system clock for the serial clock output for CKOUT signal in range 2Â -
    $1e constant DFSDM_CKOUTSRC                 \ [0x1e] Output serial clock source selection This value can be modified only when DFSDMEN=0 (in DFSDM_CH0CFGR1 register). Note: CKOUTSRC is present only in DFSDM_CH0CFGR1 register (channel y=0)
    $1f constant DFSDM_DFSDMEN                  \ [0x1f] Global enable for DFSDM interface If DFSDM interface is enabled, then it is started to operate according to enabled y channels and enabled x filters settings (CHEN bit in DFSDM_CHyCFGR1 and DFEN bit in DFSDM_FLTxCR1). Data cleared by setting DFSDMEN=0: all registers DFSDM_FLTxISR are set to reset state (x = 0..1) all registers DFSDM_FLTxAWSR are set to reset state (x = 0..1) Note: DFSDMEN is present only in DFSDM_CH0CFGR1 register (channel y=0)
  [then]


  [ifdef] DFSDM_DFSDM_CH3CFGR2_DEF
    \
    \ @brief DFSDM channel 3 configuration register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM_DTRBS                    \ [0x03 : 5] Data right bit-shift for channel y will be performed to have final results. Bit-shift is performed before offset correction. The data shift is rounding the result to nearest integer value. The sign of shifted result is maintained (to have valid 24-bit signed format of result data). This value can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). 0-31: Defines the shift of the data result coming from the integrator - how many bit shifts to the right
    $08 constant DFSDM_OFFSET                   \ [0x08 : 24] 24-bit calibration offset for channel y For channel y, OFFSET is applied to the results of each conversion from this channel. This value is set by software.
  [then]


  [ifdef] DFSDM_DFSDM_CH3AWSCDR_DEF
    \
    \ @brief DFSDM channel 3 analog watchdog and short-circuit detector register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SCDT                     \ [0x00 : 8] short-circuit detector threshold for channel y These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given channel.
    $0c constant DFSDM_BKSCD                    \ [0x0c : 4] Break signal assignment for short-circuit detector on channel y BKSCD[i] = 0: Break i signal not assigned to short-circuit detector on channel y BKSCD[i] = 1: Break i signal assigned to short-circuit detector on channel y
    $10 constant DFSDM_AWFOSR                   \ [0x10 : 5] Analog watchdog filter oversampling ratio (decimation rate) on channel y also the decimation ratio of the analog data rate. This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register). Note: If AWFOSR = 0 then the filter has no effect (filter bypass). 0 - 31: Defines the length of the Sinc type filter in the range 1 - 32 (AWFOSR + 1). This number is
    $16 constant DFSDM_AWFORD                   \ [0x16 : 2] Analog watchdog Sinc filter order on channel y 2: Sinc2 filter type 3: Sinc3 filter type Sincx filter type transfer function: FastSinc filter type transfer function: This bit can be modified only when CHEN=0 (in DFSDM_CHyCFGR1 register).
  [then]


  [ifdef] DFSDM_DFSDM_CH3WDATR_DEF
    \
    \ @brief DFSDM channel 3 watchdog filter data register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_WDATA                    \ [0x00 : 16] Input channel y watchdog data Data converted by the analog watchdog filter for input channel y. This data is continuously converted (no trigger) for this channel, with a limited resolution (OSR=1..32/sinc order = 1..3).
  [then]


  [ifdef] DFSDM_DFSDM_CH3DATINR_DEF
    \
    \ @brief DFSDM channel 3 data input register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_INDAT0                   \ [0x00 : 16] Input data for channel y Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) Channel y data sample is stored into INDAT0[15:0]. If DATPACK[1:0]=1 (interleaved mode) First channel y data sample is stored into INDAT0[15:0]. Second channel y data sample is stored into INDAT1[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: Channel y data sample is stored into INDAT0[15:0]. For odd y channels: INDAT0[15:0] is write protected. See for more details. INDAT0[15:0] is in the16-bit signed format.
    $10 constant DFSDM_INDAT1                   \ [0x10 : 16] Input data for channel y or channel y+1 Input parallel channel data to be processed by the digital filter if DATMPX[1:0]=1 or DATMPX[1:0]=2. Data can be written by CPU/DMA (if DATMPX[1:0]=2) or directly by internal ADC (if DATMPX[1:0]=1). If DATPACK[1:0]=0 (standard mode) INDAT0[15:0] is write protected (not used for input sample). If DATPACK[1:0]=1 (interleaved mode) Second channel y data sample is stored into INDAT1[15:0]. First channel y data sample is stored into INDAT0[15:0]. Both samples are read sequentially by DFSDM_FLTx filter as two channel y data samples. If DATPACK[1:0]=2 (dual mode). For even y channels: sample in INDAT1[15:0] is automatically copied into INDAT0[15:0] of channel (y+1). For odd y channels: INDAT1[15:0] is write protected. See for more details. INDAT0[15:1] is in the16-bit signed format.
  [then]


  [ifdef] DFSDM_DFSDM_CH3DLYR_DEF
    \
    \ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_PLSSKP                   \ [0x00 : 6] Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
  [then]


  [ifdef] DFSDM_DFSDM_CH4DLYR_DEF
    \
    \ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_PLSSKP                   \ [0x00 : 6] Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
  [then]


  [ifdef] DFSDM_DFSDM_CH5DLYR_DEF
    \
    \ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_PLSSKP                   \ [0x00 : 6] Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
  [then]


  [ifdef] DFSDM_DFSDM_CH6DLYR_DEF
    \
    \ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_PLSSKP                   \ [0x00 : 6] Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
  [then]


  [ifdef] DFSDM_DFSDM_CH7DLYR_DEF
    \
    \ @brief Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_PLSSKP                   \ [0x00 : 6] Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
  [then]


  [ifdef] DFSDM_DFSDM_FLT0CR1_DEF
    \
    \ @brief DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_DFEN                     \ [0x00] DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
    $01 constant DFSDM_JSWSTART                 \ [0x01] Start a conversion of the injected group of channels This bit is always read as '0â.
    $03 constant DFSDM_JSYNC                    \ [0x03] Launch an injected conversion synchronously with the DFSDM_FLT0 JSWSTART trigger This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
    $04 constant DFSDM_JSCAN                    \ [0x04] Scanning conversion mode for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Writing JCHG if JSCAN=0 resets the channel selection to the lowest selected channel.
    $05 constant DFSDM_JDMAEN                   \ [0x05] DMA channel enabled to read data for the injected channel group This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
    $08 constant DFSDM_JEXTSEL                  \ [0x08 : 5] Trigger signal selection for launching injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Note: synchronous trigger has latency up to one fDFSDMCLK clock cycle (with deterministic jitter), asynchronous trigger has latency 2-3 fDFSDMCLK clock cycles (with jitter up to 1 cycle). DFSDM_FLTx 0x00 dfsdm_jtrg0 0x01 dfsdm_jtrg1 ... 0x1E dfsdm_jtrg30 0x1F dfsdm_jtrg31 Refer to . 0x0-0x1F: Trigger inputs selected by the following table (internal or external trigger).
    $0d constant DFSDM_JEXTEN                   \ [0x0d : 2] Trigger enable and trigger edge selection for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
    $11 constant DFSDM_RSWSTART                 \ [0x11] Software start of a conversion on the regular channel This bit is always read as '0â.
    $12 constant DFSDM_RCONT                    \ [0x12] Continuous mode selection for regular conversions Writing '0â to this bit while a continuous regular conversion is already in progress stops the continuous mode immediately.
    $13 constant DFSDM_RSYNC                    \ [0x13] Launch regular conversion synchronously with DFSDM_FLT0 This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
    $15 constant DFSDM_RDMAEN                   \ [0x15] DMA channel enabled to read data for the regular conversion This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
    $18 constant DFSDM_RCH                      \ [0x18 : 2] Regular channel selection ... 3: Chanel 3 is selected as the regular channel Writing this bit when RCIP=1 takes effect when the next regular conversion begins. This is especially useful in continuous mode (when RCONT=1). It also affects regular conversions which are pending (due to ongoing injected conversion).
    $1d constant DFSDM_FAST                     \ [0x1d] Fast conversion mode selection for regular conversions When converting a regular conversion in continuous mode, having enabled the fast mode causes each conversion (except the first) to execute faster than in standard mode. This bit has no effect on conversions which are not continuous. This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): t = IOSR / fCKIN (... but CNVCNT=0) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input.
    $1e constant DFSDM_AWFSEL                   \ [0x1e] Analog watchdog fast mode select
  [then]


  [ifdef] DFSDM_DFSDM_FLT0CR2_DEF
    \
    \ @brief Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_JEOCIE                   \ [0x00] Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
    $01 constant DFSDM_REOCIE                   \ [0x01] Regular end of conversion interrupt enable Please see the explanation of REOCF in DFSDM_FLTxISR.
    $02 constant DFSDM_JOVRIE                   \ [0x02] Injected data overrun interrupt enable Please see the explanation of JOVRF in DFSDM_FLTxISR.
    $03 constant DFSDM_ROVRIE                   \ [0x03] Regular data overrun interrupt enable Please see the explanation of ROVRF in DFSDM_FLTxISR.
    $04 constant DFSDM_AWDIE                    \ [0x04] Analog watchdog interrupt enable Please see the explanation of AWDF in DFSDM_FLTxISR.
    $05 constant DFSDM_SCDIE                    \ [0x05] Short-circuit detector interrupt enable Please see the explanation of SCDF[3:0] in DFSDM_FLTxISR. Note: SCDIE is present only in DFSDM_FLT0CR2 register (filter x=0)
    $06 constant DFSDM_CKABIE                   \ [0x06] Clock absence interrupt enable Please see the explanation of CKABF[3:0] in DFSDM_FLTxISR. Note: CKABIE is present only in DFSDM_FLT0CR2 register (filter x=0)
    $08 constant DFSDM_EXCH                     \ [0x08 : 4] Extremes detector channel selection These bits select the input channels to be taken by the Extremes detector. EXCH[y] = 0: Extremes detector does not accept data from channel y EXCH[y] = 1: Extremes detector accepts data from channel y
    $10 constant DFSDM_AWDCH                    \ [0x10 : 4] Analog watchdog channel selection These bits select the input channel to be guarded continuously by the analog watchdog. AWDCH[y] = 0: Analog watchdog is disabled on channel y AWDCH[y] = 1: Analog watchdog is enabled on channel y
  [then]


  [ifdef] DFSDM_DFSDM_FLT0ISR_DEF
    \
    \ @brief End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
    \ Address offset: 0x108
    \ Reset value: 0x00FF0000
    \
    $00 constant DFSDM_JEOCF                    \ [0x00] End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
    $01 constant DFSDM_REOCF                    \ [0x01] End of regular conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxRDATAR.
    $02 constant DFSDM_JOVRF                    \ [0x02] Injected conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRJOVRF bit in the DFSDM_FLTxICR register.
    $03 constant DFSDM_ROVRF                    \ [0x03] Regular conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRROVRF bit in the DFSDM_FLTxICR register.
    $04 constant DFSDM_AWDF                     \ [0x04] Analog watchdog This bit is set by hardware. It is cleared by software by clearing all source flag bits AWHTF[3:0] and AWLTF[3:0] in DFSDM_FLTxAWSR register (by writing '1â into the clear bits in DFSDM_FLTxAWCFR register).
    $0d constant DFSDM_JCIP                     \ [0x0d] Injected conversion in progress status A request to start an injected conversion is ignored when JCIP=1.
    $0e constant DFSDM_RCIP                     \ [0x0e] Regular conversion in progress status A request to start a regular conversion is ignored when RCIP=1.
    $10 constant DFSDM_CKABF                    \ [0x10 : 4] Clock absence flag CKABF[y]=0: Clock signal on channel y is present. CKABF[y]=1: Clock signal on channel y is not present. Given y bit is set by hardware when clock absence is detected on channel y. It is held at CKABF[y]=1 state by hardware when CHEN=0 (see DFSDM_CHyCFGR1 register). It is held at CKABF[y]=1 state by hardware when the transceiver is not yet synchronized.It can be cleared by software using the corresponding CLRCKABF[y] bit in the DFSDM_FLTxICR register. Note: CKABF[3:0] is present only in DFSDM_FLT0ISR register (filter x=0)
    $18 constant DFSDM_SCDF                     \ [0x18 : 4] short-circuit detector flag SDCF[y]=0: No short-circuit detector event occurred on channel y SDCF[y]=1: The short-circuit detector counter reaches, on channel y, the value programmed in the DFSDM_CHyAWSCDR registers This bit is set by hardware. It can be cleared by software using the corresponding CLRSCDF[y] bit in the DFSDM_FLTxICR register. SCDF[y] is cleared also by hardware when CHEN[y] = 0 (given channel is disabled). Note: SCDF[3:0] is present only in DFSDM_FLT0ISR register (filter x=0)
  [then]


  [ifdef] DFSDM_DFSDM_FLT0ICR_DEF
    \
    \ @brief Clear the injected conversion overrun flag
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $02 constant DFSDM_CLRJOVRF                 \ [0x02] Clear the injected conversion overrun flag
    $03 constant DFSDM_CLRROVRF                 \ [0x03] Clear the regular conversion overrun flag
    $10 constant DFSDM_CLRCKABF                 \ [0x10 : 4] Clear the clock absence flag CLRCKABF[y]=0: Writing '0â has no effect CLRCKABF[y]=1: Writing '1â to position y clears the corresponding CKABF[y] bit in the DFSDM_FLTxISR register. When the transceiver is not yet synchronized, the clock absence flag is set and cannot be cleared by CLRCKABF[y]. Note: CLRCKABF[3:0] is present only in DFSDM_FLT0ICR register (filter x=0)
    $18 constant DFSDM_CLRSCDF                  \ [0x18 : 4] Clear the short-circuit detector flag CLRSCDF[y]=0: Writing '0â has no effect CLRSCDF[y]=1: Writing '1â to position y clears the corresponding SCDF[y] bit in the DFSDM_FLTxISR register Note: CLRSCDF[3:0] is present only in DFSDM_FLT0ICR register (filter x=0)
  [then]


  [ifdef] DFSDM_DFSDM_FLT0JCHGR_DEF
    \
    \ @brief Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
    \ Address offset: 0x110
    \ Reset value: 0x00000001
    \
    $00 constant DFSDM_JCHG                     \ [0x00 : 4] Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
  [then]


  [ifdef] DFSDM_DFSDM_FLT0FCR_DEF
    \
    \ @brief Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_IOSR                     \ [0x00 : 8] Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
    $10 constant DFSDM_FOSR                     \ [0x10 : 10] Sinc filter oversampling ratio (decimation rate) number is also the decimation ratio of the output data rate from filter. This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If FOSR = 0, then the filter has no effect (filter bypass). 0 - 1023: Defines the length of the Sinc type filter in the range 1 - 1024 (FOSR = FOSR[9:0] +1). This
    $1d constant DFSDM_FORD                     \ [0x1d : 3] Sinc filter order 2: Sinc2 filter type 3: Sinc3 filter type 4: Sinc4 filter type 5: Sinc5 filter type 6-7: Reserved Sincx filter type transfer function: FastSinc filter type transfer function: This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1).
  [then]


  [ifdef] DFSDM_DFSDM_FLT0JDATAR_DEF
    \
    \ @brief Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[1:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[1:0].
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_JDATACH                  \ [0x00 : 2] Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[1:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[1:0].
    $08 constant DFSDM_JDATA                    \ [0x08 : 24] Injected group conversion data When each conversion of a channel in the injected group finishes, its resulting data is stored in this field. The data is valid when JEOCF=1. Reading this register clears the corresponding JEOCF.
  [then]


  [ifdef] DFSDM_DFSDM_FLT0RDATAR_DEF
    \
    \ @brief Regular channel most recently converted When each regular conversion finishes, RDATACH[1:0] is updated to indicate which channel was converted (because regular channel selection RCH[1:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[1:0].
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_RDATACH                  \ [0x00 : 2] Regular channel most recently converted When each regular conversion finishes, RDATACH[1:0] is updated to indicate which channel was converted (because regular channel selection RCH[1:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[1:0].
    $04 constant DFSDM_RPEND                    \ [0x04] Regular channel pending data Regular data in RDATA[23:0] was delayed due to an injected channel trigger during the conversion
    $08 constant DFSDM_RDATA                    \ [0x08 : 24] Regular channel conversion data When each regular conversion finishes, its data is stored in this register. The data is valid when REOCF=1. Reading this register clears the corresponding REOCF.
  [then]


  [ifdef] DFSDM_DFSDM_FLT0AWHTR_DEF
    \
    \ @brief Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_BKAWH                    \ [0x00 : 4] Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
    $08 constant DFSDM_AWHT                     \ [0x08 : 24] Analog watchdog high threshold These bits are written by software to define the high threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), the higher 16 bits (AWHT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWHT[7:0] are not taken into comparison in this case.
  [then]


  [ifdef] DFSDM_DFSDM_FLT0AWLTR_DEF
    \
    \ @brief Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_BKAWL                    \ [0x00 : 4] Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
    $08 constant DFSDM_AWLT                     \ [0x08 : 24] Analog watchdog low threshold These bits are written by software to define the low threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), only the higher 16 bits (AWLT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWLT[7:0] are not taken into comparison in this case.
  [then]


  [ifdef] DFSDM_DFSDM_FLT0AWSR_DEF
    \
    \ @brief Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_AWLTF                    \ [0x00 : 4] Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
    $08 constant DFSDM_AWHTF                    \ [0x08 : 4] Analog watchdog high threshold flag AWHTF[y]=1 indicates a high threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWHTF[y] bit in the DFSDM_FLTxAWCFR register.
  [then]


  [ifdef] DFSDM_DFSDM_FLT0AWCFR_DEF
    \
    \ @brief Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_CLRAWLTF                 \ [0x00 : 4] Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
    $08 constant DFSDM_CLRAWHTF                 \ [0x08 : 4] Clear the analog watchdog high threshold flag CLRAWHTF[y]=0: Writing '0â has no effect CLRAWHTF[y]=1: Writing '1â to position y clears the corresponding AWHTF[y] bit in the DFSDM_FLTxAWSR register
  [then]


  [ifdef] DFSDM_DFSDM_FLT0EXMAX_DEF
    \
    \ @brief Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
    \ Address offset: 0x130
    \ Reset value: 0x80000000
    \
    $00 constant DFSDM_EXMAXCH                  \ [0x00 : 2] Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
    $08 constant DFSDM_EXMAX                    \ [0x08 : 24] Extremes detector maximum value These bits are set by hardware and indicate the highest value converted by DFSDM_FLTx. EXMAX[23:0] bits are reset to value (0x800000) by reading of this register.
  [then]


  [ifdef] DFSDM_DFSDM_FLT0EXMIN_DEF
    \
    \ @brief Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
    \ Address offset: 0x134
    \ Reset value: 0x7FFFFF00
    \
    $00 constant DFSDM_EXMINCH                  \ [0x00 : 2] Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
    $08 constant DFSDM_EXMIN                    \ [0x08 : 24] Extremes detector minimum value These bits are set by hardware and indicate the lowest value converted by DFSDM_FLTx. EXMIN[23:0] bits are reset to value (0x7FFFFF) by reading of this register.
  [then]


  [ifdef] DFSDM_DFSDM_FLT0CNVTIMR_DEF
    \
    \ @brief 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $04 constant DFSDM_CNVCNT                   \ [0x04 : 28] 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
  [then]


  [ifdef] DFSDM_DFSDM_FLT1CR1_DEF
    \
    \ @brief DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_DFEN                     \ [0x00] DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
    $01 constant DFSDM_JSWSTART                 \ [0x01] Start a conversion of the injected group of channels This bit is always read as '0â.
    $03 constant DFSDM_JSYNC                    \ [0x03] Launch an injected conversion synchronously with the DFSDM_FLT0 JSWSTART trigger This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
    $04 constant DFSDM_JSCAN                    \ [0x04] Scanning conversion mode for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Writing JCHG if JSCAN=0 resets the channel selection to the lowest selected channel.
    $05 constant DFSDM_JDMAEN                   \ [0x05] DMA channel enabled to read data for the injected channel group This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
    $08 constant DFSDM_JEXTSEL                  \ [0x08 : 5] Trigger signal selection for launching injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). Note: synchronous trigger has latency up to one fDFSDMCLK clock cycle (with deterministic jitter), asynchronous trigger has latency 2-3 fDFSDMCLK clock cycles (with jitter up to 1 cycle). DFSDM_FLTx 0x00 dfsdm_jtrg0 0x01 dfsdm_jtrg1 ... 0x1E dfsdm_jtrg30 0x1F dfsdm_jtrg31 Refer to . 0x0-0x1F: Trigger inputs selected by the following table (internal or external trigger).
    $0d constant DFSDM_JEXTEN                   \ [0x0d : 2] Trigger enable and trigger edge selection for injected conversions This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
    $11 constant DFSDM_RSWSTART                 \ [0x11] Software start of a conversion on the regular channel This bit is always read as '0â.
    $12 constant DFSDM_RCONT                    \ [0x12] Continuous mode selection for regular conversions Writing '0â to this bit while a continuous regular conversion is already in progress stops the continuous mode immediately.
    $13 constant DFSDM_RSYNC                    \ [0x13] Launch regular conversion synchronously with DFSDM_FLT0 This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
    $15 constant DFSDM_RDMAEN                   \ [0x15] DMA channel enabled to read data for the regular conversion This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1).
    $18 constant DFSDM_RCH                      \ [0x18 : 2] Regular channel selection ... 3: Chanel 3 is selected as the regular channel Writing this bit when RCIP=1 takes effect when the next regular conversion begins. This is especially useful in continuous mode (when RCONT=1). It also affects regular conversions which are pending (due to ongoing injected conversion).
    $1d constant DFSDM_FAST                     \ [0x1d] Fast conversion mode selection for regular conversions When converting a regular conversion in continuous mode, having enabled the fast mode causes each conversion (except the first) to execute faster than in standard mode. This bit has no effect on conversions which are not continuous. This bit can be modified only when DFEN=0 (DFSDM_FLTxCR1). if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): t = IOSR / fCKIN (... but CNVCNT=0) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input.
    $1e constant DFSDM_AWFSEL                   \ [0x1e] Analog watchdog fast mode select
  [then]


  [ifdef] DFSDM_DFSDM_FLT1CR2_DEF
    \
    \ @brief Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_JEOCIE                   \ [0x00] Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
    $01 constant DFSDM_REOCIE                   \ [0x01] Regular end of conversion interrupt enable Please see the explanation of REOCF in DFSDM_FLTxISR.
    $02 constant DFSDM_JOVRIE                   \ [0x02] Injected data overrun interrupt enable Please see the explanation of JOVRF in DFSDM_FLTxISR.
    $03 constant DFSDM_ROVRIE                   \ [0x03] Regular data overrun interrupt enable Please see the explanation of ROVRF in DFSDM_FLTxISR.
    $04 constant DFSDM_AWDIE                    \ [0x04] Analog watchdog interrupt enable Please see the explanation of AWDF in DFSDM_FLTxISR.
    $05 constant DFSDM_SCDIE                    \ [0x05] Short-circuit detector interrupt enable Please see the explanation of SCDF[3:0] in DFSDM_FLTxISR. Note: SCDIE is present only in DFSDM_FLT0CR2 register (filter x=0)
    $06 constant DFSDM_CKABIE                   \ [0x06] Clock absence interrupt enable Please see the explanation of CKABF[3:0] in DFSDM_FLTxISR. Note: CKABIE is present only in DFSDM_FLT0CR2 register (filter x=0)
    $08 constant DFSDM_EXCH                     \ [0x08 : 4] Extremes detector channel selection These bits select the input channels to be taken by the Extremes detector. EXCH[y] = 0: Extremes detector does not accept data from channel y EXCH[y] = 1: Extremes detector accepts data from channel y
    $10 constant DFSDM_AWDCH                    \ [0x10 : 4] Analog watchdog channel selection These bits select the input channel to be guarded continuously by the analog watchdog. AWDCH[y] = 0: Analog watchdog is disabled on channel y AWDCH[y] = 1: Analog watchdog is enabled on channel y
  [then]


  [ifdef] DFSDM_DFSDM_FLT1ISR_DEF
    \
    \ @brief End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
    \ Address offset: 0x188
    \ Reset value: 0x00FF0000
    \
    $00 constant DFSDM_JEOCF                    \ [0x00] End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
    $01 constant DFSDM_REOCF                    \ [0x01] End of regular conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxRDATAR.
    $02 constant DFSDM_JOVRF                    \ [0x02] Injected conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRJOVRF bit in the DFSDM_FLTxICR register.
    $03 constant DFSDM_ROVRF                    \ [0x03] Regular conversion overrun flag This bit is set by hardware. It can be cleared by software using the CLRROVRF bit in the DFSDM_FLTxICR register.
    $04 constant DFSDM_AWDF                     \ [0x04] Analog watchdog This bit is set by hardware. It is cleared by software by clearing all source flag bits AWHTF[3:0] and AWLTF[3:0] in DFSDM_FLTxAWSR register (by writing '1â into the clear bits in DFSDM_FLTxAWCFR register).
    $0d constant DFSDM_JCIP                     \ [0x0d] Injected conversion in progress status A request to start an injected conversion is ignored when JCIP=1.
    $0e constant DFSDM_RCIP                     \ [0x0e] Regular conversion in progress status A request to start a regular conversion is ignored when RCIP=1.
    $10 constant DFSDM_CKABF                    \ [0x10 : 4] Clock absence flag CKABF[y]=0: Clock signal on channel y is present. CKABF[y]=1: Clock signal on channel y is not present. Given y bit is set by hardware when clock absence is detected on channel y. It is held at CKABF[y]=1 state by hardware when CHEN=0 (see DFSDM_CHyCFGR1 register). It is held at CKABF[y]=1 state by hardware when the transceiver is not yet synchronized.It can be cleared by software using the corresponding CLRCKABF[y] bit in the DFSDM_FLTxICR register. Note: CKABF[3:0] is present only in DFSDM_FLT0ISR register (filter x=0)
    $18 constant DFSDM_SCDF                     \ [0x18 : 4] short-circuit detector flag SDCF[y]=0: No short-circuit detector event occurred on channel y SDCF[y]=1: The short-circuit detector counter reaches, on channel y, the value programmed in the DFSDM_CHyAWSCDR registers This bit is set by hardware. It can be cleared by software using the corresponding CLRSCDF[y] bit in the DFSDM_FLTxICR register. SCDF[y] is cleared also by hardware when CHEN[y] = 0 (given channel is disabled). Note: SCDF[3:0] is present only in DFSDM_FLT0ISR register (filter x=0)
  [then]


  [ifdef] DFSDM_DFSDM_FLT1ICR_DEF
    \
    \ @brief Clear the injected conversion overrun flag
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $02 constant DFSDM_CLRJOVRF                 \ [0x02] Clear the injected conversion overrun flag
    $03 constant DFSDM_CLRROVRF                 \ [0x03] Clear the regular conversion overrun flag
    $10 constant DFSDM_CLRCKABF                 \ [0x10 : 4] Clear the clock absence flag CLRCKABF[y]=0: Writing '0â has no effect CLRCKABF[y]=1: Writing '1â to position y clears the corresponding CKABF[y] bit in the DFSDM_FLTxISR register. When the transceiver is not yet synchronized, the clock absence flag is set and cannot be cleared by CLRCKABF[y]. Note: CLRCKABF[3:0] is present only in DFSDM_FLT0ICR register (filter x=0)
    $18 constant DFSDM_CLRSCDF                  \ [0x18 : 4] Clear the short-circuit detector flag CLRSCDF[y]=0: Writing '0â has no effect CLRSCDF[y]=1: Writing '1â to position y clears the corresponding SCDF[y] bit in the DFSDM_FLTxISR register Note: CLRSCDF[3:0] is present only in DFSDM_FLT0ICR register (filter x=0)
  [then]


  [ifdef] DFSDM_DFSDM_FLT1JCHGR_DEF
    \
    \ @brief Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
    \ Address offset: 0x190
    \ Reset value: 0x00000001
    \
    $00 constant DFSDM_JCHG                     \ [0x00 : 4] Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
  [then]


  [ifdef] DFSDM_DFSDM_FLT1FCR_DEF
    \
    \ @brief Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_IOSR                     \ [0x00 : 8] Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
    $10 constant DFSDM_FOSR                     \ [0x10 : 10] Sinc filter oversampling ratio (decimation rate) number is also the decimation ratio of the output data rate from filter. This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If FOSR = 0, then the filter has no effect (filter bypass). 0 - 1023: Defines the length of the Sinc type filter in the range 1 - 1024 (FOSR = FOSR[9:0] +1). This
    $1d constant DFSDM_FORD                     \ [0x1d : 3] Sinc filter order 2: Sinc2 filter type 3: Sinc3 filter type 4: Sinc4 filter type 5: Sinc5 filter type 6-7: Reserved Sincx filter type transfer function: FastSinc filter type transfer function: This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1).
  [then]


  [ifdef] DFSDM_DFSDM_FLT1JDATAR_DEF
    \
    \ @brief Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[1:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[1:0].
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_JDATACH                  \ [0x00 : 2] Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[1:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[1:0].
    $08 constant DFSDM_JDATA                    \ [0x08 : 24] Injected group conversion data When each conversion of a channel in the injected group finishes, its resulting data is stored in this field. The data is valid when JEOCF=1. Reading this register clears the corresponding JEOCF.
  [then]


  [ifdef] DFSDM_DFSDM_FLT1RDATAR_DEF
    \
    \ @brief Regular channel most recently converted When each regular conversion finishes, RDATACH[1:0] is updated to indicate which channel was converted (because regular channel selection RCH[1:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[1:0].
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_RDATACH                  \ [0x00 : 2] Regular channel most recently converted When each regular conversion finishes, RDATACH[1:0] is updated to indicate which channel was converted (because regular channel selection RCH[1:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[1:0].
    $04 constant DFSDM_RPEND                    \ [0x04] Regular channel pending data Regular data in RDATA[23:0] was delayed due to an injected channel trigger during the conversion
    $08 constant DFSDM_RDATA                    \ [0x08 : 24] Regular channel conversion data When each regular conversion finishes, its data is stored in this register. The data is valid when REOCF=1. Reading this register clears the corresponding REOCF.
  [then]


  [ifdef] DFSDM_DFSDM_FLT1AWHTR_DEF
    \
    \ @brief Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_BKAWH                    \ [0x00 : 4] Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
    $08 constant DFSDM_AWHT                     \ [0x08 : 24] Analog watchdog high threshold These bits are written by software to define the high threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), the higher 16 bits (AWHT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWHT[7:0] are not taken into comparison in this case.
  [then]


  [ifdef] DFSDM_DFSDM_FLT1AWLTR_DEF
    \
    \ @brief Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_BKAWL                    \ [0x00 : 4] Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
    $08 constant DFSDM_AWLT                     \ [0x08 : 24] Analog watchdog low threshold These bits are written by software to define the low threshold for the analog watchdog. Note: In case channel transceivers monitor (AWFSEL=1), only the higher 16 bits (AWLT[23:8]) define the 16-bit threshold as compared with the analog watchdog filter output (because data coming from the analog watchdog filter are up to a 16-bit resolution). Bits AWLT[7:0] are not taken into comparison in this case.
  [then]


  [ifdef] DFSDM_DFSDM_FLT1AWSR_DEF
    \
    \ @brief Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_AWLTF                    \ [0x00 : 4] Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
    $08 constant DFSDM_AWHTF                    \ [0x08 : 4] Analog watchdog high threshold flag AWHTF[y]=1 indicates a high threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWHTF[y] bit in the DFSDM_FLTxAWCFR register.
  [then]


  [ifdef] DFSDM_DFSDM_FLT1AWCFR_DEF
    \
    \ @brief Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_CLRAWLTF                 \ [0x00 : 4] Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
    $08 constant DFSDM_CLRAWHTF                 \ [0x08 : 4] Clear the analog watchdog high threshold flag CLRAWHTF[y]=0: Writing '0â has no effect CLRAWHTF[y]=1: Writing '1â to position y clears the corresponding AWHTF[y] bit in the DFSDM_FLTxAWSR register
  [then]


  [ifdef] DFSDM_DFSDM_FLT1EXMAX_DEF
    \
    \ @brief Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
    \ Address offset: 0x1B0
    \ Reset value: 0x80000000
    \
    $00 constant DFSDM_EXMAXCH                  \ [0x00 : 2] Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
    $08 constant DFSDM_EXMAX                    \ [0x08 : 24] Extremes detector maximum value These bits are set by hardware and indicate the highest value converted by DFSDM_FLTx. EXMAX[23:0] bits are reset to value (0x800000) by reading of this register.
  [then]


  [ifdef] DFSDM_DFSDM_FLT1EXMIN_DEF
    \
    \ @brief Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
    \ Address offset: 0x1B4
    \ Reset value: 0x7FFFFF00
    \
    $00 constant DFSDM_EXMINCH                  \ [0x00 : 2] Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
    $08 constant DFSDM_EXMIN                    \ [0x08 : 24] Extremes detector minimum value These bits are set by hardware and indicate the lowest value converted by DFSDM_FLTx. EXMIN[23:0] bits are reset to value (0x7FFFFF) by reading of this register.
  [then]


  [ifdef] DFSDM_DFSDM_FLT1CNVTIMR_DEF
    \
    \ @brief 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
    \ Address offset: 0x1B8
    \ Reset value: 0x00000000
    \
    $04 constant DFSDM_CNVCNT                   \ [0x04 : 28] 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
  [then]


  [ifdef] DFSDM_DFSDM_HWCFGR_DEF
    \
    \ @brief DFSDM hardware configuration register
    \ Address offset: 0x7F0
    \ Reset value: 0x00000204
    \
    $00 constant DFSDM_NBT                      \ [0x00 : 8] Number of implemented transceivers Defines how many transceivers (input channels) are implemented in DFSDM peripheral.
    $08 constant DFSDM_NBF                      \ [0x08 : 8] Number of implemented filters Defines how many filters are implemented in DFSDM peripheral.
  [then]


  [ifdef] DFSDM_DFSDM_VERR_DEF
    \
    \ @brief DFSDM version register
    \ Address offset: 0x7F4
    \ Reset value: 0x00000021
    \
    $00 constant DFSDM_MINREV                   \ [0x00 : 4] Minor revision of the DFSDM peripheral These bits return the DFSDM minor revision (in range 0..15).
    $04 constant DFSDM_MAJREV                   \ [0x04 : 4] Major revision of the DFSDM peripheral These bits return the DFSDM major revision (in range 0..15).
  [then]


  [ifdef] DFSDM_DFSDM_IPIDR_DEF
    \
    \ @brief DFSDM identification register
    \ Address offset: 0x7F8
    \ Reset value: 0x00110031
    \
    $00 constant DFSDM_ID                       \ [0x00 : 32] Peripheral identifier Bits [31:0]: these bits returns the DFSDM identifier ID[31:0] = 0x0011 0031
  [then]


  [ifdef] DFSDM_DFSDM_SIDR_DEF
    \
    \ @brief DFSDM size identification register
    \ Address offset: 0x7FC
    \ Reset value: 0xA3C5DD02
    \
    $00 constant DFSDM_SID                      \ [0x00 : 32] Size identification of DFSDM peripheral Bits [31:8]: fixed code = 0xA3C5DD Bits [7:0]: these bits returns the size of the memory region allocated to DFSDM registers.
  [then]

  \
  \ @brief DFSDM
  \
  $00 constant DFSDM_DFSDM_CH0CFGR1     \ DFSDM channel 0 configuration register
  $04 constant DFSDM_DFSDM_CH0CFGR2     \ DFSDM channel 0 configuration register
  $08 constant DFSDM_DFSDM_CH0AWSCDR    \ DFSDM channel 0 analog watchdog and short-circuit detector register
  $0C constant DFSDM_DFSDM_CH0WDATR     \ DFSDM channel 0 watchdog filter data register
  $10 constant DFSDM_DFSDM_CH0DATINR    \ DFSDM channel 0 data input register
  $14 constant DFSDM_DFSDM_CH0DLYR      \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
  $20 constant DFSDM_DFSDM_CH1CFGR1     \ DFSDM channel 1 configuration register
  $24 constant DFSDM_DFSDM_CH1CFGR2     \ DFSDM channel 1 configuration register
  $28 constant DFSDM_DFSDM_CH1AWSCDR    \ DFSDM channel 1 analog watchdog and short-circuit detector register
  $2C constant DFSDM_DFSDM_CH1WDATR     \ DFSDM channel 1 watchdog filter data register
  $30 constant DFSDM_DFSDM_CH1DATINR    \ DFSDM channel 1 data input register
  $34 constant DFSDM_DFSDM_CH1DLYR      \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
  $40 constant DFSDM_DFSDM_CH2CFGR1     \ DFSDM channel 2 configuration register
  $44 constant DFSDM_DFSDM_CH2CFGR2     \ DFSDM channel 2 configuration register
  $48 constant DFSDM_DFSDM_CH2AWSCDR    \ DFSDM channel 2 analog watchdog and short-circuit detector register
  $4C constant DFSDM_DFSDM_CH2WDATR     \ DFSDM channel 2 watchdog filter data register
  $50 constant DFSDM_DFSDM_CH2DATINR    \ DFSDM channel 2 data input register
  $54 constant DFSDM_DFSDM_CH2DLYR      \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
  $60 constant DFSDM_DFSDM_CH3CFGR1     \ DFSDM channel 3 configuration register
  $64 constant DFSDM_DFSDM_CH3CFGR2     \ DFSDM channel 3 configuration register
  $68 constant DFSDM_DFSDM_CH3AWSCDR    \ DFSDM channel 3 analog watchdog and short-circuit detector register
  $6C constant DFSDM_DFSDM_CH3WDATR     \ DFSDM channel 3 watchdog filter data register
  $70 constant DFSDM_DFSDM_CH3DATINR    \ DFSDM channel 3 data input register
  $74 constant DFSDM_DFSDM_CH3DLYR      \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
  $94 constant DFSDM_DFSDM_CH4DLYR      \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
  $B4 constant DFSDM_DFSDM_CH5DLYR      \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
  $D4 constant DFSDM_DFSDM_CH6DLYR      \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
  $F4 constant DFSDM_DFSDM_CH7DLYR      \ Pulses to skip for input data skipping function immediately after writing to this field. Reading of PLSSKP[5:0] returns current value of pulses which will be skipped. If PLSSKP[5:0]=0 then all required data samples were already skipped. Note: User can update PLSSKP[5:0] also when PLSSKP[5:0] is not zero. 0-63: Defines the number of serial input samples that will be skipped. Skipping is applied
  $100 constant DFSDM_DFSDM_FLT0CR1     \ DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
  $104 constant DFSDM_DFSDM_FLT0CR2     \ Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
  $108 constant DFSDM_DFSDM_FLT0ISR     \ End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
  $10C constant DFSDM_DFSDM_FLT0ICR     \ Clear the injected conversion overrun flag
  $110 constant DFSDM_DFSDM_FLT0JCHGR   \ Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
  $114 constant DFSDM_DFSDM_FLT0FCR     \ Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
  $118 constant DFSDM_DFSDM_FLT0JDATAR  \ Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[1:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[1:0].
  $11C constant DFSDM_DFSDM_FLT0RDATAR  \ Regular channel most recently converted When each regular conversion finishes, RDATACH[1:0] is updated to indicate which channel was converted (because regular channel selection RCH[1:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[1:0].
  $120 constant DFSDM_DFSDM_FLT0AWHTR   \ Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
  $124 constant DFSDM_DFSDM_FLT0AWLTR   \ Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
  $128 constant DFSDM_DFSDM_FLT0AWSR    \ Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
  $12C constant DFSDM_DFSDM_FLT0AWCFR   \ Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
  $130 constant DFSDM_DFSDM_FLT0EXMAX   \ Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
  $134 constant DFSDM_DFSDM_FLT0EXMIN   \ Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
  $138 constant DFSDM_DFSDM_FLT0CNVTIMR \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
  $180 constant DFSDM_DFSDM_FLT1CR1     \ DFSDM_FLTx enable Data which are cleared by setting DFEN=0: register DFSDM_FLTxISR is set to the reset state register DFSDM_FLTxAWSR is set to the reset state
  $184 constant DFSDM_DFSDM_FLT1CR2     \ Injected end of conversion interrupt enable Please see the explanation of JEOCF in DFSDM_FLTxISR.
  $188 constant DFSDM_DFSDM_FLT1ISR     \ End of injected conversion flag This bit is set by hardware. It is cleared when the software or DMA reads DFSDM_FLTxJDATAR.
  $18C constant DFSDM_DFSDM_FLT1ICR     \ Clear the injected conversion overrun flag
  $190 constant DFSDM_DFSDM_FLT1JCHGR   \ Injected channel group selection JCHG[y]=0: channel y is not part of the injected group JCHG[y]=1: channel y is part of the injected group If JSCAN=1, each of the selected channels is converted, one after another. The lowest channel (channel 0, if selected) is converted first and the sequence ends at the highest selected channel. If JSCAN=0, then only one channel is converted from the selected channels, and the channel selection is moved to the next channel. Writing JCHG, if JSCAN=0, resets the channel selection to the lowest selected channel. At least one channel must always be selected for the injected group. Writes causing all JCHG bits to be zero are ignored.
  $194 constant DFSDM_DFSDM_FLT1FCR     \ Integrator oversampling ratio (averaging length) from Sinc filter will be summed into one output data sample from the integrator. The output data rate from the integrator will be decreased by this number (additional data decimation ratio). This bit can only be modified when DFEN=0 (DFSDM_FLTxCR1) Note: If IOSR = 0, then the Integrator has no effect (Integrator bypass). 0- 255: The length of the Integrator in the range 1 - 256 (IOSR + 1). Defines how many samples
  $198 constant DFSDM_DFSDM_FLT1JDATAR  \ Injected channel most recently converted When each conversion of a channel in the injected group finishes, JDATACH[1:0] is updated to indicate which channel was converted. Thus, JDATA[23:0] holds the data that corresponds to the channel indicated by JDATACH[1:0].
  $19C constant DFSDM_DFSDM_FLT1RDATAR  \ Regular channel most recently converted When each regular conversion finishes, RDATACH[1:0] is updated to indicate which channel was converted (because regular channel selection RCH[1:0] in DFSDM_FLTxCR1 register can be updated during regular conversion). Thus RDATA[23:0] holds the data that corresponds to the channel indicated by RDATACH[1:0].
  $1A0 constant DFSDM_DFSDM_FLT1AWHTR   \ Break signal assignment to analog watchdog high threshold event BKAWH[i] = 0: Break i signal is not assigned to an analog watchdog high threshold event BKAWH[i] = 1: Break i signal is assigned to an analog watchdog high threshold event
  $1A4 constant DFSDM_DFSDM_FLT1AWLTR   \ Break signal assignment to analog watchdog low threshold event BKAWL[i] = 0: Break i signal is not assigned to an analog watchdog low threshold event BKAWL[i] = 1: Break i signal is assigned to an analog watchdog low threshold event
  $1A8 constant DFSDM_DFSDM_FLT1AWSR    \ Analog watchdog low threshold flag AWLTF[y]=1 indicates a low threshold error on channel y. It is set by hardware. It can be cleared by software using the corresponding CLRAWLTF[y] bit in the DFSDM_FLTxAWCFR register.
  $1AC constant DFSDM_DFSDM_FLT1AWCFR   \ Clear the analog watchdog low threshold flag CLRAWLTF[y]=0: Writing '0â has no effect CLRAWLTF[y]=1: Writing '1â to position y clears the corresponding AWLTF[y] bit in the DFSDM_FLTxAWSR register
  $1B0 constant DFSDM_DFSDM_FLT1EXMAX   \ Extremes detector maximum data channel. These bits contains information about the channel on which the data is stored into EXMAX[23:0]. Bits are cleared by reading of this register.
  $1B4 constant DFSDM_DFSDM_FLT1EXMIN   \ Extremes detector minimum data channel These bits contain information about the channel on which the data is stored into EXMIN[23:0]. Bits are cleared by reading of this register.
  $1B8 constant DFSDM_DFSDM_FLT1CNVTIMR \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDMCLK The timer has an input clock from DFSDM clock (system clock fDFSDMCLK). Conversion time measurement is started on each conversion start and stopped when conversion finishes (interval between first and last serial sample). Only in case of filter bypass (FOSR[9:0] = 0) is the conversion time measurement stopped and CNVCNT[27:0] = 0. The counted time is: if FAST=0 (or first conversion in continuous mode if FAST=1): t = [FOSR * (IOSR-1 + FORD) + FORD] / fCKIN ..... for Sincx filters t = [FOSR * (IOSR-1 + 4) + 2] / fCKIN ..... for FastSinc filter if FAST=1 in continuous mode (except first conversion): t = [FOSR * IOSR] / fCKIN in case if FOSR = FOSR[9:0]+1 = 1 (filter bypassed, active only integrator): CNVCNT = 0 (counting is stopped, conversion time: t = IOSR / fCKIN) where: fCKIN is the channel input clock frequency (on given channel CKINy pin) or input data rate in case of parallel data input (from internal ADC or from CPU/DMA write) Note: When conversion is interrupted (e.g. by disable/enable selected channel) the timer counts also this interruption time.
  $7F0 constant DFSDM_DFSDM_HWCFGR      \ DFSDM hardware configuration register
  $7F4 constant DFSDM_DFSDM_VERR        \ DFSDM version register
  $7F8 constant DFSDM_DFSDM_IPIDR       \ DFSDM identification register
  $7FC constant DFSDM_DFSDM_SIDR        \ DFSDM size identification register

: DFSDM_DEF ; [then]
