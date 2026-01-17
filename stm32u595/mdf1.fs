\
\ @file mdf1.fs
\ @brief Multi-function digital filter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] MDF1_DEF

  [ifdef] MDF1_GCR_DEF
    \
    \ @brief MDF global control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_TRGO                      \ [0x00] TRGO
    $04 constant MDF1_ILVNB                     \ [0x04 : 4] ILVNB
  [then]


  [ifdef] MDF1_CKGCR_DEF
    \
    \ @brief MDF clock generator control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_CKGDEN                    \ [0x00] CKGDEN
    $01 constant MDF1_CCK0EN                    \ [0x01] CCK0EN
    $02 constant MDF1_CCK1EN                    \ [0x02] CCK1EN
    $04 constant MDF1_CKGMOD                    \ [0x04] CKGMOD
    $05 constant MDF1_CCK0DIR                   \ [0x05] CCK0DIR
    $06 constant MDF1_CCK1DIR                   \ [0x06] CCK1DIR
    $08 constant MDF1_TRGSENS                   \ [0x08] TRGSENS
    $0c constant MDF1_TRGSRC                    \ [0x0c : 4] TRGSRC
    $10 constant MDF1_CCKDIV                    \ [0x10 : 4] CCKDIV
    $18 constant MDF1_PROCDIV                   \ [0x18 : 7] PROCDIV
    $1f constant MDF1_CKGACTIVE                 \ [0x1f] CKGACTIVE
  [then]


  [ifdef] MDF1_MDF_SITF0CR_DEF
    \
    \ @brief This register is used to control the serial interfaces (SITFx).
    \ Address offset: 0x80
    \ Reset value: 0x00001F00
    \
    $00 constant MDF1_SITFEN                    \ [0x00] Serial interface enable Set and cleared by software. This bit is used to enable/disable the serial interface. - 0: Serial interface disabled - 1: Serial interface enabled
    $01 constant MDF1_SCKSRC                    \ [0x01 : 2] Serial clock source Set and cleared by software. This bit is used to select the clock source of the serial interface. - 00: Serial clock source is MDF_CCK0 - 01: Serial clock source is MDF_CCK1 1x: Serial clock source is MDF_CKIx, not allowed in LF_MASTER SPI mode This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_SITFMOD                   \ [0x04 : 2] Serial interface type Set and cleared by software. This field is used to defined the serial interface type. - 00: LF_MASTER (Low-Frequency MASTER) SPI mode - 01: Normal SPI mode - 10: Manchester mode: rising edge = logic 0, falling edge = logic 1 - 11: Manchester mode: rising edge = logic 1, falling edge = logic 0 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_STH                       \ [0x08 : 5] Manchester Symbol threshold / SPI threshold Set and cleared by software. This field is used for Manchester mode, in order to define the expected symbol threshold levels. Please refer to Section : Manchester mode for details on computation. In addition this field is used to define the timeout value for the clock absence detection in Normal SPI mode. Values of STH[4:0] lower than 4 are invalid. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_SITFACTIVE                \ [0x1f] Serial interface Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the serial interface is effectively enabled (active) or not. The protected fields of this function can only be updated when the SITFACTIVE is set , please refer to Section 1.4.15: Register protection for details. The delay between a transition on SITFEN and a transition on SITFACTIVE is 2 periods of AHB clock and 2 periods of mdf_proc_ck. - 0: The serial interface is not active, and can be configured if needed - 1: The serial interface is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_BSMX0CR_DEF
    \
    \ @brief This register is used to select the bitstream to be provided to the corresponding digital filter and to the SCD.
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_BSSEL                     \ [0x00 : 5] Bitstream Selection Set and cleared by software. This field is used to select the bitstream to be processed for the digital filter x and for the SCDx. The size of this field depends on the number of DFLTx instantiated. If the BSSEL is selecting an input which is not instantiated, the MDF will select the valid stream bs[x]_F having the higher index number. - 00000: The bitstream bs[0]_R is provided to DFLTx and SCDx - 00001: The bitstream bs[0]_F is provided to DFLTx and SCDx - 00010: The bitstream bs[1]_R is provided to DFLTx and SCDx (if instantiated) - 00011: The bitstream bs[1]_F is provided to DFLTx and SCDx (if instantiated) ... - 11110: The bitstream bs[15]_R is provided to DFLTx and SCDx (if instantiated) - 11111: The bitstream bs[15]_F is provided to DFLTx and SCDx (if instantiated) This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_BSMXACTIVE                \ [0x1f] BSMX Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the BSMX is effectively enabled (active) or not. BSSEL[4:0] can only be updated when the BSMXACTIVE is set . The BSMXACTIVE flag is a logical between OLDACTIVE, DFLTACTIVE, and SCDACTIVE flags. Both of them must be set in order update BSSEL[4:0] field. - 0: The BSMX is not active, and can be configured if needed - 1: The BSMX is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_DFLT0CR_DEF
    \
    \ @brief This register is used to control the digital filter x.
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DFLTEN                    \ [0x00] Digital Filter Enable Set and cleared by software. This bit is used to control the start of acquisition of the corresponding digital filter path. The behavior of this bit depends on ACQMOD and external events. or the acquisition starts when the proper trigger event occurs if ACQMOD = 01x . The serial or parallel interface delivering the samples shall be enabled as well. - 0: The acquisition is stopped immediately - 1: The acquisition is immediately started if ACQMOD = 00x or 1xx ,
    $01 constant MDF1_DMAEN                     \ [0x01] DMA Requests Enable Set and cleared by software. This bit is used to control the generation of DMA request in order to transfer the processed samples into the memory. - 0: The DMA interface for the corresponding digital filter is disabled - 1: The DMA interface for the corresponding digital filter is enabled This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $02 constant MDF1_FTH                       \ [0x02] RXFIFO Threshold selection Set and cleared by software.
    $04 constant MDF1_ACQMOD                    \ [0x04 : 3] Digital filter Trigger mode Set and cleared by software. This field is used to select the filter trigger mode. - 000: Asynchronous, continuous acquisition mode - 001: Asynchronous, single-shot acquisition mode - 010: Synchronous, continuous acquisition mode - 011: Synchronous, single-shot acquisition mode - 100: Window, continuous acquisition mode - 101: Synchronous, snapshot mode others: same a 000 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_TRGSENS                   \ [0x08] Digital filter Trigger sensitivity selection Set and cleared by software. This field is used to select the trigger sensitivity of the external signals - 0: A rising edge event triggers the acquisition - 1: A falling edge even triggers the acquisition Note that when the trigger source is TRGO or OLDx event, TRGSENS value is not taken into account. When TRGO is selected, the sensitivity is forced to falling edge, when OLDx event is selected, the sensitivity is forced to rising edge. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $0c constant MDF1_TRGSRC                    \ [0x0c : 4] Digital filter Trigger signal selection, Set and cleared by software. This field is used to select which external signals is used as trigger for the corresponding filter. - 0000: TRGO is selected - 0001: OLDx event is selected - 0010: mdf_trg[0] is selected ... - 1111: mdf_trg[13] is selected This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $10 constant MDF1_SNPSFMT                   \ [0x10] Snapshot data format Set and cleared by software. This field is used to select the data format for the snapshot mode. - 0: The integrator counter (INT_CNT) is not inserted into the MDF_SNPSxDR register, leaving a data resolution of 23 bits. - 1: The integrator counter (INT_CNT) is inserted at position [15:9] of MDF_SNPSxDR register, leaving a data resolution of 16 bits. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $14 constant MDF1_NBDIS                     \ [0x14 : 8] Number of samples to be discarded Set and cleared by software. This field is used to define the number of samples to be discarded every time the DFLTx is re-started. - 0: no sample discarded - 1: 1 sample discarded - 2: 2 samples discarded ... - 255: 255 samples discarded This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1e constant MDF1_DFLTRUN                   \ [0x1e] Digital filter Run Status Flag Set and cleared by hardware. This bit indicates if the digital filter is running or not. - 0: The digital filter is not running, and ready to accept a new trigger event - 1: The digital filter is running
    $1f constant MDF1_DFLTACTIVE                \ [0x1f] Digital filter Active Flag Set and cleared by hardware. This bit indicates if the digital filter is active: can be running or waiting for events. - 0: The digital filter is not active, and can be re-enabled again (via DFLTEN bit) if needed - 1: The digital filter is active
  [then]


  [ifdef] MDF1_MDF_DFLT0CICR_DEF
    \
    \ @brief This register is used to control the main CIC filter.
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DATSRC                    \ [0x00 : 2] Source data for the digital filter Set and cleared by software. 0x: Select the stream coming from the BSMX - 10: Select the stream coming from the ADCITF1 - 11: Select the stream coming from the ADCITF2 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_CICMOD                    \ [0x04 : 3] Select the CIC mode Set and cleared by software. This field allows the application to select the configuration and the order of the MCIC. When CICMOD[2:0] is equal to 0xx , the CIC is split into two filters: - The main CIC (MCIC) - The auxiliary CIC (ACIC), used for the out-off limit detector - 000: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in FastSinc filter - 001: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in Sinc1 filter - 010: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in Sinc2 filter - 011: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in Sinc3 filter - 100: The CIC is configured in single sinc4 filter others: The CIC is configured in single sinc5 filter This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_MCICD                     \ [0x08 : 9] CIC decimation ratio selection Set and cleared by software. This bit is used to allow the application to select the decimation ratio of the CIC. Decimation ratio smaller than 2 is not allowed. The decimation ratio is given by (CICDEC+1). - 0: Decimation ratio is 2 - 1: Decimation ratio is 2 - 2: Decimation ratio is 3 - 3: Decimation ratio is 4 ... - 511: Decimation ratio is 512 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $14 constant MDF1_SCALE                     \ [0x14 : 6] Scaling factor selection Set and cleared by software. This field is used to allow the application to select the gain to be applied at CIC output. Please refer to Table 13: Possible gain values for details. If the application attempts to write a new gain value while the previous one is not yet applied, this new gain value is ignored. Reading back the SCALE[5:0] field will inform the application on the current gain value. - 100000: - 48.2 dB, or shift right by 8 bits (default value) - 100001: - 44.6 dB, - 100010: - 42.1 dB, or shift right by 7 bits - 100011: - 38.6 dB, ... - 101110: -6 dB, or shift right by 1 bit - 101111: -2.5 dB, - 000000: 0 dB - 000001: + 3.5 dB, - 000010: + 6 dB, or shift left by 1 bit ... - 011000: + 72 dB, or shift left by 12 bits
  [then]


  [ifdef] MDF1_MDF_DFLT0RSFR_DEF
    \
    \ @brief This register is used to control the reshape and HPF filters.
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_RSFLTBYP                  \ [0x00] Reshaper filter bypass Set and cleared by software. This bit is used to bypass the reshape filter and its decimation block. - 0: The reshape filter is not bypassed (Default value) - 1: The reshape filter is bypassed This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_RSFLTD                    \ [0x04] Reshaper filter decimation ratio Set and cleared by software. This bit is used to select the decimation ratio for the reshape filter - 0: Decimation ratio is 4 (Default value) - 1: Decimation ratio is 1 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $07 constant MDF1_HPFBYP                    \ [0x07] High-Pass Filter bypass Set and cleared by software. This bit is used to bypass the high-pass filter. - 0: The high pass filter is not bypassed (Default value) - 1: The high pass filter is bypassed This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_HPFC                      \ [0x08 : 2] High-pass filter cut-off frequency Set and cleared by software. This field is used to select the cut-off frequency of the high-pass filter. FPCM represents the sampling frequency at HPF input. - 00: Cut-off frequency = 0.000625 x FPCM - 01: Cut-off frequency = 0.00125 x FPCM - 10: Cut-off frequency = 0.00250 x FPCM - 11: Cut-off frequency = 0.00950 x FPCM This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
  [then]


  [ifdef] MDF1_MDF_DFLT0INTR_DEF
    \
    \ @brief This register is used to the integrator (INT) settings.
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_INTDIV                    \ [0x00 : 2] Integrator output division Set and cleared by software. This bit is used to rescale the signal at the integrator output in order keep the data width lower than 24 bits. - 00: The integrator data outputs are divided by 128 (Default value) - 01: The integrator data outputs are divided by 32 - 10: The integrator data outputs are divided by 4 - 11: The integrator data outputs are not divided This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_INTVAL                    \ [0x04 : 7] Integration value selection Set and cleared by software. This field is used to select the integration value. - 0: The integration value is 1, meaning bypass mode (default after reset) - 1: The integration value is 2 - 2: The integration value is 3 ... - 127: The integration value is 128 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
  [then]


  [ifdef] MDF1_MDF_OLD0CR_DEF
    \
    \ @brief This register is used to configure the Out-of Limit Detector function.
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDEN                     \ [0x00] Over-Current Detector Enable Set and cleared by software. - 0: The OLD is disabled (Default value) - 1: The OLD is enabled, including the ACIC filter working in continuous mode.
    $01 constant MDF1_THINB                     \ [0x01] Threshold In band Set and cleared by software. - 0: The OLD generates an event if the signal is lower than OLDTHL OR higher than OLDTHH (Default value) - 1: The OLD generates an event if the signal is lower than OLDTHH AND higher than OLDTHL This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_BKOLD                     \ [0x04 : 4] Break signal assignment for out-of limit detector Set and cleared by software. BKOLD[i] = 0: Break signal (mdf_break[i]) is not assigned to threshold event BKOLD[i] = 1: Break signal (mdf_break[i]) is assigned to threshold event This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $0c constant MDF1_ACICN                     \ [0x0c : 2] OLD CIC order selection Set and cleared by software. This field allows the application to select the type, and the order of the ACIC. This field is only taken into account by the MDF when CICMOD[2:0] = 0xx . - 00: FastSinc filter type - 01: Sinc1 filter type - 10: Sinc2 filter type - 11: Sinc3 filter type This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $11 constant MDF1_ACICD                     \ [0x11 : 5] OLD CIC decimation ratio selection Set and cleared by software. This field is used to allow the application to select the decimation ratio of the ACIC. This field is only taken into account by the MDF when CICMOD[2:0] = 0xx . The decimation ratio is given by (ACICD+1). - 0: Decimation ratio is 1 - 1: Decimation ratio is 2 - 2: Decimation ratio is 3 - 3: Decimation ratio is 4 ... - 31: Decimation ratio is 32 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_OLDACTIVE                 \ [0x1f] OLD Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the OLD is effectively enabled (active) or not. The protected fields and registers of this function can only be updated when the OLDACTIVE is set to , please refer to Section 1.4.15: Register protection for details. The delay between a transition on OLDEN and a transition on OLDACTIVE is 2 periods of AHB clock and 2 periods of mdf_proc_ck. - 0: The OLD is not active, and can be configured if needed - 1: The OLD is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_OLD0THLR_DEF
    \
    \ @brief This register is used for the adjustment of the Out-off Limit low threshold.
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHL                    \ [0x00 : 26] OLD Low Threshold Value Set and cleared by software. OLDTHL represents a 26-bit signed value. The real threshold compared to the signal provided by the filter is OLDTHL. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
  [then]


  [ifdef] MDF1_MDF_OLD0THHR_DEF
    \
    \ @brief This register is used for the adjustment of the Out-off Limit high threshold.
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHH                    \ [0x00 : 26] OLD High Threshold Value Set and cleared by software. OLDTHH represents a 26-bit signed value. The real threshold compared to the signal provided by the filter is OLDTHH. This field can be write-protected, please refer to Section 1.4.15: Register protection for details
  [then]


  [ifdef] MDF1_MDF_DLY0CR_DEF
    \
    \ @brief This register is used for the adjustment stream delays.
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SKPDLY                    \ [0x00 : 7] Delay to apply to a bitstream Set and cleared by software. Defines the number of input samples that will be skipped. Skipping is applied immediately after writing to this field, if SKPBF = 0 , and the corresponding bit DFLTEN = 1 . If SKPBF = 1 the value written into the register is ignored by the delay state machine. - 0: No input sample skipped, - 1: 1 input sample skipped, ... - 127: 127 input sample skipped,
    $1f constant MDF1_SKPBF                     \ [0x1f] Skip Busy flag Set and cleared by hardware. Shall be used in order to control if the delay sequence is completed. - 0: Reading 0 means that the MDF is ready to accept a new value into SKPDLY[6:0]. - 1: Reading 1 means that last valid SKPDLY[6:0] is still under precessing.
  [then]


  [ifdef] MDF1_MDF_SCD0CR_DEF
    \
    \ @brief This register is used for the adjustment stream delays.
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SCDEN                     \ [0x00] Short circuit detector enable Set and cleared by software. - 0: The short circuit detector is disabled, - 1: The short circuit detector is enabled,
    $04 constant MDF1_BKSCD                     \ [0x04 : 4] Break signal assignment for short circuit detector Set and cleared by software. BKSCD[i] = 0: Break signal (mdf_break[i]) is not assigned to this SCD event BKSCD[i] = 1: Break signal (mdf_break[i]) is assigned to this SCD event This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $0c constant MDF1_SCDT                      \ [0x0c : 8] Short-circuit detector threshold Set and cleared by software. These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given input stream. - 0: 2 consecutive 1 s or 0 s will generate an event, - 1: 2 consecutive 1 s or 0 s will generate an event - 2: 3 consecutive 1 s or 0 s will generate an event, ... - 255: 256 consecutive 1 s or 0 s will generate an event, This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_SCDACTIVE                 \ [0x1f] SCD Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the SCD is effectively enabled (active) or not. The protected fields of this function can only be updated when the SCDACTIVE is set to a , please refer to Section 1.4.15: Register protection for details. The delay between a transition on SCDEN and a transition on SCDACTIVE is 2 periods of AHB clock and 2 periods of mdf_proc_ck. - 0: The SCD is not active, and can be configured if needed - 1: The SCD is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_DFLT0IER_DEF
    \
    \ @brief This register is used for allowing or not the events to generate an interrupt.
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHIE                     \ [0x00] RXFIFO threshold interrupt enable Set and cleared by software. - 0: RXFIFO threshold interrupt disabled - 1: RXFIFO threshold interrupt enabled
    $01 constant MDF1_DOVRIE                    \ [0x01] Data overflow interrupt enable Set and cleared by software. - 0: Data overflow interrupt disabled - 1: Data overflow interrupt enabled
    $02 constant MDF1_SSDRIE                    \ [0x02] Snapshot data ready interrupt enable Set and cleared by software. - 0: Snapshot data ready interrupt disabled - 1: Snapshot data ready interrupt enabled
    $04 constant MDF1_OLDIE                     \ [0x04] Out-of Limit interrupt enable Set and cleared by software. - 0: OLD event interrupt disabled - 1: OLD event interrupt enabled
    $07 constant MDF1_SSOVRIE                   \ [0x07] Snapshot overrun interrupt enable Set and cleared by software. - 0: Snapshot overrun interrupt disabled - 1: Snapshot overrun interrupt enabled
    $08 constant MDF1_SCDIE                     \ [0x08] Short-Circuit Detector interrupt enable Set and cleared by software. - 0: SCD interrupt disabled - 1: SCD interrupt enabled
    $09 constant MDF1_SATIE                     \ [0x09] Saturation detection interrupt enable Set and cleared by software. - 0: Saturation interrupt disabled - 1: Saturation interrupt enabled
    $0a constant MDF1_CKABIE                    \ [0x0a] Clock absence detection interrupt enable Set and cleared by software. - 0: Clock absence interrupt disabled - 1: Clock absence interrupt enabled
    $0b constant MDF1_RFOVRIE                   \ [0x0b] Reshape Filter Overrun interrupt enable Set and cleared by software. - 0: Reshape filter overrun interrupt disabled - 1: Reshape filter overrun interrupt enabled
  [then]


  [ifdef] MDF1_MDF_DFLT0ISR_DEF
    \
    \ @brief MDF DFLT0 interrupt status register 0
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHF                      \ [0x00] FTHF
    $01 constant MDF1_DOVRF                     \ [0x01] Data overflow flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no overflow is detected, writing 0 has no effect. - 1: Reading 1 means that an overflow is detected, writing 1 clears this flag.
    $02 constant MDF1_SSDRF                     \ [0x02] Snapshot data ready flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no data is available on , writing 0 has no effect. - 1: Reading 1 means that a new data is available on , writing 1 clears this flag.
    $03 constant MDF1_RXNEF                     \ [0x03] RXFIFO Not Empty flag Set and cleared by hardware according to the RXFIFO level. - 0: Reading 0 means that the RXFIFO is empty. - 1: Reading 1 means that the RXFIFO is not empty.
    $04 constant MDF1_OLDF                      \ [0x04] Out-of Limit Detector flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no OLD event is detected, writing 0 has no effect. - 1: Reading 1 means that an OLD event is detected, writing 1 clears THHF, THLF and OLDF flags.
    $05 constant MDF1_THLF                      \ [0x05] Low threshold status flag Set by hardware, and cleared by software by writing this bit to 1 . This flag indicates the status of the low threshold comparator when the last OLD event occurred. This bit gives additional information on the conditions triggering the last OLD event. It can be cleared by writing OLDF flag to a 1. - 0: The signal was higher than OLDTHL when the last OLD event occurred. - 1: The signal was lower than OLDTHL when the last OLD event occurred.
    $06 constant MDF1_THHF                      \ [0x06] High threshold status flag Set by hardware, and cleared by software by writing this bit to 1 . This flag indicates the status of the high threshold comparator when the last OLD event occurred. This bit gives additional information on the conditions triggering the last OLD event. It can be cleared by writing OLDF flag to a 1. - 0: The signal was lower than OLDTHH when the last OLD event occurred. - 1: The signal was higher than OLDTHH when the last OLD event occurred.
    $07 constant MDF1_SSOVRF                    \ [0x07] Snapshot overrun flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no snapshot overrun event is detected, writing 0 has no effect. - 1: Reading 1 means that a snapshot overrun event is detected, writing 1 clears this flag.
    $08 constant MDF1_SCDF                      \ [0x08] Short-Circuit Detector flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no SCD event is detected, writing 0 has no effect. - 1: Reading 1 means that a SCD event is detected, writing 1 clears this flag.
    $09 constant MDF1_SATF                      \ [0x09] Saturation detection flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no saturation is detected, writing 0 has no effect. - 1: Reading 1 means that a saturation is detected, writing 1 clears this flag.
    $0a constant MDF1_CKABF                     \ [0x0a] Clock absence detection flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no clock absence is detected, writing 0 has no effect. - 1: Reading 1 means that a clock absence is detected, writing 1 clears this flag.
    $0b constant MDF1_RFOVRF                    \ [0x0b] Reshape Filter Overrun detection flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no reshape filter overrun is detected, writing 0 has no effect. - 1: Reading 1 means that reshape filter overrun is detected, writing 1 clears this flag.
  [then]


  [ifdef] MDF1_MDF_OEC0CR_DEF
    \
    \ @brief This register contains the offset compensation value.
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OFFSET                    \ [0x00 : 26] Offset error compensation Set and cleared by software. If the application attempts to write a new offset value while the previous one is not yet applied, this new offset value is ignored. Reading back the OFFSET[25:0] field will inform the application on the current offset value. OFFSET[25:0] represents the value to be subtracted to the signal before going to the SCALE.
  [then]


  [ifdef] MDF1_MDF_SNPS0DR_DEF
    \
    \ @brief This register is used to read the data processed by each digital filter in snapshot mode.
    \ Address offset: 0xEC
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_MCICDC                    \ [0x00 : 9] Contains the MCIC decimation counter value at the moment of the last trigger event occurs (MCIC_CNT)
    $09 constant MDF1_EXTSDR                    \ [0x09 : 7] Extended data size If SNPSFMT = 0 , EXTSDR[6:0] contains the bit 7 to 1 of the last valid data processed by the digital filter, If SNPSFMT = 1 , this field contains the INT accumulator counter value at the moment of the last trigger event occurs (INT_CNT).
    $10 constant MDF1_SDR                       \ [0x10 : 16] Contains the 16 MSB of the last valid data processed by the digital filter.
  [then]


  [ifdef] MDF1_MDF_DFLT0DR_DEF
    \
    \ @brief This register is used to read the data processed by each digital filter.
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $08 constant MDF1_DR                        \ [0x08 : 24] Data processed by digital filter.
  [then]


  [ifdef] MDF1_MDF_SITF1CR_DEF
    \
    \ @brief This register is used to control the serial interfaces (SITFx).
    \ Address offset: 0x100
    \ Reset value: 0x00001F00
    \
    $00 constant MDF1_SITFEN                    \ [0x00] Serial interface enable Set and cleared by software. This bit is used to enable/disable the serial interface. - 0: Serial interface disabled - 1: Serial interface enabled
    $01 constant MDF1_SCKSRC                    \ [0x01 : 2] Serial clock source Set and cleared by software. This bit is used to select the clock source of the serial interface. - 00: Serial clock source is MDF_CCK0 - 01: Serial clock source is MDF_CCK1 1x: Serial clock source is MDF_CKIx, not allowed in LF_MASTER SPI mode This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_SITFMOD                   \ [0x04 : 2] Serial interface type Set and cleared by software. This field is used to defined the serial interface type. - 00: LF_MASTER (Low-Frequency MASTER) SPI mode - 01: Normal SPI mode - 10: Manchester mode: rising edge = logic 0, falling edge = logic 1 - 11: Manchester mode: rising edge = logic 1, falling edge = logic 0 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_STH                       \ [0x08 : 5] Manchester Symbol threshold / SPI threshold Set and cleared by software. This field is used for Manchester mode, in order to define the expected symbol threshold levels. Please refer to Section : Manchester mode for details on computation. In addition this field is used to define the timeout value for the clock absence detection in Normal SPI mode. Values of STH[4:0] lower than 4 are invalid. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_SITFACTIVE                \ [0x1f] Serial interface Active flag
  [then]


  [ifdef] MDF1_MDF_BSMX1CR_DEF
    \
    \ @brief This register is used to select the bitstream to be provided to the corresponding digital filter and to the SCD.
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_BSSEL                     \ [0x00 : 5] Bitstream Selection Set and cleared by software. This field is used to select the bitstream to be processed for the digital filter x and for the SCDx. The size of this field depends on the number of DFLTx instantiated. If the BSSEL is selecting an input which is not instantiated, the MDF will select the valid stream bs[x]_F having the higher index number. - 00000: The bitstream bs[0]_R is provided to DFLTx and SCDx - 00001: The bitstream bs[0]_F is provided to DFLTx and SCDx - 00010: The bitstream bs[1]_R is provided to DFLTx and SCDx (if instantiated) - 00011: The bitstream bs[1]_F is provided to DFLTx and SCDx (if instantiated) ... - 11110: The bitstream bs[15]_R is provided to DFLTx and SCDx (if instantiated) - 11111: The bitstream bs[15]_F is provided to DFLTx and SCDx (if instantiated) This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_BSMXACTIVE                \ [0x1f] BSMX Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the BSMX is effectively enabled (active) or not. BSSEL[4:0] can only be updated when the BSMXACTIVE is set . The BSMXACTIVE flag is a logical between OLDACTIVE, DFLTACTIVE, and SCDACTIVE flags. Both of them must be set in order update BSSEL[4:0] field. - 0: The BSMX is not active, and can be configured if needed - 1: The BSMX is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_DFLT1CR_DEF
    \
    \ @brief This register is used to control the digital filter x.
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DFLTEN                    \ [0x00] Digital Filter Enable Set and cleared by software. This bit is used to control the start of acquisition of the corresponding digital filter path. The behavior of this bit depends on ACQMOD and external events. or the acquisition starts when the proper trigger event occurs if ACQMOD = 01x . The serial or parallel interface delivering the samples shall be enabled as well. - 0: The acquisition is stopped immediately - 1: The acquisition is immediately started if ACQMOD = 00x or 1xx ,
    $01 constant MDF1_DMAEN                     \ [0x01] DMA Requests Enable Set and cleared by software. This bit is used to control the generation of DMA request in order to transfer the processed samples into the memory. - 0: The DMA interface for the corresponding digital filter is disabled - 1: The DMA interface for the corresponding digital filter is enabled This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $02 constant MDF1_FTH                       \ [0x02] RXFIFO Threshold selection Set and cleared by software. This bit is used to select the RXFIFO threshold. This bit is not significant for RXFIFOs working in interleaved transfer mode. Refer to Section 1.4.13.4: Using the interleaved transfer mode for details. - 0: RXFIFO threshold event generated when the RXFIFO is not empty - 1: RXFIFO threshold event generated when the RXFIFO is half-full This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_ACQMOD                    \ [0x04 : 3] Digital filter Trigger mode Set and cleared by software. This field is used to select the filter trigger mode. - 000: Asynchronous, continuous acquisition mode - 001: Asynchronous, single-shot acquisition mode - 010: Synchronous, continuous acquisition mode - 011: Synchronous, single-shot acquisition mode - 100: Window, continuous acquisition mode - 101: Synchronous, snapshot mode others: same a 000 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_TRGSENS                   \ [0x08] Digital filter Trigger sensitivity selection Set and cleared by software. This field is used to select the trigger sensitivity of the external signals - 0: A rising edge event triggers the acquisition - 1: A falling edge even triggers the acquisition Note that when the trigger source is TRGO or OLDx event, TRGSENS value is not taken into account. When TRGO is selected, the sensitivity is forced to falling edge, when OLDx event is selected, the sensitivity is forced to rising edge. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $0c constant MDF1_TRGSRC                    \ [0x0c : 4] Digital filter Trigger signal selection, Set and cleared by software. This field is used to select which external signals is used as trigger for the corresponding filter. - 0000: TRGO is selected - 0001: OLDx event is selected - 0010: mdf_trg[0] is selected ... - 1111: mdf_trg[13] is selected This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $10 constant MDF1_SNPSFMT                   \ [0x10] Snapshot data format Set and cleared by software. This field is used to select the data format for the snapshot mode. - 0: The integrator counter (INT_CNT) is not inserted into the MDF_SNPSxDR register, leaving a data resolution of 23 bits. - 1: The integrator counter (INT_CNT) is inserted at position [15:9] of MDF_SNPSxDR register, leaving a data resolution of 16 bits. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $14 constant MDF1_NBDIS                     \ [0x14 : 8] Number of samples to be discarded Set and cleared by software. This field is used to define the number of samples to be discarded every time the DFLTx is re-started. - 0: no sample discarded - 1: 1 sample discarded - 2: 2 samples discarded ... - 255: 255 samples discarded This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1e constant MDF1_DFLTRUN                   \ [0x1e] Digital filter Run Status Flag Set and cleared by hardware. This bit indicates if the digital filter is running or not. - 0: The digital filter is not running, and ready to accept a new trigger event - 1: The digital filter is running
    $1f constant MDF1_DFLTACTIVE                \ [0x1f] Digital filter Active Flag Set and cleared by hardware. This bit indicates if the digital filter is active: can be running or waiting for events. - 0: The digital filter is not active, and can be re-enabled again (via DFLTEN bit) if needed - 1: The digital filter is active
  [then]


  [ifdef] MDF1_MDF_DFLT1CICR_DEF
    \
    \ @brief This register is used to control the main CIC filter.
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DATSRC                    \ [0x00 : 2] Source data for the digital filter Set and cleared by software. 0x: Select the stream coming from the BSMX - 10: Select the stream coming from the ADCITF1 - 11: Select the stream coming from the ADCITF2 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_CICMOD                    \ [0x04 : 3] Select the CIC mode Set and cleared by software. This field allows the application to select the configuration and the order of the MCIC. When CICMOD[2:0] is equal to 0xx , the CIC is split into two filters: - The main CIC (MCIC) - The auxiliary CIC (ACIC), used for the out-off limit detector - 000: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in FastSinc filter - 001: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in Sinc1 filter - 010: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in Sinc2 filter - 011: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in Sinc3 filter - 100: The CIC is configured in single sinc4 filter others: The CIC is configured in single sinc5 filter This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_MCICD                     \ [0x08 : 9] CIC decimation ratio selection Set and cleared by software. This bit is used to allow the application to select the decimation ratio of the CIC. Decimation ratio smaller than 2 is not allowed. The decimation ratio is given by (CICDEC+1). - 0: Decimation ratio is 2 - 1: Decimation ratio is 2 - 2: Decimation ratio is 3 - 3: Decimation ratio is 4 ... - 511: Decimation ratio is 512 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $14 constant MDF1_SCALE                     \ [0x14 : 6] Scaling factor selection Set and cleared by software. This field is used to allow the application to select the gain to be applied at CIC output. Please refer to Table 13: Possible gain values for details. If the application attempts to write a new gain value while the previous one is not yet applied, this new gain value is ignored. Reading back the SCALE[5:0] field will inform the application on the current gain value. - 100000: - 48.2 dB, or shift right by 8 bits (default value) - 100001: - 44.6 dB, - 100010: - 42.1 dB, or shift right by 7 bits - 100011: - 38.6 dB, ... - 101110: -6 dB, or shift right by 1 bit - 101111: -2.5 dB, - 000000: 0 dB - 000001: + 3.5 dB, - 000010: + 6 dB, or shift left by 1 bit ... - 011000: + 72 dB, or shift left by 12 bits
  [then]


  [ifdef] MDF1_MDF_DFLT1RSFR_DEF
    \
    \ @brief This register is used to control the reshape and HPF filters.
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_RSFLTBYP                  \ [0x00] Reshaper filter bypass Set and cleared by software. This bit is used to bypass the reshape filter and its decimation block. - 0: The reshape filter is not bypassed (Default value) - 1: The reshape filter is bypassed This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_RSFLTD                    \ [0x04] Reshaper filter decimation ratio Set and cleared by software. This bit is used to select the decimation ratio for the reshape filter - 0: Decimation ratio is 4 (Default value) - 1: Decimation ratio is 1 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $07 constant MDF1_HPFBYP                    \ [0x07] High-Pass Filter bypass Set and cleared by software. This bit is used to bypass the high-pass filter. - 0: The high pass filter is not bypassed (Default value) - 1: The high pass filter is bypassed This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_HPFC                      \ [0x08 : 2] High-pass filter cut-off frequency Set and cleared by software. This field is used to select the cut-off frequency of the high-pass filter. FPCM represents the sampling frequency at HPF input. - 00: Cut-off frequency = 0.000625 x FPCM - 01: Cut-off frequency = 0.00125 x FPCM - 10: Cut-off frequency = 0.00250 x FPCM - 11: Cut-off frequency = 0.00950 x FPCM This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
  [then]


  [ifdef] MDF1_MDF_DFLT1INTR_DEF
    \
    \ @brief This register is used to the integrator (INT) settings.
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_INTDIV                    \ [0x00 : 2] Integrator output division Set and cleared by software. This bit is used to rescale the signal at the integrator output in order keep the data width lower than 24 bits. - 00: The integrator data outputs are divided by 128 (Default value) - 01: The integrator data outputs are divided by 32 - 10: The integrator data outputs are divided by 4 - 11: The integrator data outputs are not divided This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_INTVAL                    \ [0x04 : 7] Integration value selection Set and cleared by software. This field is used to select the integration value. - 0: The integration value is 1, meaning bypass mode (default after reset) - 1: The integration value is 2 - 2: The integration value is 3 ... - 127: The integration value is 128 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
  [then]


  [ifdef] MDF1_MDF_OLD1CR_DEF
    \
    \ @brief This register is used to configure the Out-of Limit Detector function.
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDEN                     \ [0x00] Over-Current Detector Enable Set and cleared by software. - 0: The OLD is disabled (Default value) - 1: The OLD is enabled, including the ACIC filter working in continuous mode.
    $01 constant MDF1_THINB                     \ [0x01] Threshold In band Set and cleared by software. - 0: The OLD generates an event if the signal is lower than OLDTHL OR higher than OLDTHH (Default value) - 1: The OLD generates an event if the signal is lower than OLDTHH AND higher than OLDTHL This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_BKOLD                     \ [0x04 : 4] Break signal assignment for out-of limit detector Set and cleared by software. BKOLD[i] = 0: Break signal (mdf_break[i]) is not assigned to threshold event BKOLD[i] = 1: Break signal (mdf_break[i]) is assigned to threshold event This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $0c constant MDF1_ACICN                     \ [0x0c : 2] OLD CIC order selection Set and cleared by software. This field allows the application to select the type, and the order of the ACIC. This field is only taken into account by the MDF when CICMOD[2:0] = 0xx . - 00: FastSinc filter type - 01: Sinc1 filter type - 10: Sinc2 filter type - 11: Sinc3 filter type This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $11 constant MDF1_ACICD                     \ [0x11 : 5] OLD CIC decimation ratio selection Set and cleared by software. This field is used to allow the application to select the decimation ratio of the ACIC. This field is only taken into account by the MDF when CICMOD[2:0] = 0xx . The decimation ratio is given by (ACICD+1). - 0: Decimation ratio is 1 - 1: Decimation ratio is 2 - 2: Decimation ratio is 3 - 3: Decimation ratio is 4 ... - 31: Decimation ratio is 32 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_OLDACTIVE                 \ [0x1f] OLD Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the OLD is effectively enabled (active) or not. The protected fields and registers of this function can only be updated when the OLDACTIVE is set to , please refer to Section 1.4.15: Register protection for details. The delay between a transition on OLDEN and a transition on OLDACTIVE is 2 periods of AHB clock and 2 periods of mdf_proc_ck. - 0: The OLD is not active, and can be configured if needed - 1: The OLD is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_OLD1THLR_DEF
    \
    \ @brief This register is used for the adjustment of the Out-off Limit low threshold.
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHL                    \ [0x00 : 26] OLD Low Threshold Value Set and cleared by software. OLDTHL represents a 26-bit signed value. The real threshold compared to the signal provided by the filter is OLDTHL. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
  [then]


  [ifdef] MDF1_MDF_OLD1THHR_DEF
    \
    \ @brief This register is used for the adjustment of the Out-off Limit high threshold.
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHH                    \ [0x00 : 26] OLD High Threshold Value Set and cleared by software. OLDTHH represents a 26-bit signed value. The real threshold compared to the signal provided by the filter is OLDTHH. This field can be write-protected, please refer to Section 1.4.15: Register protection for details
  [then]


  [ifdef] MDF1_MDF_DLY1CR_DEF
    \
    \ @brief This register is used for the adjustment stream delays.
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SKPDLY                    \ [0x00 : 7] Delay to apply to a bitstream Set and cleared by software. Defines the number of input samples that will be skipped. Skipping is applied immediately after writing to this field, if SKPBF = 0 , and the corresponding bit DFLTEN = 1 . If SKPBF = 1 the value written into the register is ignored by the delay state machine. - 0: No input sample skipped, - 1: 1 input sample skipped, ... - 127: 127 input sample skipped,
    $1f constant MDF1_SKPBF                     \ [0x1f] Skip Busy flag Set and cleared by hardware. Shall be used in order to control if the delay sequence is completed. - 0: Reading 0 means that the MDF is ready to accept a new value into SKPDLY[6:0]. - 1: Reading 1 means that last valid SKPDLY[6:0] is still under precessing.
  [then]


  [ifdef] MDF1_MDF_SCD1CR_DEF
    \
    \ @brief This register is used for the adjustment stream delays.
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SCDEN                     \ [0x00] Short circuit detector enable Set and cleared by software. - 0: The short circuit detector is disabled, - 1: The short circuit detector is enabled,
    $04 constant MDF1_BKSCD                     \ [0x04 : 4] Break signal assignment for short circuit detector Set and cleared by software. BKSCD[i] = 0: Break signal (mdf_break[i]) is not assigned to this SCD event BKSCD[i] = 1: Break signal (mdf_break[i]) is assigned to this SCD event This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $0c constant MDF1_SCDT                      \ [0x0c : 8] Short-circuit detector threshold Set and cleared by software. These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given input stream. - 0: 2 consecutive 1 s or 0 s will generate an event, - 1: 2 consecutive 1 s or 0 s will generate an event - 2: 3 consecutive 1 s or 0 s will generate an event, ... - 255: 256 consecutive 1 s or 0 s will generate an event, This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_SCDACTIVE                 \ [0x1f] SCD Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the SCD is effectively enabled (active) or not. The protected fields of this function can only be updated when the SCDACTIVE is set to a , please refer to Section 1.4.15: Register protection for details. The delay between a transition on SCDEN and a transition on SCDACTIVE is 2 periods of AHB clock and 2 periods of mdf_proc_ck. - 0: The SCD is not active, and can be configured if needed - 1: The SCD is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_DFLT1IER_DEF
    \
    \ @brief MDF DFLTx interrupt enable register x
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHIE                     \ [0x00] RXFIFO threshold interrupt enable Set and cleared by software. - 0: RXFIFO threshold interrupt disabled - 1: RXFIFO threshold interrupt enabled
    $01 constant MDF1_DOVRIE                    \ [0x01] Data overflow interrupt enable Set and cleared by software. - 0: Data overflow interrupt disabled - 1: Data overflow interrupt enabled
    $02 constant MDF1_SSDRIE                    \ [0x02] Snapshot data ready interrupt enable Set and cleared by software. - 0: Snapshot data ready interrupt disabled - 1: Snapshot data ready interrupt enabled
    $04 constant MDF1_OLDIE                     \ [0x04] Out-of Limit interrupt enable Set and cleared by software. - 0: OLD event interrupt disabled - 1: OLD event interrupt enabled
    $07 constant MDF1_SSOVRIE                   \ [0x07] Snapshot overrun interrupt enable Set and cleared by software. - 0: Snapshot overrun interrupt disabled - 1: Snapshot overrun interrupt enabled
    $08 constant MDF1_SCDIE                     \ [0x08] Short-Circuit Detector interrupt enable Set and cleared by software. - 0: SCD interrupt disabled - 1: SCD interrupt enabled
    $09 constant MDF1_SATIE                     \ [0x09] Saturation detection interrupt enable Set and cleared by software. - 0: Saturation interrupt disabled - 1: Saturation interrupt enabled
    $0a constant MDF1_CKABIE                    \ [0x0a] Clock absence detection interrupt enable Set and cleared by software. - 0: Clock absence interrupt disabled - 1: Clock absence interrupt enabled
    $0b constant MDF1_RFOVRIE                   \ [0x0b] Reshape Filter Overrun interrupt enable Set and cleared by software. - 0: Reshape filter overrun interrupt disabled - 1: Reshape filter overrun interrupt enabled
  [then]


  [ifdef] MDF1_MDF_DFLT1ISR_DEF
    \
    \ @brief This register contains the status flags for each digital filter path.
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHF                      \ [0x00] RXFIFO threshold flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that the RXFIFO threshold is not reached, writing 0 has no effect. - 1: Reading 1 means that the RXFIFO reached the threshold, writing 1 clears this flag.
    $01 constant MDF1_DOVRF                     \ [0x01] Data overflow flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no overflow is detected, writing 0 has no effect. - 1: Reading 1 means that an overflow is detected, writing 1 clears this flag.
    $02 constant MDF1_SSDRF                     \ [0x02] Snapshot data ready flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no data is available on MDF_SNPSxDR, writing 0 has no effect. - 1: Reading 1 means that a new data is available on MDF_SNPSxDR, writing 1 clears this flag.
    $03 constant MDF1_RXNEF                     \ [0x03] RXFIFO Not Empty flag Set and cleared by hardware according to the RXFIFO level. - 0: Reading 0 means that the RXFIFO is empty. - 1: Reading 1 means that the RXFIFO is not empty.
    $04 constant MDF1_OLDF                      \ [0x04] Out-of Limit Detector flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no OLD event is detected, writing 0 has no effect. - 1: Reading 1 means that an OLD event is detected, writing 1 clears THHF, THLF and OLDF flags.
    $05 constant MDF1_THLF                      \ [0x05] Low threshold status flag Set by hardware, and cleared by software by writing OLDF bit to 1 . This flag indicates the status of the low threshold comparator when the last OLD event occurred. This bit gives additional information on the conditions triggering the last OLD event. It can be cleared by writing OLDF flag to a 1. - 0: The signal was lower than OLDTHL, when the last OLD event occurred - 1: The signal was higher than OLDTHL, when the last OLD event occurred
    $06 constant MDF1_THHF                      \ [0x06] High threshold status flag Set by hardware, and cleared by software by writing OLDF bit to 1 . This flag indicates the status of the high threshold comparator when the last OLD event occurred. This bit gives additional information on the conditions triggering the last OLD event. It can be cleared by writing OLDF flag to a 1. - 0: The signal was lower than OLDTHH, when the last OLD event occurred - 1: The signal was higher than OLDTHH, when the last OLD event occurred
    $07 constant MDF1_SSOVRF                    \ [0x07] Snapshot overrun flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no snapshot overrun event is detected, writing 0 has no effect. - 1: Reading 1 means that a snapshot overrun event is detected, writing 1 clears this flag.
    $08 constant MDF1_SCDF                      \ [0x08] Short-Circuit Detector flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no SCD event is detected, writing 0 has no effect. - 1: Reading 1 means that a SCD event is detected, writing 1 clears this flag.
    $09 constant MDF1_SATF                      \ [0x09] Saturation detection flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no saturation is detected, writing 0 has no effect. - 1: Reading 1 means that a saturation is detected, writing 1 clears this flag.
    $0a constant MDF1_CKABF                     \ [0x0a] Clock absence detection flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no clock absence is detected, writing 0 has no effect. - 1: Reading 1 means that a clock absence is detected, writing 1 clears this flag.
    $0b constant MDF1_RFOVRF                    \ [0x0b] Reshape Filter Overrun detection flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no reshape filter overrun is detected, writing 0 has no effect. - 1: Reading 1 means that reshape filter overrun is detected, writing 1 clears this flag.
  [then]


  [ifdef] MDF1_MDF_OEC1CR_DEF
    \
    \ @brief This register contains the offset compensation value.
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OFFSET                    \ [0x00 : 26] Offset error compensation Set and cleared by software. If the application attempts to write a new offset value while the previous one is not yet applied, this new offset value is ignored. Reading back the OFFSET[25:0] field will inform the application on the current offset value. OFFSET[25:0] represents the value to be subtracted to the signal before going to the SCALE.
  [then]


  [ifdef] MDF1_MDF_SNPS1DR_DEF
    \
    \ @brief This register is used to read the data processed by each digital filter in snapshot mode.
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_MCICDC                    \ [0x00 : 9] Contains the MCIC decimation counter value at the moment of the last trigger event occurs (MCIC_CNT)
    $09 constant MDF1_EXTSDR                    \ [0x09 : 7] Extended data size If SNPSFMT = 0 , EXTSDR[6:0] contains the bit 7 to 1 of the last valid data processed by the digital filter, If SNPSFMT = 1 , this field contains the INT accumulator counter value at the moment of the last trigger event occurs (INT_CNT).
    $10 constant MDF1_SDR                       \ [0x10 : 16] Contains the 16 MSB of the last valid data processed by the digital filter.
  [then]


  [ifdef] MDF1_MDF_DFLT1DR_DEF
    \
    \ @brief This register is used to read the data processed by each digital filter.
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $08 constant MDF1_DR                        \ [0x08 : 24] Data processed by digital filter.
  [then]


  [ifdef] MDF1_MDF_SITF2CR_DEF
    \
    \ @brief This register is used to control the serial interfaces (SITFx).
    \ Address offset: 0x180
    \ Reset value: 0x00001F00
    \
    $00 constant MDF1_SITFEN                    \ [0x00] Serial interface enable Set and cleared by software. This bit is used to enable/disable the serial interface. - 0: Serial interface disabled - 1: Serial interface enabled
    $01 constant MDF1_SCKSRC                    \ [0x01 : 2] Serial clock source Set and cleared by software. This bit is used to select the clock source of the serial interface. - 00: Serial clock source is MDF_CCK0 - 01: Serial clock source is MDF_CCK1 1x: Serial clock source is MDF_CKIx, not allowed in LF_MASTER SPI mode This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_SITFMOD                   \ [0x04 : 2] Serial interface type Set and cleared by software. This field is used to defined the serial interface type. - 00: LF_MASTER (Low-Frequency MASTER) SPI mode - 01: Normal SPI mode - 10: Manchester mode: rising edge = logic 0, falling edge = logic 1 - 11: Manchester mode: rising edge = logic 1, falling edge = logic 0 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_STH                       \ [0x08 : 5] Manchester Symbol threshold / SPI threshold Set and cleared by software. This field is used for Manchester mode, in order to define the expected symbol threshold levels. Please refer to Section : Manchester mode for details on computation. In addition this field is used to define the timeout value for the clock absence detection in Normal SPI mode. Values of STH[4:0] lower than 4 are invalid. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_SITFACTIVE                \ [0x1f] Serial interface Active flag
  [then]


  [ifdef] MDF1_MDF_BSMX2CR_DEF
    \
    \ @brief This register is used to select the bitstream to be provided to the corresponding digital filter and to the SCD.
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_BSSEL                     \ [0x00 : 5] Bitstream Selection Set and cleared by software. This field is used to select the bitstream to be processed for the digital filter x and for the SCDx. The size of this field depends on the number of DFLTx instantiated. If the BSSEL is selecting an input which is not instantiated, the MDF will select the valid stream bs[x]_F having the higher index number. - 00000: The bitstream bs[0]_R is provided to DFLTx and SCDx - 00001: The bitstream bs[0]_F is provided to DFLTx and SCDx - 00010: The bitstream bs[1]_R is provided to DFLTx and SCDx (if instantiated) - 00011: The bitstream bs[1]_F is provided to DFLTx and SCDx (if instantiated) ... - 11110: The bitstream bs[15]_R is provided to DFLTx and SCDx (if instantiated) - 11111: The bitstream bs[15]_F is provided to DFLTx and SCDx (if instantiated) This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_BSMXACTIVE                \ [0x1f] BSMX Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the BSMX is effectively enabled (active) or not. BSSEL[4:0] can only be updated when the BSMXACTIVE is set to a . The BSMXACTIVE flag is a logical between OLDACTIVE, DFLTACTIVE, and SCDACTIVE flags. Both of them must be set to in order update BSSEL[4:0] field. - 0: The BSMX is not active, and can be configured if needed - 1: The BSMX is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_DFLT2CR_DEF
    \
    \ @brief This register is used to control the digital filter 2.
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DFLTEN                    \ [0x00] Digital Filter Enable Set and cleared by software. This bit is used to control the start of acquisition of the corresponding digital filter path. The behavior of this bit depends on ACQMOD and external events. or the acquisition starts when the proper trigger event occurs if ACQMOD = 01x . The serial or parallel interface delivering the samples shall be enabled as well. - 0: The acquisition is stopped immediately - 1: The acquisition is immediately started if ACQMOD = 00x or 1xx ,
    $01 constant MDF1_DMAEN                     \ [0x01] DMA Requests Enable Set and cleared by software. This bit is used to control the generation of DMA request in order to transfer the processed samples into the memory. - 0: The DMA interface for the corresponding digital filter is disabled - 1: The DMA interface for the corresponding digital filter is enabled This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $02 constant MDF1_FTH                       \ [0x02] RXFIFO Threshold selection Set and cleared by software. This bit is used to select the RXFIFO threshold. This bit is not significant for RXFIFOs working in a interleaved transfer mode. Refer to Section 1.4.13.4: Using the interleaved transfer mode for details. - 0: RXFIFO threshold event generated when the RXFIFO is not empty - 1: RXFIFO threshold event generated when the RXFIFO is half-full This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_ACQMOD                    \ [0x04 : 3] Digital filter Trigger mode Set and cleared by software. This field is used to select the filter trigger mode. - 000: Asynchronous, continuous acquisition mode - 001: Asynchronous, single-shot acquisition mode - 010: Synchronous, continuous acquisition mode - 011: Synchronous, single-shot acquisition mode - 100: Window, continuous acquisition mode - 101: Synchronous, snapshot mode others: same a 000 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_TRGSENS                   \ [0x08] Digital filter Trigger sensitivity selection Set and cleared by software. This field is used to select the trigger sensitivity of the external signals - 0: A rising edge event triggers the acquisition - 1: A falling edge even triggers the acquisition Note that when the trigger source is TRGO or OLDx event, TRGSENS value is not taken into account. When TRGO is selected, the sensitivity is forced to falling edge, when OLDx event is selected, the sensitivity is forced to rising edge. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $0c constant MDF1_TRGSRC                    \ [0x0c : 4] Digital filter Trigger signal selection, Set and cleared by software. This field is used to select which external signals is used as trigger for the corresponding filter. - 0000: TRGO is selected - 0001: OLDx event is selected - 0010: mdf_trg[0] is selected ... - 1111: mdf_trg[13] is selected This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $10 constant MDF1_SNPSFMT                   \ [0x10] Snapshot data format Set and cleared by software. This field is used to select the data format for the snapshot mode. - 0: The integrator counter (INT_CNT) is not inserted into the MDF_SNPSxDR register, leaving a data resolution of 23 bits. - 1: The integrator counter (INT_CNT) is inserted at position [15:9] of MDF_SNPSxDR register, leaving a data resolution of 16 bits. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $14 constant MDF1_NBDIS                     \ [0x14 : 8] Number of samples to be discarded Set and cleared by software. This field is used to define the number of samples to be discarded every time the DFLTx is re-started. - 0: no sample discarded - 1: 1 sample discarded - 2: 2 samples discarded ... - 255: 255 samples discarded This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1e constant MDF1_DFLTRUN                   \ [0x1e] Digital filter Run Status Flag Set and cleared by hardware. This bit indicates if the digital filter is running or not. - 0: The digital filter is not running, and ready to accept a new trigger event - 1: The digital filter is running
    $1f constant MDF1_DFLTACTIVE                \ [0x1f] Digital filter Active Flag Set and cleared by hardware. This bit indicates if the digital filter is active: can be running or waiting for events. - 0: The digital filter is not active, and can be re-enabled again (via DFLTEN bit) if needed - 1: The digital filter is active
  [then]


  [ifdef] MDF1_MDF_DFLT2CICR_DEF
    \
    \ @brief This register is used to control the main CIC filter.
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DATSRC                    \ [0x00 : 2] Source data for the digital filter Set and cleared by software. 0x: Select the stream coming from the BSMX - 10: Select the stream coming from the ADCITF1 - 11: Select the stream coming from the ADCITF2 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_CICMOD                    \ [0x04 : 3] Select the CIC mode Set and cleared by software. This field allows the application to select the configuration and the order of the MCIC. When CICMOD[2:0] is equal to 0xx , the CIC is split into two filters: - The main CIC (MCIC) - The auxiliary CIC (ACIC), used for the out-off limit detector - 000: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in FastSinc filter - 001: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in Sinc1 filter - 010: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in Sinc2 filter - 011: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in Sinc3 filter - 100: The CIC is configured in single sinc4 filter others: The CIC is configured in single sinc5 filter This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_MCICD                     \ [0x08 : 9] CIC decimation ratio selection Set and cleared by software. This bit is used to allow the application to select the decimation ratio of the CIC. Decimation ratio smaller than 2 is not allowed. The decimation ratio is given by (CICDEC+1). - 0: Decimation ratio is 2 - 1: Decimation ratio is 2 - 2: Decimation ratio is 3 - 3: Decimation ratio is 4 ... - 511: Decimation ratio is 512 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $14 constant MDF1_SCALE                     \ [0x14 : 6] Scaling factor selection Set and cleared by software. This field is used to allow the application to select the gain to be applied at CIC output. Please refer to Table 13: Possible gain values for details. If the application attempts to write a new gain value while the previous one is not yet applied, this new gain value is ignored. Reading back the SCALE[5:0] field will inform the application on the current gain value. - 100000: - 48.2 dB, or shift right by 8 bits (default value) - 100001: - 44.6 dB, - 100010: - 42.1 dB, or shift right by 7 bits - 100011: - 38.6 dB, ... - 101110: -6 dB, or shift right by 1 bit - 101111: -2.5 dB, - 000000: 0 dB - 000001: + 3.5 dB, - 000010: + 6 dB, or shift left by 1 bit ... - 011000: + 72 dB, or shift left by 12 bits
  [then]


  [ifdef] MDF1_MDF_DFLT2RSFR_DEF
    \
    \ @brief This register is used to control the reshape and HPF filters.
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_RSFLTBYP                  \ [0x00] Reshaper filter bypass Set and cleared by software. This bit is used to bypass the reshape filter and its decimation block. - 0: The reshape filter is not bypassed (Default value) - 1: The reshape filter is bypassed This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_RSFLTD                    \ [0x04] Reshaper filter decimation ratio Set and cleared by software. This bit is used to select the decimation ratio for the reshape filter - 0: Decimation ratio is 4 (Default value) - 1: Decimation ratio is 1 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $07 constant MDF1_HPFBYP                    \ [0x07] High-Pass Filter bypass Set and cleared by software. This bit is used to bypass the high-pass filter. - 0: The high pass filter is not bypassed (Default value) - 1: The high pass filter is bypassed This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_HPFC                      \ [0x08 : 2] High-pass filter cut-off frequency Set and cleared by software. This field is used to select the cut-off frequency of the high-pass filter. FPCM represents the sampling frequency at HPF input. - 00: Cut-off frequency = 0.000625 x FPCM - 01: Cut-off frequency = 0.00125 x FPCM - 10: Cut-off frequency = 0.00250 x FPCM - 11: Cut-off frequency = 0.00950 x FPCM This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
  [then]


  [ifdef] MDF1_MDF_DFLT2INTR_DEF
    \
    \ @brief This register is used to the integrator (INT) settings.
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_INTDIV                    \ [0x00 : 2] Integrator output division Set and cleared by software. This bit is used to rescale the signal at the integrator output in order keep the data width lower than 24 bits. - 00: The integrator data outputs are divided by 128 (Default value) - 01: The integrator data outputs are divided by 32 - 10: The integrator data outputs are divided by 4 - 11: The integrator data outputs are not divided This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_INTVAL                    \ [0x04 : 7] Integration value selection Set and cleared by software. This field is used to select the integration value. - 0: The integration value is 1, meaning bypass mode (default after reset) - 1: The integration value is 2 - 2: The integration value is 3 ... - 127: The integration value is 128 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
  [then]


  [ifdef] MDF1_MDF_OLD2CR_DEF
    \
    \ @brief This register is used to configure the Out-of Limit Detector function.
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDEN                     \ [0x00] Over-Current Detector Enable Set and cleared by software. - 0: The OLD is disabled (Default value) - 1: The OLD is enabled, including the ACIC filter working in continuous mode.
    $01 constant MDF1_THINB                     \ [0x01] Threshold In band Set and cleared by software. - 0: The OLD generates an event if the signal is lower than OLDTHL OR higher than OLDTHH (Default value) - 1: The OLD generates an event if the signal is lower than OLDTHH AND higher than OLDTHL This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_BKOLD                     \ [0x04 : 4] Break signal assignment for out-of limit detector Set and cleared by software. BKOLD[i] = 0: Break signal (mdf_break[i]) is not assigned to threshold event BKOLD[i] = 1: Break signal (mdf_break[i]) is assigned to threshold event This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $0c constant MDF1_ACICN                     \ [0x0c : 2] OLD CIC order selection Set and cleared by software. This field allows the application to select the type, and the order of the ACIC. This field is only taken into account by the MDF when CICMOD[2:0] = 0xx . - 00: FastSinc filter type - 01: Sinc1 filter type - 10: Sinc2 filter type - 11: Sinc3 filter type This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $11 constant MDF1_ACICD                     \ [0x11 : 5] OLD CIC decimation ratio selection Set and cleared by software. This field is used to allow the application to select the decimation ratio of the ACIC. This field is only taken into account by the MDF when CICMOD[2:0] = 0xx . The decimation ratio is given by (ACICD+1). - 0: Decimation ratio is 1 - 1: Decimation ratio is 2 - 2: Decimation ratio is 3 - 3: Decimation ratio is 4 ... - 31: Decimation ratio is 32 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_OLDACTIVE                 \ [0x1f] OLD Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the OLD is effectively enabled (active) or not. The protected fields and registers of this function can only be updated when the OLDACTIVE is set to , please refer to Section 1.4.15: Register protection for details. The delay between a transition on OLDEN and a transition on OLDACTIVE is 2 periods of AHB clock and 2 periods of mdf_proc_ck. - 0: The OLD is not active, and can be configured if needed - 1: The OLD is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_OLD2THLR_DEF
    \
    \ @brief This register is used for the adjustment of the Out-off Limit low threshold.
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHL                    \ [0x00 : 26] OLD Low Threshold Value Set and cleared by software. OLDTHL represents a 26-bit signed value. The real threshold compared to the signal provided by the filter is OLDTHL. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
  [then]


  [ifdef] MDF1_MDF_OLD2THHR_DEF
    \
    \ @brief This register is used for the adjustment of the Out-off Limit high threshold.
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHH                    \ [0x00 : 26] OLD High Threshold Value Set and cleared by software. OLDTHH represents a 26-bit signed value. The real threshold compared to the signal provided by the filter is OLDTHH. This field can be write-protected, please refer to Section 1.4.15: Register protection for details
  [then]


  [ifdef] MDF1_MDF_DLY2CR_DEF
    \
    \ @brief This register is used for the adjustment stream delays.
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SKPDLY                    \ [0x00 : 7] Delay to apply to a bitstream Set and cleared by software. Defines the number of input samples that will be skipped. Skipping is applied immediately after writing to this field, if SKPBF = 0 , and the corresponding bit DFLTEN = 1 . If SKPBF = 1 the value written into the register is ignored by the delay state machine. - 0: No input sample skipped, - 1: 1 input sample skipped, ... - 127: 127 input sample skipped,
    $1f constant MDF1_SKPBF                     \ [0x1f] Skip Busy flag Set and cleared by hardware. Shall be used in order to control if the delay sequence is completed. - 0: Reading 0 means that the MDF is ready to accept a new value into SKPDLY[6:0]. - 1: Reading 1 means that last valid SKPDLY[6:0] is still under precessing.
  [then]


  [ifdef] MDF1_MDF_SCD2CR_DEF
    \
    \ @brief This register is used for the adjustment stream delays.
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SCDEN                     \ [0x00] Short circuit detector enable Set and cleared by software. - 0: The short circuit detector is disabled, - 1: The short circuit detector is enabled,
    $04 constant MDF1_BKSCD                     \ [0x04 : 4] Break signal assignment for short circuit detector Set and cleared by software. BKSCD[i] = 0: Break signal (mdf_break[i]) is not assigned to this SCD event BKSCD[i] = 1: Break signal (mdf_break[i]) is assigned to this SCD event This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $0c constant MDF1_SCDT                      \ [0x0c : 8] Short-circuit detector threshold Set and cleared by software. These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given input stream. - 0: 2 consecutive 1 s or 0 s will generate an event, - 1: 2 consecutive 1 s or 0 s will generate an event - 2: 3 consecutive 1 s or 0 s will generate an event, ... - 255: 256 consecutive 1 s or 0 s will generate an event, This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_SCDACTIVE                 \ [0x1f] SCD Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the SCD is effectively enabled (active) or not. The protected fields of this function can only be updated when the SCDACTIVE is set to a , please refer to Section 1.4.15: Register protection for details. The delay between a transition on SCDEN and a transition on SCDACTIVE is 2 periods of AHB clock and 2 periods of mdf_proc_ck. - 0: The SCD is not active, and can be configured if needed - 1: The SCD is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_DFLT2IER_DEF
    \
    \ @brief MDF DFLTx interrupt enable register x
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHIE                     \ [0x00] RXFIFO threshold interrupt enable Set and cleared by software. - 0: RXFIFO threshold interrupt disabled - 1: RXFIFO threshold interrupt enabled
    $01 constant MDF1_DOVRIE                    \ [0x01] Data overflow interrupt enable Set and cleared by software. - 0: Data overflow interrupt disabled - 1: Data overflow interrupt enabled
    $02 constant MDF1_SSDRIE                    \ [0x02] Snapshot data ready interrupt enable Set and cleared by software. - 0: Snapshot data ready interrupt disabled - 1: Snapshot data ready interrupt enabled
    $04 constant MDF1_OLDIE                     \ [0x04] Out-of Limit interrupt enable Set and cleared by software. - 0: OLD event interrupt disabled - 1: OLD event interrupt enabled
    $07 constant MDF1_SSOVRIE                   \ [0x07] Snapshot overrun interrupt enable Set and cleared by software. - 0: Snapshot overrun interrupt disabled - 1: Snapshot overrun interrupt enabled
    $08 constant MDF1_SCDIE                     \ [0x08] Short-Circuit Detector interrupt enable Set and cleared by software. - 0: SCD interrupt disabled - 1: SCD interrupt enabled
    $09 constant MDF1_SATIE                     \ [0x09] Saturation detection interrupt enable Set and cleared by software. - 0: Saturation interrupt disabled - 1: Saturation interrupt enabled
    $0a constant MDF1_CKABIE                    \ [0x0a] Clock absence detection interrupt enable Set and cleared by software. - 0: Clock absence interrupt disabled - 1: Clock absence interrupt enabled
    $0b constant MDF1_RFOVRIE                   \ [0x0b] Reshape Filter Overrun interrupt enable Set and cleared by software. - 0: Reshape filter overrun interrupt disabled - 1: Reshape filter overrun interrupt enabled
  [then]


  [ifdef] MDF1_MDF_DFLT2ISR_DEF
    \
    \ @brief This register contains the status flags for each digital filter path.
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHF                      \ [0x00] RXFIFO threshold flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that the RXFIFO threshold is not reached, writing 0 has no effect. - 1: Reading 1 means that the RXFIFO reached the threshold, writing 1 clears this flag.
    $01 constant MDF1_DOVRF                     \ [0x01] Data overflow flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no overflow is detected, writing 0 has no effect. - 1: Reading 1 means that an overflow is detected, writing 1 clears this flag.
    $02 constant MDF1_SSDRF                     \ [0x02] Snapshot data ready flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no data is available on MDF_SNPSxDR, writing 0 has no effect. - 1: Reading 1 means that a new data is available on MDF_SNPSxDR, writing 1 clears this flag.
    $03 constant MDF1_RXNEF                     \ [0x03] RXFIFO Not Empty flag Set and cleared by hardware according to the RXFIFO level. - 0: Reading 0 means that the RXFIFO is empty. - 1: Reading 1 means that the RXFIFO is not empty.
    $04 constant MDF1_OLDF                      \ [0x04] Out-of Limit Detector flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no OLD event is detected, writing 0 has no effect. - 1: Reading 1 means that an OLD event is detected, writing 1 clears THHF, THLF and OLDF flags.
    $05 constant MDF1_THLF                      \ [0x05] Low threshold status flag Set by hardware, and cleared by software by writing OLDF bit to 1 . This flag indicates the status of the low threshold comparator when the last OLD event occurred. This bit gives additional information on the conditions triggering the last OLD event. It can be cleared by writing OLDF flag to a 1. - 0: The signal was lower than OLDTHL, when the last OLD event occurred - 1: The signal was higher than OLDTHL, when the last OLD event occurred
    $06 constant MDF1_THHF                      \ [0x06] High threshold status flag Set by hardware, and cleared by software by writing OLDF bit to 1 . This flag indicates the status of the high threshold comparator when the last OLD event occurred. This bit gives additional information on the conditions triggering the last OLD event. It can be cleared by writing OLDF flag to a 1. - 0: The signal was lower than OLDTHH, when the last OLD event occurred - 1: The signal was higher than OLDTHH, when the last OLD event occurred
    $07 constant MDF1_SSOVRF                    \ [0x07] Snapshot overrun flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no snapshot overrun event is detected, writing 0 has no effect. - 1: Reading 1 means that a snapshot overrun event is detected, writing 1 clears this flag.
    $08 constant MDF1_SCDF                      \ [0x08] Short-Circuit Detector flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no SCD event is detected, writing 0 has no effect. - 1: Reading 1 means that a SCD event is detected, writing 1 clears this flag.
    $09 constant MDF1_SATF                      \ [0x09] Saturation detection flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no saturation is detected, writing 0 has no effect. - 1: Reading 1 means that a saturation is detected, writing 1 clears this flag.
    $0a constant MDF1_CKABF                     \ [0x0a] Clock absence detection flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no clock absence is detected, writing 0 has no effect. - 1: Reading 1 means that a clock absence is detected, writing 1 clears this flag.
    $0b constant MDF1_RFOVRF                    \ [0x0b] Reshape Filter Overrun detection flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no reshape filter overrun is detected, writing 0 has no effect. - 1: Reading 1 means that reshape filter overrun is detected, writing 1 clears this flag.
  [then]


  [ifdef] MDF1_MDF_OEC2CR_DEF
    \
    \ @brief This register contains the offset compensation value.
    \ Address offset: 0x1B4
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OFFSET                    \ [0x00 : 26] Offset error compensation Set and cleared by software. If the application attempts to write a new offset value while the previous one is not yet applied, this new offset value is ignored. Reading back the OFFSET[25:0] field will inform the application on the current offset value. OFFSET[25:0] represents the value to be subtracted to the signal before going to the SCALE.
  [then]


  [ifdef] MDF1_MDF_SNPS2DR_DEF
    \
    \ @brief This register is used to read the data processed by each digital filter in snapshot mode.
    \ Address offset: 0x1EC
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_MCICDC                    \ [0x00 : 9] Contains the MCIC decimation counter value at the moment of the last trigger event occurs (MCIC_CNT)
    $09 constant MDF1_EXTSDR                    \ [0x09 : 7] Extended data size If SNPSFMT = 0 , EXTSDR[6:0] contains the bit 7 to 1 of the last valid data processed by the digital filter, If SNPSFMT = 1 , this field contains the INT accumulator counter value at the moment of the last trigger event occurs (INT_CNT).
    $10 constant MDF1_SDR                       \ [0x10 : 16] Contains the 16 MSB of the last valid data processed by the digital filter.
  [then]


  [ifdef] MDF1_MDF_DFLT2DR_DEF
    \
    \ @brief This register is used to read the data processed by each digital filter.
    \ Address offset: 0x1F0
    \ Reset value: 0x00000000
    \
    $08 constant MDF1_DR                        \ [0x08 : 24] Data processed by digital filter.
  [then]


  [ifdef] MDF1_MDF_SITF3CR_DEF
    \
    \ @brief This register is used to control the serial interfaces (SITFx).
    \ Address offset: 0x200
    \ Reset value: 0x00001F00
    \
    $00 constant MDF1_SITFEN                    \ [0x00] Serial interface enable Set and cleared by software. This bit is used to enable/disable the serial interface. - 0: Serial interface disabled - 1: Serial interface enabled
    $01 constant MDF1_SCKSRC                    \ [0x01 : 2] Serial clock source Set and cleared by software. This bit is used to select the clock source of the serial interface. - 00: Serial clock source is MDF_CCK0 - 01: Serial clock source is MDF_CCK1 1x: Serial clock source is MDF_CKIx, not allowed in LF_MASTER SPI mode This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_SITFMOD                   \ [0x04 : 2] Serial interface type Set and cleared by software. This field is used to defined the serial interface type. - 00: LF_MASTER (Low-Frequency MASTER) SPI mode - 01: Normal SPI mode - 10: Manchester mode: rising edge = logic 0, falling edge = logic 1 - 11: Manchester mode: rising edge = logic 1, falling edge = logic 0 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_STH                       \ [0x08 : 5] Manchester Symbol threshold / SPI threshold Set and cleared by software. This field is used for Manchester mode, in order to define the expected symbol threshold levels. Please refer to Section : Manchester mode for details on computation. In addition this field is used to define the timeout value for the clock absence detection in Normal SPI mode. Values of STH[4:0] lower than 4 are invalid. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_SITFACTIVE                \ [0x1f] Serial interface Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the serial interface is effectively enabled (active) or not. The protected fields of this function can only be updated when the SITFACTIVE is set , please refer to Section 1.4.15: Register protection for details. The delay between a transition on SITFEN and a transition on SITFACTIVE is 2 periods of AHB clock and 2 periods of mdf_proc_ck. - 0: The serial interface is not active, and can be configured if needed - 1: The serial interface is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_BSMX3CR_DEF
    \
    \ @brief This register is used to select the bitstream to be provided to the corresponding digital filter and to the SCD.
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_BSSEL                     \ [0x00 : 5] Bitstream Selection Set and cleared by software. This field is used to select the bitstream to be processed for the digital filter x and for the SCDx. The size of this field depends on the number of DFLTx instantiated. If the BSSEL is selecting an input which is not instantiated, the MDF will select the valid stream bs[x]_F having the higher index number. - 00000: The bitstream bs[0]_R is provided to DFLTx and SCDx - 00001: The bitstream bs[0]_F is provided to DFLTx and SCDx - 00010: The bitstream bs[1]_R is provided to DFLTx and SCDx (if instantiated) - 00011: The bitstream bs[1]_F is provided to DFLTx and SCDx (if instantiated) ... - 11110: The bitstream bs[15]_R is provided to DFLTx and SCDx (if instantiated) - 11111: The bitstream bs[15]_F is provided to DFLTx and SCDx (if instantiated) This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_BSMXACTIVE                \ [0x1f] BSMX Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the BSMX is effectively enabled (active) or not. BSSEL[4:0] can only be updated when the BSMXACTIVE is set to a . The BSMXACTIVE flag is a logical between OLDACTIVE, DFLTACTIVE, and SCDACTIVE flags. Both of them must be set to a in order update BSSEL[4:0] field. - 0: The BSMX is not active, and can be configured if needed - 1: The BSMX is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_DFLT3CR_DEF
    \
    \ @brief This register is used to control the digital filter 3.
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DFLTEN                    \ [0x00] Digital Filter Enable Set and cleared by software. This bit is used to control the start of acquisition of the corresponding digital filter path. The behavior of this bit depends on ACQMOD and external events. or the acquisition starts when the proper trigger event occurs if ACQMOD = 01x . The serial or parallel interface delivering the samples shall be enabled as well. - 0: The acquisition is stopped immediately - 1: The acquisition is immediately started if ACQMOD = 00x or 1xx ,
    $01 constant MDF1_DMAEN                     \ [0x01] DMA Requests Enable Set and cleared by software. This bit is used to control the generation of DMA request in order to transfer the processed samples into the memory. - 0: The DMA interface for the corresponding digital filter is disabled - 1: The DMA interface for the corresponding digital filter is enabled This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $02 constant MDF1_FTH                       \ [0x02] RXFIFO Threshold selection Set and cleared by software. This bit is used to select the RXFIFO threshold. This bit is not significant for RXFIFOs working in a interleaved transfer mode. Refer to Section 1.4.13.4: Using the interleaved transfer mode for details. - 0: RXFIFO threshold event generated when the RXFIFO is not empty - 1: RXFIFO threshold event generated when the RXFIFO is half-full This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_ACQMOD                    \ [0x04 : 3] Digital filter Trigger mode Set and cleared by software. This field is used to select the filter trigger mode. - 000: Asynchronous, continuous acquisition mode - 001: Asynchronous, single-shot acquisition mode - 010: Synchronous, continuous acquisition mode - 011: Synchronous, single-shot acquisition mode - 100: Window, continuous acquisition mode - 101: Synchronous, snapshot mode others: same a 000 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_TRGSENS                   \ [0x08] Digital filter Trigger sensitivity selection Set and cleared by software. This field is used to select the trigger sensitivity of the external signals - 0: A rising edge event triggers the acquisition - 1: A falling edge even triggers the acquisition Note that when the trigger source is TRGO or OLDx event, TRGSENS value is not taken into account. When TRGO is selected, the sensitivity is forced to falling edge, when OLDx event is selected, the sensitivity is forced to rising edge. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $0c constant MDF1_TRGSRC                    \ [0x0c : 4] Digital filter Trigger signal selection, Set and cleared by software. This field is used to select which external signals is used as trigger for the corresponding filter. - 0000: TRGO is selected - 0001: OLDx event is selected - 0010: mdf_trg[0] is selected ... - 1111: mdf_trg[13] is selected This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $10 constant MDF1_SNPSFMT                   \ [0x10] Snapshot data format Set and cleared by software. This field is used to select the data format for the snapshot mode. - 0: The integrator counter (INT_CNT) is not inserted into the MDF_SNPSxDR register, leaving a data resolution of 23 bits. - 1: The integrator counter (INT_CNT) is inserted at position [15:9] of MDF_SNPSxDR register, leaving a data resolution of 16 bits. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $14 constant MDF1_NBDIS                     \ [0x14 : 8] Number of samples to be discarded Set and cleared by software. This field is used to define the number of samples to be discarded every time the DFLTx is re-started. - 0: no sample discarded - 1: 1 sample discarded - 2: 2 samples discarded ... - 255: 255 samples discarded This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1e constant MDF1_DFLTRUN                   \ [0x1e] Digital filter Run Status Flag Set and cleared by hardware. This bit indicates if the digital filter is running or not. - 0: The digital filter is not running, and ready to accept a new trigger event - 1: The digital filter is running
    $1f constant MDF1_DFLTACTIVE                \ [0x1f] Digital filter Active Flag Set and cleared by hardware. This bit indicates if the digital filter is active: can be running or waiting for events. - 0: The digital filter is not active, and can be re-enabled again (via DFLTEN bit) if needed - 1: The digital filter is active
  [then]


  [ifdef] MDF1_MDF_DFLT3CICR_DEF
    \
    \ @brief This register is used to control the main CIC filter.
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DATSRC                    \ [0x00 : 2] Source data for the digital filter Set and cleared by software. 0x: Select the stream coming from the BSMX - 10: Select the stream coming from the ADCITF1 - 11: Select the stream coming from the ADCITF2 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_CICMOD                    \ [0x04 : 3] Select the CIC mode Set and cleared by software. This field allows the application to select the configuration and the order of the MCIC. When CICMOD[2:0] is equal to 0xx , the CIC is split into two filters: - The main CIC (MCIC) - The auxiliary CIC (ACIC), used for the out-off limit detector - 000: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in FastSinc filter - 001: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in Sinc1 filter - 010: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in Sinc2 filter - 011: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in Sinc3 filter - 100: The CIC is configured in single sinc4 filter others: The CIC is configured in single sinc5 filter This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_MCICD                     \ [0x08 : 9] CIC decimation ratio selection Set and cleared by software. This bit is used to allow the application to select the decimation ratio of the CIC. Decimation ratio smaller than 2 is not allowed. The decimation ratio is given by (CICDEC+1). - 0: Decimation ratio is 2 - 1: Decimation ratio is 2 - 2: Decimation ratio is 3 - 3: Decimation ratio is 4 ... - 511: Decimation ratio is 512 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $14 constant MDF1_SCALE                     \ [0x14 : 6] Scaling factor selection Set and cleared by software. This field is used to allow the application to select the gain to be applied at CIC output. Please refer to Table 13: Possible gain values for details. If the application attempts to write a new gain value while the previous one is not yet applied, this new gain value is ignored. Reading back the SCALE[5:0] field will inform the application on the current gain value. - 100000: - 48.2 dB, or shift right by 8 bits (default value) - 100001: - 44.6 dB, - 100010: - 42.1 dB, or shift right by 7 bits - 100011: - 38.6 dB, ... - 101110: -6 dB, or shift right by 1 bit - 101111: -2.5 dB, - 000000: 0 dB - 000001: + 3.5 dB, - 000010: + 6 dB, or shift left by 1 bit ... - 011000: + 72 dB, or shift left by 12 bits
  [then]


  [ifdef] MDF1_MDF_DFLT3RSFR_DEF
    \
    \ @brief This register is used to control the reshape and HPF filters.
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_RSFLTBYP                  \ [0x00] Reshaper filter bypass Set and cleared by software. This bit is used to bypass the reshape filter and its decimation block. - 0: The reshape filter is not bypassed (Default value) - 1: The reshape filter is bypassed This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_RSFLTD                    \ [0x04] Reshaper filter decimation ratio Set and cleared by software. This bit is used to select the decimation ratio for the reshape filter - 0: Decimation ratio is 4 (Default value) - 1: Decimation ratio is 1 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $07 constant MDF1_HPFBYP                    \ [0x07] High-Pass Filter bypass Set and cleared by software. This bit is used to bypass the high-pass filter. - 0: The high pass filter is not bypassed (Default value) - 1: The high pass filter is bypassed This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_HPFC                      \ [0x08 : 2] High-pass filter cut-off frequency Set and cleared by software. This field is used to select the cut-off frequency of the high-pass filter. FPCM represents the sampling frequency at HPF input. - 00: Cut-off frequency = 0.000625 x FPCM - 01: Cut-off frequency = 0.00125 x FPCM - 10: Cut-off frequency = 0.00250 x FPCM - 11: Cut-off frequency = 0.00950 x FPCM This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
  [then]


  [ifdef] MDF1_MDF_DFLT3INTR_DEF
    \
    \ @brief This register is used to the integrator (INT) settings.
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_INTDIV                    \ [0x00 : 2] Integrator output division Set and cleared by software. This bit is used to rescale the signal at the integrator output in order keep the data width lower than 24 bits. - 00: The integrator data outputs are divided by 128 (Default value) - 01: The integrator data outputs are divided by 32 - 10: The integrator data outputs are divided by 4 - 11: The integrator data outputs are not divided This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_INTVAL                    \ [0x04 : 7] Integration value selection Set and cleared by software. This field is used to select the integration value. - 0: The integration value is 1, meaning bypass mode (default after reset) - 1: The integration value is 2 - 2: The integration value is 3 ... - 127: The integration value is 128 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
  [then]


  [ifdef] MDF1_MDF_OLD3CR_DEF
    \
    \ @brief This register is used to configure the Out-of Limit Detector function.
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDEN                     \ [0x00] Over-Current Detector Enable Set and cleared by software. - 0: The OLD is disabled (Default value) - 1: The OLD is enabled, including the ACIC filter working in continuous mode.
    $01 constant MDF1_THINB                     \ [0x01] Threshold In band Set and cleared by software. - 0: The OLD generates an event if the signal is lower than OLDTHL OR higher than OLDTHH (Default value) - 1: The OLD generates an event if the signal is lower than OLDTHH AND higher than OLDTHL This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_BKOLD                     \ [0x04 : 4] Break signal assignment for out-of limit detector Set and cleared by software. BKOLD[i] = 0: Break signal (mdf_break[i]) is not assigned to threshold event BKOLD[i] = 1: Break signal (mdf_break[i]) is assigned to threshold event This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $0c constant MDF1_ACICN                     \ [0x0c : 2] OLD CIC order selection Set and cleared by software. This field allows the application to select the type, and the order of the ACIC. This field is only taken into account by the MDF when CICMOD[2:0] = 0xx . - 00: FastSinc filter type - 01: Sinc1 filter type - 10: Sinc2 filter type - 11: Sinc3 filter type This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $11 constant MDF1_ACICD                     \ [0x11 : 5] OLD CIC decimation ratio selection Set and cleared by software. This field is used to allow the application to select the decimation ratio of the ACIC. This field is only taken into account by the MDF when CICMOD[2:0] = 0xx . The decimation ratio is given by (ACICD+1). - 0: Decimation ratio is 1 - 1: Decimation ratio is 2 - 2: Decimation ratio is 3 - 3: Decimation ratio is 4 ... - 31: Decimation ratio is 32 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_OLDACTIVE                 \ [0x1f] OLD Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the OLD is effectively enabled (active) or not. The protected fields and registers of this function can only be updated when the OLDACTIVE is set to , please refer to Section 1.4.15: Register protection for details. The delay between a transition on OLDEN and a transition on OLDACTIVE is 2 periods of AHB clock and 2 periods of mdf_proc_ck. - 0: The OLD is not active, and can be configured if needed - 1: The OLD is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_OLD3THLR_DEF
    \
    \ @brief This register is used for the adjustment of the Out-off Limit low threshold.
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHL                    \ [0x00 : 26] OLD Low Threshold Value Set and cleared by software. OLDTHL represents a 26-bit signed value. The real threshold compared to the signal provided by the filter is OLDTHL. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
  [then]


  [ifdef] MDF1_MDF_OLD3THHR_DEF
    \
    \ @brief This register is used for the adjustment of the Out-off Limit high threshold.
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHH                    \ [0x00 : 26] OLD High Threshold Value Set and cleared by software. OLDTHH represents a 26-bit signed value. The real threshold compared to the signal provided by the filter is OLDTHH. This field can be write-protected, please refer to Section 1.4.15: Register protection for details
  [then]


  [ifdef] MDF1_MDF_DLY3CR_DEF
    \
    \ @brief This register is used for the adjustment stream delays.
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SKPDLY                    \ [0x00 : 7] Delay to apply to a bitstream Set and cleared by software. Defines the number of input samples that will be skipped. Skipping is applied immediately after writing to this field, if SKPBF = 0 , and the corresponding bit DFLTEN = 1 . If SKPBF = 1 the value written into the register is ignored by the delay state machine. - 0: No input sample skipped, - 1: 1 input sample skipped, ... - 127: 127 input sample skipped,
    $1f constant MDF1_SKPBF                     \ [0x1f] Skip Busy flag Set and cleared by hardware. Shall be used in order to control if the delay sequence is completed. - 0: Reading 0 means that the MDF is ready to accept a new value into SKPDLY[6:0]. - 1: Reading 1 means that last valid SKPDLY[6:0] is still under precessing.
  [then]


  [ifdef] MDF1_MDF_SCD3CR_DEF
    \
    \ @brief This register is used for the adjustment stream delays.
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SCDEN                     \ [0x00] Short circuit detector enable Set and cleared by software. - 0: The short circuit detector is disabled, - 1: The short circuit detector is enabled,
    $04 constant MDF1_BKSCD                     \ [0x04 : 4] Break signal assignment for short circuit detector Set and cleared by software. BKSCD[i] = 0: Break signal (mdf_break[i]) is not assigned to this SCD event BKSCD[i] = 1: Break signal (mdf_break[i]) is assigned to this SCD event This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $0c constant MDF1_SCDT                      \ [0x0c : 8] Short-circuit detector threshold Set and cleared by software. These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given input stream. - 0: 2 consecutive 1 s or 0 s will generate an event, - 1: 2 consecutive 1 s or 0 s will generate an event - 2: 3 consecutive 1 s or 0 s will generate an event, ... - 255: 256 consecutive 1 s or 0 s will generate an event, This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_SCDACTIVE                 \ [0x1f] SCD Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the SCD is effectively enabled (active) or not. The protected fields of this function can only be updated when the SCDACTIVE is set to a , please refer to Section 1.4.15: Register protection for details. The delay between a transition on SCDEN and a transition on SCDACTIVE is 2 periods of AHB clock and 2 periods of mdf_proc_ck. - 0: The SCD is not active, and can be configured if needed - 1: The SCD is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_DFLT3IER_DEF
    \
    \ @brief MDF DFLTx interrupt enable register x
    \ Address offset: 0x22C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHIE                     \ [0x00] RXFIFO threshold interrupt enable Set and cleared by software. - 0: RXFIFO threshold interrupt disabled - 1: RXFIFO threshold interrupt enabled
    $01 constant MDF1_DOVRIE                    \ [0x01] Data overflow interrupt enable Set and cleared by software. - 0: Data overflow interrupt disabled - 1: Data overflow interrupt enabled
    $02 constant MDF1_SSDRIE                    \ [0x02] Snapshot data ready interrupt enable Set and cleared by software. - 0: Snapshot data ready interrupt disabled - 1: Snapshot data ready interrupt enabled
    $04 constant MDF1_OLDIE                     \ [0x04] Out-of Limit interrupt enable Set and cleared by software. - 0: OLD event interrupt disabled - 1: OLD event interrupt enabled
    $07 constant MDF1_SSOVRIE                   \ [0x07] Snapshot overrun interrupt enable Set and cleared by software. - 0: Snapshot overrun interrupt disabled - 1: Snapshot overrun interrupt enabled
    $08 constant MDF1_SCDIE                     \ [0x08] Short-Circuit Detector interrupt enable Set and cleared by software. - 0: SCD interrupt disabled - 1: SCD interrupt enabled
    $09 constant MDF1_SATIE                     \ [0x09] Saturation detection interrupt enable Set and cleared by software. - 0: Saturation interrupt disabled - 1: Saturation interrupt enabled
    $0a constant MDF1_CKABIE                    \ [0x0a] Clock absence detection interrupt enable Set and cleared by software. - 0: Clock absence interrupt disabled - 1: Clock absence interrupt enabled
    $0b constant MDF1_RFOVRIE                   \ [0x0b] Reshape Filter Overrun interrupt enable Set and cleared by software. - 0: Reshape filter overrun interrupt disabled - 1: Reshape filter overrun interrupt enabled
  [then]


  [ifdef] MDF1_MDF_DFLT3ISR_DEF
    \
    \ @brief This register contains the status flags for each digital filter path.
    \ Address offset: 0x230
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHF                      \ [0x00] RXFIFO threshold flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that the RXFIFO threshold is not reached, writing 0 has no effect. - 1: Reading 1 means that the RXFIFO reached the threshold, writing 1 clears this flag.
    $01 constant MDF1_DOVRF                     \ [0x01] Data overflow flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no overflow is detected, writing 0 has no effect. - 1: Reading 1 means that an overflow is detected, writing 1 clears this flag.
    $02 constant MDF1_SSDRF                     \ [0x02] Snapshot data ready flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no data is available on MDF_SNPSxDR, writing 0 has no effect. - 1: Reading 1 means that a new data is available on MDF_SNPSxDR, writing 1 clears this flag.
    $03 constant MDF1_RXNEF                     \ [0x03] RXFIFO Not Empty flag Set and cleared by hardware according to the RXFIFO level. - 0: Reading 0 means that the RXFIFO is empty. - 1: Reading 1 means that the RXFIFO is not empty.
    $04 constant MDF1_OLDF                      \ [0x04] Out-of Limit Detector flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no OLD event is detected, writing 0 has no effect. - 1: Reading 1 means that an OLD event is detected, writing 1 clears THHF, THLF and OLDF flags.
    $05 constant MDF1_THLF                      \ [0x05] Low threshold status flag Set by hardware, and cleared by software by writing OLDF bit to 1 . This flag indicates the status of the low threshold comparator when the last OLD event occurred. This bit gives additional information on the conditions triggering the last OLD event. It can be cleared by writing OLDF flag to a 1. - 0: The signal was lower than OLDTHL, when the last OLD event occurred - 1: The signal was higher than OLDTHL, when the last OLD event occurred
    $06 constant MDF1_THHF                      \ [0x06] High threshold status flag Set by hardware, and cleared by software by writing OLDF bit to 1 . This flag indicates the status of the high threshold comparator when the last OLD event occurred. This bit gives additional information on the conditions triggering the last OLD event. It can be cleared by writing OLDF flag to a 1. - 0: The signal was lower than OLDTHH, when the last OLD event occurred - 1: The signal was higher than OLDTHH, when the last OLD event occurred
    $07 constant MDF1_SSOVRF                    \ [0x07] Snapshot overrun flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no snapshot overrun event is detected, writing 0 has no effect. - 1: Reading 1 means that a snapshot overrun event is detected, writing 1 clears this flag.
    $08 constant MDF1_SCDF                      \ [0x08] Short-Circuit Detector flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no SCD event is detected, writing 0 has no effect. - 1: Reading 1 means that a SCD event is detected, writing 1 clears this flag.
    $09 constant MDF1_SATF                      \ [0x09] Saturation detection flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no saturation is detected, writing 0 has no effect. - 1: Reading 1 means that a saturation is detected, writing 1 clears this flag.
    $0a constant MDF1_CKABF                     \ [0x0a] Clock absence detection flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no clock absence is detected, writing 0 has no effect. - 1: Reading 1 means that a clock absence is detected, writing 1 clears this flag.
    $0b constant MDF1_RFOVRF                    \ [0x0b] Reshape Filter Overrun detection flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no reshape filter overrun is detected, writing 0 has no effect. - 1: Reading 1 means that reshape filter overrun is detected, writing 1 clears this flag.
  [then]


  [ifdef] MDF1_MDF_OEC3CR_DEF
    \
    \ @brief This register contains the offset compensation value.
    \ Address offset: 0x234
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OFFSET                    \ [0x00 : 26] Offset error compensation Set and cleared by software. If the application attempts to write a new offset value while the previous one is not yet applied, this new offset value is ignored. Reading back the OFFSET[25:0] field will inform the application on the current offset value. OFFSET[25:0] represents the value to be subtracted to the signal before going to the SCALE.
  [then]


  [ifdef] MDF1_MDF_SNPS3DR_DEF
    \
    \ @brief This register is used to read the data processed by each digital filter in snapshot mode.
    \ Address offset: 0x26C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_MCICDC                    \ [0x00 : 9] Contains the MCIC decimation counter value at the moment of the last trigger event occurs (MCIC_CNT)
    $09 constant MDF1_EXTSDR                    \ [0x09 : 7] Extended data size If SNPSFMT = 0 , EXTSDR[6:0] contains the bit 7 to 1 of the last valid data processed by the digital filter, If SNPSFMT = 1 , this field contains the INT accumulator counter value at the moment of the last trigger event occurs (INT_CNT).
    $10 constant MDF1_SDR                       \ [0x10 : 16] Contains the 16 MSB of the last valid data processed by the digital filter.
  [then]


  [ifdef] MDF1_MDF_DFLT3DR_DEF
    \
    \ @brief This register is used to read the data processed by each digital filter.
    \ Address offset: 0x270
    \ Reset value: 0x00000000
    \
    $08 constant MDF1_DR                        \ [0x08 : 24] Data processed by digital filter.
  [then]


  [ifdef] MDF1_MDF_SITF4CR_DEF
    \
    \ @brief This register is used to control the serial interfaces (SITFx).
    \ Address offset: 0x280
    \ Reset value: 0x00001F00
    \
    $00 constant MDF1_SITFEN                    \ [0x00] Serial interface enable Set and cleared by software. This bit is used to enable/disable the serial interface. - 0: Serial interface disabled - 1: Serial interface enabled
    $01 constant MDF1_SCKSRC                    \ [0x01 : 2] Serial clock source Set and cleared by software. This bit is used to select the clock source of the serial interface. - 00: Serial clock source is MDF_CCK0 - 01: Serial clock source is MDF_CCK1 1x: Serial clock source is MDF_CKIx, not allowed in LF_MASTER SPI mode This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_SITFMOD                   \ [0x04 : 2] Serial interface type Set and cleared by software. This field is used to defined the serial interface type. - 00: LF_MASTER (Low-Frequency MASTER) SPI mode - 01: Normal SPI mode - 10: Manchester mode: rising edge = logic 0, falling edge = logic 1 - 11: Manchester mode: rising edge = logic 1, falling edge = logic 0 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_STH                       \ [0x08 : 5] Manchester Symbol threshold / SPI threshold Set and cleared by software. This field is used for Manchester mode, in order to define the expected symbol threshold levels. Please refer to Section : Manchester mode for details on computation. In addition this field is used to define the timeout value for the clock absence detection in Normal SPI mode. Values of STH[4:0] lower than 4 are invalid. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_SITFACTIVE                \ [0x1f] Serial interface Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the serial interface is effectively enabled (active) or not. The protected fields of this function can only be updated when the SITFACTIVE is set , please refer to Section 1.4.15: Register protection for details. The delay between a transition on SITFEN and a transition on SITFACTIVE is 2 periods of AHB clock and 2 periods of mdf_proc_ck. - 0: The serial interface is not active, and can be configured if needed - 1: The serial interface is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_BSMX4CR_DEF
    \
    \ @brief This register is used to select the bitstream to be provided to the corresponding digital filter and to the SCD.
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_BSSEL                     \ [0x00 : 5] Bitstream Selection Set and cleared by software. This field is used to select the bitstream to be processed for the digital filter x and for the SCDx. The size of this field depends on the number of DFLTx instantiated. If the BSSEL is selecting an input which is not instantiated, the MDF will select the valid stream bs[x]_F having the higher index number. - 00000: The bitstream bs[0]_R is provided to DFLTx and SCDx - 00001: The bitstream bs[0]_F is provided to DFLTx and SCDx - 00010: The bitstream bs[1]_R is provided to DFLTx and SCDx (if instantiated) - 00011: The bitstream bs[1]_F is provided to DFLTx and SCDx (if instantiated) ... - 11110: The bitstream bs[15]_R is provided to DFLTx and SCDx (if instantiated) - 11111: The bitstream bs[15]_F is provided to DFLTx and SCDx (if instantiated) This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_BSMXACTIVE                \ [0x1f] BSMX Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the BSMX is effectively enabled (active) or not. BSSEL[4:0] can only be updated when the BSMXACTIVE is set to . The BSMXACTIVE flag is a logical between OLDACTIVE, DFLTACTIVE, and SCDACTIVE flags. Both of them must be set to in order update BSSEL[4:0] field. - 0: The BSMX is not active, and can be configured if needed - 1: The BSMX is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_DFLT4CR_DEF
    \
    \ @brief This register is used to control the digital filter 4.
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DFLTEN                    \ [0x00] Digital Filter Enable Set and cleared by software. This bit is used to control the start of acquisition of the corresponding digital filter path. The behavior of this bit depends on ACQMOD and external events. or the acquisition starts when the proper trigger event occurs if ACQMOD = 01x . The serial or parallel interface delivering the samples shall be enabled as well. - 0: The acquisition is stopped immediately - 1: The acquisition is immediately started if ACQMOD = 00x or 1xx ,
    $01 constant MDF1_DMAEN                     \ [0x01] DMA Requests Enable Set and cleared by software. This bit is used to control the generation of DMA request in order to transfer the processed samples into the memory. - 0: The DMA interface for the corresponding digital filter is disabled - 1: The DMA interface for the corresponding digital filter is enabled This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $02 constant MDF1_FTH                       \ [0x02] RXFIFO Threshold selection Set and cleared by software. This bit is used to select the RXFIFO threshold. This bit is not significant for RXFIFOs working in a interleaved transfer mode. Refer to Section 1.4.13.4: Using the interleaved transfer mode for details. - 0: RXFIFO threshold event generated when the RXFIFO is not empty - 1: RXFIFO threshold event generated when the RXFIFO is half-full This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_ACQMOD                    \ [0x04 : 3] Digital filter Trigger mode Set and cleared by software. This field is used to select the filter trigger mode. - 000: Asynchronous, continuous acquisition mode - 001: Asynchronous, single-shot acquisition mode - 010: Synchronous, continuous acquisition mode - 011: Synchronous, single-shot acquisition mode - 100: Window, continuous acquisition mode - 101: Synchronous, snapshot mode others: same a 000 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_TRGSENS                   \ [0x08] Digital filter Trigger sensitivity selection Set and cleared by software. This field is used to select the trigger sensitivity of the external signals - 0: A rising edge event triggers the acquisition - 1: A falling edge even triggers the acquisition Note that when the trigger source is TRGO or OLDx event, TRGSENS value is not taken into account. When TRGO is selected, the sensitivity is forced to falling edge, when OLDx event is selected, the sensitivity is forced to rising edge. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $0c constant MDF1_TRGSRC                    \ [0x0c : 4] Digital filter Trigger signal selection, Set and cleared by software. This field is used to select which external signals is used as trigger for the corresponding filter. - 0000: TRGO is selected - 0001: OLDx event is selected - 0010: mdf_trg[0] is selected ... - 1111: mdf_trg[13] is selected This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $10 constant MDF1_SNPSFMT                   \ [0x10] Snapshot data format Set and cleared by software. This field is used to select the data format for the snapshot mode. - 0: The integrator counter (INT_CNT) is not inserted into the MDF_SNPSxDR register, leaving a data resolution of 23 bits. - 1: The integrator counter (INT_CNT) is inserted at position [15:9] of MDF_SNPSxDR register, leaving a data resolution of 16 bits. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $14 constant MDF1_NBDIS                     \ [0x14 : 8] Number of samples to be discarded Set and cleared by software. This field is used to define the number of samples to be discarded every time the DFLTx is re-started. - 0: no sample discarded - 1: 1 sample discarded - 2: 2 samples discarded ... - 255: 255 samples discarded This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1e constant MDF1_DFLTRUN                   \ [0x1e] Digital filter Run Status Flag Set and cleared by hardware. This bit indicates if the digital filter is running or not. - 0: The digital filter is not running, and ready to accept a new trigger event - 1: The digital filter is running
    $1f constant MDF1_DFLTACTIVE                \ [0x1f] Digital filter Active Flag Set and cleared by hardware. This bit indicates if the digital filter is active: can be running or waiting for events. - 0: The digital filter is not active, and can be re-enabled again (via DFLTEN bit) if needed - 1: The digital filter is active
  [then]


  [ifdef] MDF1_MDF_DFLT4CICR_DEF
    \
    \ @brief This register is used to control the main CIC filter.
    \ Address offset: 0x28C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DATSRC                    \ [0x00 : 2] Source data for the digital filter Set and cleared by software. 0x: Select the stream coming from the BSMX - 10: Select the stream coming from the ADCITF1 - 11: Select the stream coming from the ADCITF2 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_CICMOD                    \ [0x04 : 3] Select the CIC mode Set and cleared by software. This field allows the application to select the configuration and the order of the MCIC. When CICMOD[2:0] is equal to 0xx , the CIC is split into two filters: - The main CIC (MCIC) - The auxiliary CIC (ACIC), used for the out-off limit detector - 000: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in FastSinc filter - 001: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in Sinc1 filter - 010: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in Sinc2 filter - 011: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in Sinc3 filter - 100: The CIC is configured in single sinc4 filter others: The CIC is configured in single sinc5 filter This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_MCICD                     \ [0x08 : 9] CIC decimation ratio selection Set and cleared by software. This bit is used to allow the application to select the decimation ratio of the CIC. Decimation ratio smaller than 2 is not allowed. The decimation ratio is given by (CICDEC+1). - 0: Decimation ratio is 2 - 1: Decimation ratio is 2 - 2: Decimation ratio is 3 - 3: Decimation ratio is 4 ... - 511: Decimation ratio is 512 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $14 constant MDF1_SCALE                     \ [0x14 : 6] Scaling factor selection Set and cleared by software. This field is used to allow the application to select the gain to be applied at CIC output. Please refer to Table 13: Possible gain values for details. If the application attempts to write a new gain value while the previous one is not yet applied, this new gain value is ignored. Reading back the SCALE[5:0] field will inform the application on the current gain value. - 100000: - 48.2 dB, or shift right by 8 bits (default value) - 100001: - 44.6 dB, - 100010: - 42.1 dB, or shift right by 7 bits - 100011: - 38.6 dB, ... - 101110: -6 dB, or shift right by 1 bit - 101111: -2.5 dB, - 000000: 0 dB - 000001: + 3.5 dB, - 000010: + 6 dB, or shift left by 1 bit ... - 011000: + 72 dB, or shift left by 12 bits
  [then]


  [ifdef] MDF1_MDF_DFLT4RSFR_DEF
    \
    \ @brief This register is used to control the reshape and HPF filters.
    \ Address offset: 0x290
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_RSFLTBYP                  \ [0x00] Reshaper filter bypass Set and cleared by software. This bit is used to bypass the reshape filter and its decimation block. - 0: The reshape filter is not bypassed (Default value) - 1: The reshape filter is bypassed This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_RSFLTD                    \ [0x04] Reshaper filter decimation ratio Set and cleared by software. This bit is used to select the decimation ratio for the reshape filter - 0: Decimation ratio is 4 (Default value) - 1: Decimation ratio is 1 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $07 constant MDF1_HPFBYP                    \ [0x07] High-Pass Filter bypass Set and cleared by software. This bit is used to bypass the high-pass filter. - 0: The high pass filter is not bypassed (Default value) - 1: The high pass filter is bypassed This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_HPFC                      \ [0x08 : 2] High-pass filter cut-off frequency Set and cleared by software. This field is used to select the cut-off frequency of the high-pass filter. FPCM represents the sampling frequency at HPF input. - 00: Cut-off frequency = 0.000625 x FPCM - 01: Cut-off frequency = 0.00125 x FPCM - 10: Cut-off frequency = 0.00250 x FPCM - 11: Cut-off frequency = 0.00950 x FPCM This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
  [then]


  [ifdef] MDF1_MDF_DFLT4INTR_DEF
    \
    \ @brief This register is used to the integrator (INT) settings.
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_INTDIV                    \ [0x00 : 2] Integrator output division Set and cleared by software. This bit is used to rescale the signal at the integrator output in order keep the data width lower than 24 bits. - 00: The integrator data outputs are divided by 128 (Default value) - 01: The integrator data outputs are divided by 32 - 10: The integrator data outputs are divided by 4 - 11: The integrator data outputs are not divided This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_INTVAL                    \ [0x04 : 7] Integration value selection Set and cleared by software. This field is used to select the integration value. - 0: The integration value is 1, meaning bypass mode (default after reset) - 1: The integration value is 2 - 2: The integration value is 3 ... - 127: The integration value is 128 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
  [then]


  [ifdef] MDF1_MDF_OLD4CR_DEF
    \
    \ @brief This register is used to configure the Out-of Limit Detector function.
    \ Address offset: 0x298
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDEN                     \ [0x00] Over-Current Detector Enable Set and cleared by software. - 0: The OLD is disabled (Default value) - 1: The OLD is enabled, including the ACIC filter working in continuous mode.
    $01 constant MDF1_THINB                     \ [0x01] Threshold In band Set and cleared by software. - 0: The OLD generates an event if the signal is lower than OLDTHL OR higher than OLDTHH (Default value) - 1: The OLD generates an event if the signal is lower than OLDTHH AND higher than OLDTHL This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_BKOLD                     \ [0x04 : 4] Break signal assignment for out-of limit detector Set and cleared by software. BKOLD[i] = 0: Break signal (mdf_break[i]) is not assigned to threshold event BKOLD[i] = 1: Break signal (mdf_break[i]) is assigned to threshold event This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $0c constant MDF1_ACICN                     \ [0x0c : 2] OLD CIC order selection Set and cleared by software. This field allows the application to select the type, and the order of the ACIC. This field is only taken into account by the MDF when CICMOD[2:0] = 0xx . - 00: FastSinc filter type - 01: Sinc1 filter type - 10: Sinc2 filter type - 11: Sinc3 filter type This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $11 constant MDF1_ACICD                     \ [0x11 : 5] OLD CIC decimation ratio selection Set and cleared by software. This field is used to allow the application to select the decimation ratio of the ACIC. This field is only taken into account by the MDF when CICMOD[2:0] = 0xx . The decimation ratio is given by (ACICD+1). - 0: Decimation ratio is 1 - 1: Decimation ratio is 2 - 2: Decimation ratio is 3 - 3: Decimation ratio is 4 ... - 31: Decimation ratio is 32 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_OLDACTIVE                 \ [0x1f] OLD Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the OLD is effectively enabled (active) or not. The protected fields and registers of this function can only be updated when the OLDACTIVE is set to , please refer to Section 1.4.15: Register protection for details. The delay between a transition on OLDEN and a transition on OLDACTIVE is 2 periods of AHB clock and 2 periods of mdf_proc_ck. - 0: The OLD is not active, and can be configured if needed - 1: The OLD is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_OLD4THLR_DEF
    \
    \ @brief This register is used for the adjustment of the Out-off Limit low threshold.
    \ Address offset: 0x29C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHL                    \ [0x00 : 26] OLD Low Threshold Value Set and cleared by software. OLDTHL represents a 26-bit signed value. The real threshold compared to the signal provided by the filter is OLDTHL. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
  [then]


  [ifdef] MDF1_MDF_OLD4THHR_DEF
    \
    \ @brief This register is used for the adjustment of the Out-off Limit high threshold.
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHH                    \ [0x00 : 26] OLD High Threshold Value Set and cleared by software. OLDTHH represents a 26-bit signed value. The real threshold compared to the signal provided by the filter is OLDTHH. This field can be write-protected, please refer to Section 1.4.15: Register protection for details
  [then]


  [ifdef] MDF1_MDF_DLY4CR_DEF
    \
    \ @brief This register is used for the adjustment stream delays.
    \ Address offset: 0x2A4
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SKPDLY                    \ [0x00 : 7] Delay to apply to a bitstream Set and cleared by software. Defines the number of input samples that will be skipped. Skipping is applied immediately after writing to this field, if SKPBF = 0 , and the corresponding bit DFLTEN = 1 . If SKPBF = 1 the value written into the register is ignored by the delay state machine. - 0: No input sample skipped, - 1: 1 input sample skipped, ... - 127: 127 input sample skipped,
    $1f constant MDF1_SKPBF                     \ [0x1f] Skip Busy flag Set and cleared by hardware. Shall be used in order to control if the delay sequence is completed. - 0: Reading 0 means that the MDF is ready to accept a new value into SKPDLY[6:0]. - 1: Reading 1 means that last valid SKPDLY[6:0] is still under precessing.
  [then]


  [ifdef] MDF1_MDF_SCD4CR_DEF
    \
    \ @brief This register is used for the adjustment stream delays.
    \ Address offset: 0x2A8
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SCDEN                     \ [0x00] Short circuit detector enable Set and cleared by software. - 0: The short circuit detector is disabled, - 1: The short circuit detector is enabled,
    $04 constant MDF1_BKSCD                     \ [0x04 : 4] Break signal assignment for short circuit detector Set and cleared by software. BKSCD[i] = 0: Break signal (mdf_break[i]) is not assigned to this SCD event BKSCD[i] = 1: Break signal (mdf_break[i]) is assigned to this SCD event This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $0c constant MDF1_SCDT                      \ [0x0c : 8] Short-circuit detector threshold Set and cleared by software. These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given input stream. - 0: 2 consecutive 1 s or 0 s will generate an event, - 1: 2 consecutive 1 s or 0 s will generate an event - 2: 3 consecutive 1 s or 0 s will generate an event, ... - 255: 256 consecutive 1 s or 0 s will generate an event, This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_SCDACTIVE                 \ [0x1f] SCD Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the SCD is effectively enabled (active) or not. The protected fields of this function can only be updated when the SCDACTIVE is set to a a , please refer to Section 1.4.15: Register protection for details. The delay between a transition on SCDEN and a transition on SCDACTIVE is 2 periods of AHB clock and 2 periods of mdf_proc_ck. - 0: The SCD is not active, and can be configured if needed - 1: The SCD is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_DFLT4IER_DEF
    \
    \ @brief MDF DFLTx interrupt enable register x
    \ Address offset: 0x2AC
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHIE                     \ [0x00] RXFIFO threshold interrupt enable Set and cleared by software. - 0: RXFIFO threshold interrupt disabled - 1: RXFIFO threshold interrupt enabled
    $01 constant MDF1_DOVRIE                    \ [0x01] Data overflow interrupt enable Set and cleared by software. - 0: Data overflow interrupt disabled - 1: Data overflow interrupt enabled
    $02 constant MDF1_SSDRIE                    \ [0x02] Snapshot data ready interrupt enable Set and cleared by software. - 0: Snapshot data ready interrupt disabled - 1: Snapshot data ready interrupt enabled
    $04 constant MDF1_OLDIE                     \ [0x04] Out-of Limit interrupt enable Set and cleared by software. - 0: OLD event interrupt disabled - 1: OLD event interrupt enabled
    $07 constant MDF1_SSOVRIE                   \ [0x07] Snapshot overrun interrupt enable Set and cleared by software. - 0: Snapshot overrun interrupt disabled - 1: Snapshot overrun interrupt enabled
    $08 constant MDF1_SCDIE                     \ [0x08] Short-Circuit Detector interrupt enable Set and cleared by software. - 0: SCD interrupt disabled - 1: SCD interrupt enabled
    $09 constant MDF1_SATIE                     \ [0x09] Saturation detection interrupt enable Set and cleared by software. - 0: Saturation interrupt disabled - 1: Saturation interrupt enabled
    $0a constant MDF1_CKABIE                    \ [0x0a] Clock absence detection interrupt enable Set and cleared by software. - 0: Clock absence interrupt disabled - 1: Clock absence interrupt enabled
    $0b constant MDF1_RFOVRIE                   \ [0x0b] Reshape Filter Overrun interrupt enable Set and cleared by software. - 0: Reshape filter overrun interrupt disabled - 1: Reshape filter overrun interrupt enabled
  [then]


  [ifdef] MDF1_MDF_DFLT4ISR_DEF
    \
    \ @brief This register contains the status flags for each digital filter path.
    \ Address offset: 0x2B0
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHF                      \ [0x00] RXFIFO threshold flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that the RXFIFO threshold is not reached, writing 0 has no effect. - 1: Reading 1 means that the RXFIFO reached the threshold, writing 1 clears this flag.
    $01 constant MDF1_DOVRF                     \ [0x01] Data overflow flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no overflow is detected, writing 0 has no effect. - 1: Reading 1 means that an overflow is detected, writing 1 clears this flag.
    $02 constant MDF1_SSDRF                     \ [0x02] Snapshot data ready flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no data is available on MDF_SNPSxDR, writing 0 has no effect. - 1: Reading 1 means that a new data is available on MDF_SNPSxDR, writing 1 clears this flag.
    $03 constant MDF1_RXNEF                     \ [0x03] RXFIFO Not Empty flag Set and cleared by hardware according to the RXFIFO level. - 0: Reading 0 means that the RXFIFO is empty. - 1: Reading 1 means that the RXFIFO is not empty.
    $04 constant MDF1_OLDF                      \ [0x04] Out-of Limit Detector flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no OLD event is detected, writing 0 has no effect. - 1: Reading 1 means that an OLD event is detected, writing 1 clears THHF, THLF and OLDF flags.
    $05 constant MDF1_THLF                      \ [0x05] Low threshold status flag Set by hardware, and cleared by software by writing OLDF bit to 1 . This flag indicates the status of the low threshold comparator when the last OLD event occurred. This bit gives additional information on the conditions triggering the last OLD event. It can be cleared by writing OLDF flag to a 1. - 0: The signal was lower than OLDTHL, when the last OLD event occurred - 1: The signal was higher than OLDTHL, when the last OLD event occurred
    $06 constant MDF1_THHF                      \ [0x06] High threshold status flag Set by hardware, and cleared by software by writing OLDF bit to 1 . This flag indicates the status of the high threshold comparator when the last OLD event occurred. This bit gives additional information on the conditions triggering the last OLD event. It can be cleared by writing OLDF flag to a 1. - 0: The signal was lower than OLDTHH, when the last OLD event occurred - 1: The signal was higher than OLDTHH, when the last OLD event occurred
    $07 constant MDF1_SSOVRF                    \ [0x07] Snapshot overrun flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no snapshot overrun event is detected, writing 0 has no effect. - 1: Reading 1 means that a snapshot overrun event is detected, writing 1 clears this flag.
    $08 constant MDF1_SCDF                      \ [0x08] Short-Circuit Detector flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no SCD event is detected, writing 0 has no effect. - 1: Reading 1 means that a SCD event is detected, writing 1 clears this flag.
    $09 constant MDF1_SATF                      \ [0x09] Saturation detection flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no saturation is detected, writing 0 has no effect. - 1: Reading 1 means that a saturation is detected, writing 1 clears this flag.
    $0a constant MDF1_CKABF                     \ [0x0a] Clock absence detection flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no clock absence is detected, writing 0 has no effect. - 1: Reading 1 means that a clock absence is detected, writing 1 clears this flag.
    $0b constant MDF1_RFOVRF                    \ [0x0b] Reshape Filter Overrun detection flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no reshape filter overrun is detected, writing 0 has no effect. - 1: Reading 1 means that reshape filter overrun is detected, writing 1 clears this flag.
  [then]


  [ifdef] MDF1_MDF_OEC4CR_DEF
    \
    \ @brief This register contains the offset compensation value.
    \ Address offset: 0x2B4
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OFFSET                    \ [0x00 : 26] Offset error compensation Set and cleared by software. If the application attempts to write a new offset value while the previous one is not yet applied, this new offset value is ignored. Reading back the OFFSET[25:0] field will inform the application on the current offset value. OFFSET[25:0] represents the value to be subtracted to the signal before going to the SCALE.
  [then]


  [ifdef] MDF1_MDF_SNPS4DR_DEF
    \
    \ @brief This register is used to read the data processed by each digital filter in snapshot mode.
    \ Address offset: 0x2EC
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_MCICDC                    \ [0x00 : 9] Contains the MCIC decimation counter value at the moment of the last trigger event occurs (MCIC_CNT)
    $09 constant MDF1_EXTSDR                    \ [0x09 : 7] Extended data size If SNPSFMT = 0 , EXTSDR[6:0] contains the bit 7 to 1 of the last valid data processed by the digital filter, If SNPSFMT = 1 , this field contains the INT accumulator counter value at the moment of the last trigger event occurs (INT_CNT).
    $10 constant MDF1_SDR                       \ [0x10 : 16] Contains the 16 MSB of the last valid data processed by the digital filter.
  [then]


  [ifdef] MDF1_MDF_DFLT4DR_DEF
    \
    \ @brief This register is used to read the data processed by each digital filter.
    \ Address offset: 0x2F0
    \ Reset value: 0x00000000
    \
    $08 constant MDF1_DR                        \ [0x08 : 24] Data processed by digital filter.
  [then]


  [ifdef] MDF1_MDF_SITF5CR_DEF
    \
    \ @brief This register is used to control the serial interfaces (SITFx).
    \ Address offset: 0x300
    \ Reset value: 0x00001F00
    \
    $00 constant MDF1_SITFEN                    \ [0x00] Serial interface enable Set and cleared by software. This bit is used to enable/disable the serial interface. - 0: Serial interface disabled - 1: Serial interface enabled
    $01 constant MDF1_SCKSRC                    \ [0x01 : 2] Serial clock source Set and cleared by software. This bit is used to select the clock source of the serial interface. - 00: Serial clock source is MDF_CCK0 - 01: Serial clock source is MDF_CCK1 1x: Serial clock source is MDF_CKIx, not allowed in LF_MASTER SPI mode This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_SITFMOD                   \ [0x04 : 2] Serial interface type Set and cleared by software. This field is used to defined the serial interface type. - 00: LF_MASTER (Low-Frequency MASTER) SPI mode - 01: Normal SPI mode - 10: Manchester mode: rising edge = logic 0, falling edge = logic 1 - 11: Manchester mode: rising edge = logic 1, falling edge = logic 0 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_STH                       \ [0x08 : 5] Manchester Symbol threshold / SPI threshold Set and cleared by software. This field is used for Manchester mode, in order to define the expected symbol threshold levels. Please refer to Section : Manchester mode for details on computation. In addition this field is used to define the timeout value for the clock absence detection in Normal SPI mode. Values of STH[4:0] lower than 4 are invalid. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_SITFACTIVE                \ [0x1f] Serial interface Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the serial interface is effectively enabled (active) or not. The protected fields of this function can only be updated when the SITFACTIVE is set , please refer to Section 1.4.15: Register protection for details. The delay between a transition on SITFEN and a transition on SITFACTIVE is 2 periods of AHB clock and 2 periods of mdf_proc_ck. - 0: The serial interface is not active, and can be configured if needed - 1: The serial interface is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_BSMX5CR_DEF
    \
    \ @brief This register is used to select the bitstream to be provided to the corresponding digital filter and to the SCD.
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_BSSEL                     \ [0x00 : 5] Bitstream Selection Set and cleared by software. This field is used to select the bitstream to be processed for the digital filter x and for the SCDx. The size of this field depends on the number of DFLTx instantiated. If the BSSEL is selecting an input which is not instantiated, the MDF will select the valid stream bs[x]_F having the higher index number. - 00000: The bitstream bs[0]_R is provided to DFLTx and SCDx - 00001: The bitstream bs[0]_F is provided to DFLTx and SCDx - 00010: The bitstream bs[1]_R is provided to DFLTx and SCDx (if instantiated) - 00011: The bitstream bs[1]_F is provided to DFLTx and SCDx (if instantiated) ... - 11110: The bitstream bs[15]_R is provided to DFLTx and SCDx (if instantiated) - 11111: The bitstream bs[15]_F is provided to DFLTx and SCDx (if instantiated) This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_BSMXACTIVE                \ [0x1f] BSMX Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the BSMX is effectively enabled (active) or not. BSSEL[4:0] can only be updated when the BSMXACTIVE is set to . The BSMXACTIVE flag is a logical between OLDACTIVE, DFLTACTIVE, and SCDACTIVE flags. Both of them must be set to in order update BSSEL[4:0] field. - 0: The BSMX is not active, and can be configured if needed - 1: The BSMX is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_DFLT5CR_DEF
    \
    \ @brief This register is used to control the digital filter x.
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DFLTEN                    \ [0x00] Digital Filter Enable Set and cleared by software. This bit is used to control the start of acquisition of the corresponding digital filter path. The behavior of this bit depends on ACQMOD and external events. or the acquisition starts when the proper trigger event occurs if ACQMOD = 01x . The serial or parallel interface delivering the samples shall be enabled as well. - 0: The acquisition is stopped immediately - 1: The acquisition is immediately started if ACQMOD = 00x or 1xx ,
    $01 constant MDF1_DMAEN                     \ [0x01] DMA Requests Enable Set and cleared by software. This bit is used to control the generation of DMA request in order to transfer the processed samples into the memory. - 0: The DMA interface for the corresponding digital filter is disabled - 1: The DMA interface for the corresponding digital filter is enabled This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $02 constant MDF1_FTH                       \ [0x02] RXFIFO Threshold selection Set and cleared by software. This bit is used to select the RXFIFO threshold. This bit is not significant for RXFIFOs working in interleaved transfer mode. Refer to Section 1.4.13.4: Using the interleaved transfer mode for details. - 0: RXFIFO threshold event generated when the RXFIFO is not empty - 1: RXFIFO threshold event generated when the RXFIFO is half-full This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_ACQMOD                    \ [0x04 : 3] Digital filter Trigger mode Set and cleared by software. This field is used to select the filter trigger mode. - 000: Asynchronous, continuous acquisition mode - 001: Asynchronous, single-shot acquisition mode - 010: Synchronous, continuous acquisition mode - 011: Synchronous, single-shot acquisition mode - 100: Window, continuous acquisition mode - 101: Synchronous, snapshot mode others: same a 000 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_TRGSENS                   \ [0x08] Digital filter Trigger sensitivity selection Set and cleared by software. This field is used to select the trigger sensitivity of the external signals - 0: A rising edge event triggers the acquisition - 1: A falling edge even triggers the acquisition Note that when the trigger source is TRGO or OLDx event, TRGSENS value is not taken into account. When TRGO is selected, the sensitivity is forced to falling edge, when OLDx event is selected, the sensitivity is forced to rising edge. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $0c constant MDF1_TRGSRC                    \ [0x0c : 4] Digital filter Trigger signal selection, Set and cleared by software. This field is used to select which external signals is used as trigger for the corresponding filter. - 0000: TRGO is selected - 0001: OLDx event is selected - 0010: mdf_trg[0] is selected ... - 1111: mdf_trg[13] is selected This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $10 constant MDF1_SNPSFMT                   \ [0x10] Snapshot data format Set and cleared by software. This field is used to select the data format for the snapshot mode. - 0: The integrator counter (INT_CNT) is not inserted into the MDF_SNPSxDR register, leaving a data resolution of 23 bits. - 1: The integrator counter (INT_CNT) is inserted at position [15:9] of MDF_SNPSxDR register, leaving a data resolution of 16 bits. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $14 constant MDF1_NBDIS                     \ [0x14 : 8] Number of samples to be discarded Set and cleared by software. This field is used to define the number of samples to be discarded every time the DFLTx is re-started. - 0: no sample discarded - 1: 1 sample discarded - 2: 2 samples discarded ... - 255: 255 samples discarded This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1e constant MDF1_DFLTRUN                   \ [0x1e] Digital filter Run Status Flag Set and cleared by hardware. This bit indicates if the digital filter is running or not. - 0: The digital filter is not running, and ready to accept a new trigger event - 1: The digital filter is running
    $1f constant MDF1_DFLTACTIVE                \ [0x1f] Digital filter Active Flag Set and cleared by hardware. This bit indicates if the digital filter is active: can be running or waiting for events. - 0: The digital filter is not active, and can be re-enabled again (via DFLTEN bit) if needed - 1: The digital filter is active
  [then]


  [ifdef] MDF1_MDF_DFLT5CICR_DEF
    \
    \ @brief This register is used to control the main CIC filter.
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DATSRC                    \ [0x00 : 2] Source data for the digital filter Set and cleared by software. 0x: Select the stream coming from the BSMX - 10: Select the stream coming from the ADCITF1 - 11: Select the stream coming from the ADCITF2 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_CICMOD                    \ [0x04 : 3] Select the CIC mode Set and cleared by software. This field allows the application to select the configuration and the order of the MCIC. When CICMOD[2:0] is equal to 0xx , the CIC is split into two filters: - The main CIC (MCIC) - The auxiliary CIC (ACIC), used for the out-off limit detector - 000: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in FastSinc filter - 001: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in Sinc1 filter - 010: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in Sinc2 filter - 011: The CIC is split into 2 filters, and the main CIC (MCIC) is configured in Sinc3 filter - 100: The CIC is configured in single sinc4 filter others: The CIC is configured in single sinc5 filter This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_MCICD                     \ [0x08 : 9] CIC decimation ratio selection Set and cleared by software. This bit is used to allow the application to select the decimation ratio of the CIC. Decimation ratio smaller than 2 is not allowed. The decimation ratio is given by (CICDEC+1). - 0: Decimation ratio is 2 - 1: Decimation ratio is 2 - 2: Decimation ratio is 3 - 3: Decimation ratio is 4 ... - 511: Decimation ratio is 512 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $14 constant MDF1_SCALE                     \ [0x14 : 6] Scaling factor selection Set and cleared by software. This field is used to allow the application to select the gain to be applied at CIC output. Please refer to Table 13: Possible gain values for details. If the application attempts to write a new gain value while the previous one is not yet applied, this new gain value is ignored. Reading back the SCALE[5:0] field will inform the application on the current gain value. - 100000: - 48.2 dB, or shift right by 8 bits (default value) - 100001: - 44.6 dB, - 100010: - 42.1 dB, or shift right by 7 bits - 100011: - 38.6 dB, ... - 101110: -6 dB, or shift right by 1 bit - 101111: -2.5 dB, - 000000: 0 dB - 000001: + 3.5 dB, - 000010: + 6 dB, or shift left by 1 bit ... - 011000: + 72 dB, or shift left by 12 bits
  [then]


  [ifdef] MDF1_MDF_DFLT5RSFR_DEF
    \
    \ @brief This register is used to control the reshape and HPF filters.
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_RSFLTBYP                  \ [0x00] Reshaper filter bypass Set and cleared by software. This bit is used to bypass the reshape filter and its decimation block. - 0: The reshape filter is not bypassed (Default value) - 1: The reshape filter is bypassed This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_RSFLTD                    \ [0x04] Reshaper filter decimation ratio Set and cleared by software. This bit is used to select the decimation ratio for the reshape filter - 0: Decimation ratio is 4 (Default value) - 1: Decimation ratio is 1 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $07 constant MDF1_HPFBYP                    \ [0x07] High-Pass Filter bypass Set and cleared by software. This bit is used to bypass the high-pass filter. - 0: The high pass filter is not bypassed (Default value) - 1: The high pass filter is bypassed This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $08 constant MDF1_HPFC                      \ [0x08 : 2] High-pass filter cut-off frequency Set and cleared by software. This field is used to select the cut-off frequency of the high-pass filter. FPCM represents the sampling frequency at HPF input. - 00: Cut-off frequency = 0.000625 x FPCM - 01: Cut-off frequency = 0.00125 x FPCM - 10: Cut-off frequency = 0.00250 x FPCM - 11: Cut-off frequency = 0.00950 x FPCM This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
  [then]


  [ifdef] MDF1_MDF_DFLT5INTR_DEF
    \
    \ @brief This register is used to the integrator (INT) settings.
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_INTDIV                    \ [0x00 : 2] Integrator output division Set and cleared by software. This bit is used to rescale the signal at the integrator output in order keep the data width lower than 24 bits. - 00: The integrator data outputs are divided by 128 (Default value) - 01: The integrator data outputs are divided by 32 - 10: The integrator data outputs are divided by 4 - 11: The integrator data outputs are not divided This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_INTVAL                    \ [0x04 : 7] Integration value selection Set and cleared by software. This field is used to select the integration value. - 0: The integration value is 1, meaning bypass mode (default after reset) - 1: The integration value is 2 - 2: The integration value is 3 ... - 127: The integration value is 128 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
  [then]


  [ifdef] MDF1_MDF_OLD5CR_DEF
    \
    \ @brief This register is used to configure the Out-of Limit Detector function.
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDEN                     \ [0x00] Over-Current Detector Enable Set and cleared by software. - 0: The OLD is disabled (Default value) - 1: The OLD is enabled, including the ACIC filter working in continuous mode.
    $01 constant MDF1_THINB                     \ [0x01] Threshold In band Set and cleared by software. - 0: The OLD generates an event if the signal is lower than OLDTHL OR higher than OLDTHH (Default value) - 1: The OLD generates an event if the signal is lower than OLDTHH AND higher than OLDTHL This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $04 constant MDF1_BKOLD                     \ [0x04 : 4] Break signal assignment for out-of limit detector Set and cleared by software. BKOLD[i] = 0: Break signal (mdf_break[i]) is not assigned to threshold event BKOLD[i] = 1: Break signal (mdf_break[i]) is assigned to threshold event This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $0c constant MDF1_ACICN                     \ [0x0c : 2] OLD CIC order selection Set and cleared by software. This field allows the application to select the type, and the order of the ACIC. This field is only taken into account by the MDF when CICMOD[2:0] = 0xx . - 00: FastSinc filter type - 01: Sinc1 filter type - 10: Sinc2 filter type - 11: Sinc3 filter type This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $11 constant MDF1_ACICD                     \ [0x11 : 5] OLD CIC decimation ratio selection Set and cleared by software. This field is used to allow the application to select the decimation ratio of the ACIC. This field is only taken into account by the MDF when CICMOD[2:0] = 0xx . The decimation ratio is given by (ACICD+1). - 0: Decimation ratio is 1 - 1: Decimation ratio is 2 - 2: Decimation ratio is 3 - 3: Decimation ratio is 4 ... - 31: Decimation ratio is 32 This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_OLDACTIVE                 \ [0x1f] OLD Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the OLD is effectively enabled (active) or not. The protected fields and registers of this function can only be updated when the OLDACTIVE is set to , please refer to Section 1.4.15: Register protection for details. The delay between a transition on OLDEN and a transition on OLDACTIVE is 2 periods of AHB clock and 2 periods of mdf_proc_ck. - 0: The OLD is not active, and can be configured if needed - 1: The OLD is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_OLD5THLR_DEF
    \
    \ @brief This register is used for the adjustment of the Out-off Limit low threshold.
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHL                    \ [0x00 : 26] OLD Low Threshold Value Set and cleared by software. OLDTHL represents a 26-bit signed value. The real threshold compared to the signal provided by the filter is OLDTHL. This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
  [then]


  [ifdef] MDF1_MDF_OLD5THHR_DEF
    \
    \ @brief This register is used for the adjustment of the Out-off Limit high threshold.
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHH                    \ [0x00 : 26] OLD High Threshold Value Set and cleared by software. OLDTHH represents a 26-bit signed value. The real threshold compared to the signal provided by the filter is OLDTHH. This field can be write-protected, please refer to Section 1.4.15: Register protection for details
  [then]


  [ifdef] MDF1_MDF_DLY5CR_DEF
    \
    \ @brief This register is used for the adjustment stream delays.
    \ Address offset: 0x324
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SKPDLY                    \ [0x00 : 7] Delay to apply to a bitstream Set and cleared by software. Defines the number of input samples that will be skipped. Skipping is applied immediately after writing to this field, if SKPBF = 0 , and the corresponding bit DFLTEN = 1 . If SKPBF = 1 the value written into the register is ignored by the delay state machine. - 0: No input sample skipped, - 1: 1 input sample skipped, ... - 127: 127 input sample skipped,
    $1f constant MDF1_SKPBF                     \ [0x1f] Skip Busy flag Set and cleared by hardware. Shall be used in order to control if the delay sequence is completed. - 0: Reading 0 means that the MDF is ready to accept a new value into SKPDLY[6:0]. - 1: Reading 1 means that last valid SKPDLY[6:0] is still under precessing.
  [then]


  [ifdef] MDF1_MDF_SCD5CR_DEF
    \
    \ @brief This register is used for the adjustment stream delays.
    \ Address offset: 0x328
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SCDEN                     \ [0x00] Short circuit detector enable Set and cleared by software. - 0: The short circuit detector is disabled, - 1: The short circuit detector is enabled,
    $04 constant MDF1_BKSCD                     \ [0x04 : 4] Break signal assignment for short circuit detector Set and cleared by software. BKSCD[i] = 0: Break signal (mdf_break[i]) is not assigned to this SCD event BKSCD[i] = 1: Break signal (mdf_break[i]) is assigned to this SCD event This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $0c constant MDF1_SCDT                      \ [0x0c : 8] Short-circuit detector threshold Set and cleared by software. These bits are written by software to define the threshold counter for the short-circuit detector. If this value is reached, then a short-circuit detector event occurs on a given input stream. - 0: 2 consecutive 1 s or 0 s will generate an event, - 1: 2 consecutive 1 s or 0 s will generate an event - 2: 3 consecutive 1 s or 0 s will generate an event, ... - 255: 256 consecutive 1 s or 0 s will generate an event, This field can be write-protected, please refer to Section 1.4.15: Register protection for details.
    $1f constant MDF1_SCDACTIVE                 \ [0x1f] SCD Active flag Set and cleared by hardware. This flag must be used by the application in order to check if the SCD is effectively enabled (active) or not. The protected fields of this function can only be updated when the SCDACTIVE is set to a a , please refer to Section 1.4.15: Register protection for details. The delay between a transition on SCDEN and a transition on SCDACTIVE is 2 periods of AHB clock and 2 periods of mdf_proc_ck. - 0: The SCD is not active, and can be configured if needed - 1: The SCD is active, and protected fields cannot be configured.
  [then]


  [ifdef] MDF1_MDF_DFLT5IER_DEF
    \
    \ @brief MDF DFLTx interrupt enable register x
    \ Address offset: 0x32C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHIE                     \ [0x00] RXFIFO threshold interrupt enable Set and cleared by software. - 0: RXFIFO threshold interrupt disabled - 1: RXFIFO threshold interrupt enabled
    $01 constant MDF1_DOVRIE                    \ [0x01] Data overflow interrupt enable Set and cleared by software. - 0: Data overflow interrupt disabled - 1: Data overflow interrupt enabled
    $02 constant MDF1_SSDRIE                    \ [0x02] Snapshot data ready interrupt enable Set and cleared by software. - 0: Snapshot data ready interrupt disabled - 1: Snapshot data ready interrupt enabled
    $04 constant MDF1_OLDIE                     \ [0x04] Out-of Limit interrupt enable Set and cleared by software. - 0: OLD event interrupt disabled - 1: OLD event interrupt enabled
    $07 constant MDF1_SSOVRIE                   \ [0x07] Snapshot overrun interrupt enable Set and cleared by software. - 0: Snapshot overrun interrupt disabled - 1: Snapshot overrun interrupt enabled
    $08 constant MDF1_SCDIE                     \ [0x08] Short-Circuit Detector interrupt enable Set and cleared by software. - 0: SCD interrupt disabled - 1: SCD interrupt enabled
    $09 constant MDF1_SATIE                     \ [0x09] Saturation detection interrupt enable Set and cleared by software. - 0: Saturation interrupt disabled - 1: Saturation interrupt enabled
    $0a constant MDF1_CKABIE                    \ [0x0a] Clock absence detection interrupt enable Set and cleared by software. - 0: Clock absence interrupt disabled - 1: Clock absence interrupt enabled
    $0b constant MDF1_RFOVRIE                   \ [0x0b] Reshape Filter Overrun interrupt enable Set and cleared by software. - 0: Reshape filter overrun interrupt disabled - 1: Reshape filter overrun interrupt enabled
  [then]


  [ifdef] MDF1_MDF_DFLT5ISR_DEF
    \
    \ @brief This register contains the status flags for each digital filter path.
    \ Address offset: 0x330
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHF                      \ [0x00] RXFIFO threshold flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that the RXFIFO threshold is not reached, writing 0 has no effect. - 1: Reading 1 means that the RXFIFO reached the threshold, writing 1 clears this flag.
    $01 constant MDF1_DOVRF                     \ [0x01] Data overflow flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no overflow is detected, writing 0 has no effect. - 1: Reading 1 means that an overflow is detected, writing 1 clears this flag.
    $02 constant MDF1_SSDRF                     \ [0x02] Snapshot data ready flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no data is available on MDF_SNPSxDR, writing 0 has no effect. - 1: Reading 1 means that a new data is available on MDF_SNPSxDR, writing 1 clears this flag.
    $03 constant MDF1_RXNEF                     \ [0x03] RXFIFO Not Empty flag Set and cleared by hardware according to the RXFIFO level. - 0: Reading 0 means that the RXFIFO is empty. - 1: Reading 1 means that the RXFIFO is not empty.
    $04 constant MDF1_OLDF                      \ [0x04] Out-of Limit Detector flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no OLD event is detected, writing 0 has no effect. - 1: Reading 1 means that an OLD event is detected, writing 1 clears THHF, THLF and OLDF flags.
    $05 constant MDF1_THLF                      \ [0x05] Low threshold status flag Set by hardware, and cleared by software by writing OLDF bit to 1 . This flag indicates the status of the low threshold comparator when the last OLD event occurred. This bit gives additional information on the conditions triggering the last OLD event. It can be cleared by writing OLDF flag to a 1. - 0: The signal was lower than OLDTHL, when the last OLD event occurred - 1: The signal was higher than OLDTHL, when the last OLD event occurred
    $06 constant MDF1_THHF                      \ [0x06] High threshold status flag Set by hardware, and cleared by software by writing OLDF bit to 1 . This flag indicates the status of the high threshold comparator when the last OLD event occurred. This bit gives additional information on the conditions triggering the last OLD event. It can be cleared by writing OLDF flag to a 1. - 0: The signal was lower than OLDTHH, when the last OLD event occurred - 1: The signal was higher than OLDTHH, when the last OLD event occurred
    $07 constant MDF1_SSOVRF                    \ [0x07] Snapshot overrun flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no snapshot overrun event is detected, writing 0 has no effect. - 1: Reading 1 means that a snapshot overrun event is detected, writing 1 clears this flag.
    $08 constant MDF1_SCDF                      \ [0x08] Short-Circuit Detector flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no SCD event is detected, writing 0 has no effect. - 1: Reading 1 means that a SCD event is detected, writing 1 clears this flag.
    $09 constant MDF1_SATF                      \ [0x09] Saturation detection flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no saturation is detected, writing 0 has no effect. - 1: Reading 1 means that a saturation is detected, writing 1 clears this flag.
    $0a constant MDF1_CKABF                     \ [0x0a] Clock absence detection flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no clock absence is detected, writing 0 has no effect. - 1: Reading 1 means that a clock absence is detected, writing 1 clears this flag.
    $0b constant MDF1_RFOVRF                    \ [0x0b] Reshape Filter Overrun detection flag Set by hardware, and cleared by software by writing this bit to 1 . - 0: Reading 0 means that no reshape filter overrun is detected, writing 0 has no effect. - 1: Reading 1 means that reshape filter overrun is detected, writing 1 clears this flag.
  [then]


  [ifdef] MDF1_MDF_OEC5CR_DEF
    \
    \ @brief This register contains the offset compensation value.
    \ Address offset: 0x334
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OFFSET                    \ [0x00 : 26] Offset error compensation Set and cleared by software. If the application attempts to write a new offset value while the previous one is not yet applied, this new offset value is ignored. Reading back the OFFSET[25:0] field will inform the application on the current offset value. OFFSET[25:0] represents the value to be subtracted to the signal before going to the SCALE.
  [then]


  [ifdef] MDF1_MDF_SNPS5DR_DEF
    \
    \ @brief This register is used to read the data processed by each digital filter in snapshot mode.
    \ Address offset: 0x36C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_MCICDC                    \ [0x00 : 9] Contains the MCIC decimation counter value at the moment of the last trigger event occurs (MCIC_CNT)
    $09 constant MDF1_EXTSDR                    \ [0x09 : 7] Extended data size If SNPSFMT = 0 , EXTSDR[6:0] contains the bit 7 to 1 of the last valid data processed by the digital filter, If SNPSFMT = 1 , this field contains the INT accumulator counter value at the moment of the last trigger event occurs (INT_CNT).
    $10 constant MDF1_SDR                       \ [0x10 : 16] Contains the 16 MSB of the last valid data processed by the digital filter.
  [then]


  [ifdef] MDF1_MDF_DFLT5DR_DEF
    \
    \ @brief This register is used to read the data processed by each digital filter.
    \ Address offset: 0x370
    \ Reset value: 0x00000000
    \
    $08 constant MDF1_DR                        \ [0x08 : 24] Data processed by digital filter.
  [then]

  \
  \ @brief Multi-function digital filter
  \
  $00 constant MDF1_GCR                 \ MDF global control register
  $04 constant MDF1_CKGCR               \ MDF clock generator control register
  $80 constant MDF1_MDF_SITF0CR         \ This register is used to control the serial interfaces (SITFx).
  $84 constant MDF1_MDF_BSMX0CR         \ This register is used to select the bitstream to be provided to the corresponding digital filter and to the SCD.
  $88 constant MDF1_MDF_DFLT0CR         \ This register is used to control the digital filter x.
  $8C constant MDF1_MDF_DFLT0CICR       \ This register is used to control the main CIC filter.
  $90 constant MDF1_MDF_DFLT0RSFR       \ This register is used to control the reshape and HPF filters.
  $94 constant MDF1_MDF_DFLT0INTR       \ This register is used to the integrator (INT) settings.
  $98 constant MDF1_MDF_OLD0CR          \ This register is used to configure the Out-of Limit Detector function.
  $9C constant MDF1_MDF_OLD0THLR        \ This register is used for the adjustment of the Out-off Limit low threshold.
  $A0 constant MDF1_MDF_OLD0THHR        \ This register is used for the adjustment of the Out-off Limit high threshold.
  $A4 constant MDF1_MDF_DLY0CR          \ This register is used for the adjustment stream delays.
  $A8 constant MDF1_MDF_SCD0CR          \ This register is used for the adjustment stream delays.
  $AC constant MDF1_MDF_DFLT0IER        \ This register is used for allowing or not the events to generate an interrupt.
  $B0 constant MDF1_MDF_DFLT0ISR        \ MDF DFLT0 interrupt status register 0
  $B4 constant MDF1_MDF_OEC0CR          \ This register contains the offset compensation value.
  $EC constant MDF1_MDF_SNPS0DR         \ This register is used to read the data processed by each digital filter in snapshot mode.
  $F0 constant MDF1_MDF_DFLT0DR         \ This register is used to read the data processed by each digital filter.
  $100 constant MDF1_MDF_SITF1CR        \ This register is used to control the serial interfaces (SITFx).
  $104 constant MDF1_MDF_BSMX1CR        \ This register is used to select the bitstream to be provided to the corresponding digital filter and to the SCD.
  $108 constant MDF1_MDF_DFLT1CR        \ This register is used to control the digital filter x.
  $10C constant MDF1_MDF_DFLT1CICR      \ This register is used to control the main CIC filter.
  $110 constant MDF1_MDF_DFLT1RSFR      \ This register is used to control the reshape and HPF filters.
  $114 constant MDF1_MDF_DFLT1INTR      \ This register is used to the integrator (INT) settings.
  $118 constant MDF1_MDF_OLD1CR         \ This register is used to configure the Out-of Limit Detector function.
  $11C constant MDF1_MDF_OLD1THLR       \ This register is used for the adjustment of the Out-off Limit low threshold.
  $120 constant MDF1_MDF_OLD1THHR       \ This register is used for the adjustment of the Out-off Limit high threshold.
  $124 constant MDF1_MDF_DLY1CR         \ This register is used for the adjustment stream delays.
  $128 constant MDF1_MDF_SCD1CR         \ This register is used for the adjustment stream delays.
  $12C constant MDF1_MDF_DFLT1IER       \ MDF DFLTx interrupt enable register x
  $130 constant MDF1_MDF_DFLT1ISR       \ This register contains the status flags for each digital filter path.
  $134 constant MDF1_MDF_OEC1CR         \ This register contains the offset compensation value.
  $16C constant MDF1_MDF_SNPS1DR        \ This register is used to read the data processed by each digital filter in snapshot mode.
  $170 constant MDF1_MDF_DFLT1DR        \ This register is used to read the data processed by each digital filter.
  $180 constant MDF1_MDF_SITF2CR        \ This register is used to control the serial interfaces (SITFx).
  $184 constant MDF1_MDF_BSMX2CR        \ This register is used to select the bitstream to be provided to the corresponding digital filter and to the SCD.
  $188 constant MDF1_MDF_DFLT2CR        \ This register is used to control the digital filter 2.
  $18C constant MDF1_MDF_DFLT2CICR      \ This register is used to control the main CIC filter.
  $190 constant MDF1_MDF_DFLT2RSFR      \ This register is used to control the reshape and HPF filters.
  $194 constant MDF1_MDF_DFLT2INTR      \ This register is used to the integrator (INT) settings.
  $198 constant MDF1_MDF_OLD2CR         \ This register is used to configure the Out-of Limit Detector function.
  $19C constant MDF1_MDF_OLD2THLR       \ This register is used for the adjustment of the Out-off Limit low threshold.
  $1A0 constant MDF1_MDF_OLD2THHR       \ This register is used for the adjustment of the Out-off Limit high threshold.
  $1A4 constant MDF1_MDF_DLY2CR         \ This register is used for the adjustment stream delays.
  $1A8 constant MDF1_MDF_SCD2CR         \ This register is used for the adjustment stream delays.
  $1AC constant MDF1_MDF_DFLT2IER       \ MDF DFLTx interrupt enable register x
  $1B0 constant MDF1_MDF_DFLT2ISR       \ This register contains the status flags for each digital filter path.
  $1B4 constant MDF1_MDF_OEC2CR         \ This register contains the offset compensation value.
  $1EC constant MDF1_MDF_SNPS2DR        \ This register is used to read the data processed by each digital filter in snapshot mode.
  $1F0 constant MDF1_MDF_DFLT2DR        \ This register is used to read the data processed by each digital filter.
  $200 constant MDF1_MDF_SITF3CR        \ This register is used to control the serial interfaces (SITFx).
  $204 constant MDF1_MDF_BSMX3CR        \ This register is used to select the bitstream to be provided to the corresponding digital filter and to the SCD.
  $208 constant MDF1_MDF_DFLT3CR        \ This register is used to control the digital filter 3.
  $20C constant MDF1_MDF_DFLT3CICR      \ This register is used to control the main CIC filter.
  $210 constant MDF1_MDF_DFLT3RSFR      \ This register is used to control the reshape and HPF filters.
  $214 constant MDF1_MDF_DFLT3INTR      \ This register is used to the integrator (INT) settings.
  $218 constant MDF1_MDF_OLD3CR         \ This register is used to configure the Out-of Limit Detector function.
  $21C constant MDF1_MDF_OLD3THLR       \ This register is used for the adjustment of the Out-off Limit low threshold.
  $220 constant MDF1_MDF_OLD3THHR       \ This register is used for the adjustment of the Out-off Limit high threshold.
  $224 constant MDF1_MDF_DLY3CR         \ This register is used for the adjustment stream delays.
  $228 constant MDF1_MDF_SCD3CR         \ This register is used for the adjustment stream delays.
  $22C constant MDF1_MDF_DFLT3IER       \ MDF DFLTx interrupt enable register x
  $230 constant MDF1_MDF_DFLT3ISR       \ This register contains the status flags for each digital filter path.
  $234 constant MDF1_MDF_OEC3CR         \ This register contains the offset compensation value.
  $26C constant MDF1_MDF_SNPS3DR        \ This register is used to read the data processed by each digital filter in snapshot mode.
  $270 constant MDF1_MDF_DFLT3DR        \ This register is used to read the data processed by each digital filter.
  $280 constant MDF1_MDF_SITF4CR        \ This register is used to control the serial interfaces (SITFx).
  $284 constant MDF1_MDF_BSMX4CR        \ This register is used to select the bitstream to be provided to the corresponding digital filter and to the SCD.
  $288 constant MDF1_MDF_DFLT4CR        \ This register is used to control the digital filter 4.
  $28C constant MDF1_MDF_DFLT4CICR      \ This register is used to control the main CIC filter.
  $290 constant MDF1_MDF_DFLT4RSFR      \ This register is used to control the reshape and HPF filters.
  $294 constant MDF1_MDF_DFLT4INTR      \ This register is used to the integrator (INT) settings.
  $298 constant MDF1_MDF_OLD4CR         \ This register is used to configure the Out-of Limit Detector function.
  $29C constant MDF1_MDF_OLD4THLR       \ This register is used for the adjustment of the Out-off Limit low threshold.
  $2A0 constant MDF1_MDF_OLD4THHR       \ This register is used for the adjustment of the Out-off Limit high threshold.
  $2A4 constant MDF1_MDF_DLY4CR         \ This register is used for the adjustment stream delays.
  $2A8 constant MDF1_MDF_SCD4CR         \ This register is used for the adjustment stream delays.
  $2AC constant MDF1_MDF_DFLT4IER       \ MDF DFLTx interrupt enable register x
  $2B0 constant MDF1_MDF_DFLT4ISR       \ This register contains the status flags for each digital filter path.
  $2B4 constant MDF1_MDF_OEC4CR         \ This register contains the offset compensation value.
  $2EC constant MDF1_MDF_SNPS4DR        \ This register is used to read the data processed by each digital filter in snapshot mode.
  $2F0 constant MDF1_MDF_DFLT4DR        \ This register is used to read the data processed by each digital filter.
  $300 constant MDF1_MDF_SITF5CR        \ This register is used to control the serial interfaces (SITFx).
  $304 constant MDF1_MDF_BSMX5CR        \ This register is used to select the bitstream to be provided to the corresponding digital filter and to the SCD.
  $308 constant MDF1_MDF_DFLT5CR        \ This register is used to control the digital filter x.
  $30C constant MDF1_MDF_DFLT5CICR      \ This register is used to control the main CIC filter.
  $310 constant MDF1_MDF_DFLT5RSFR      \ This register is used to control the reshape and HPF filters.
  $314 constant MDF1_MDF_DFLT5INTR      \ This register is used to the integrator (INT) settings.
  $318 constant MDF1_MDF_OLD5CR         \ This register is used to configure the Out-of Limit Detector function.
  $31C constant MDF1_MDF_OLD5THLR       \ This register is used for the adjustment of the Out-off Limit low threshold.
  $320 constant MDF1_MDF_OLD5THHR       \ This register is used for the adjustment of the Out-off Limit high threshold.
  $324 constant MDF1_MDF_DLY5CR         \ This register is used for the adjustment stream delays.
  $328 constant MDF1_MDF_SCD5CR         \ This register is used for the adjustment stream delays.
  $32C constant MDF1_MDF_DFLT5IER       \ MDF DFLTx interrupt enable register x
  $330 constant MDF1_MDF_DFLT5ISR       \ This register contains the status flags for each digital filter path.
  $334 constant MDF1_MDF_OEC5CR         \ This register contains the offset compensation value.
  $36C constant MDF1_MDF_SNPS5DR        \ This register is used to read the data processed by each digital filter in snapshot mode.
  $370 constant MDF1_MDF_DFLT5DR        \ This register is used to read the data processed by each digital filter.

: MDF1_DEF ; [then]
