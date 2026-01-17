\
\ @file adf.fs
\ @brief Audio digital filter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADF_DEF

  [ifdef] ADF_ADF_GCR_DEF
    \
    \ @brief ADF global control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADF_TRGO                       \ [0x00] Trigger output control This bit is set by software and reset by hardware. It is used to start the acquisition of several filters synchronously. It is also used to synchronize several ADF together by controlling the adf_trgo signal.
  [then]


  [ifdef] ADF_ADF_CKGCR_DEF
    \
    \ @brief ADF clock generator control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ADF_CKGDEN                     \ [0x00] CKGEN dividers enable This bit is set and reset by software. It is used to enable/disable the clock dividers of the CKGEN: PROCDIV and CCKDIV.
    $01 constant ADF_CCK0EN                     \ [0x01] ADF_CCK0 clock enable This bit is set and reset by software. It is used to control the generation of the bitstream clock on the ADF_CCK0 pin.
    $02 constant ADF_CCK1EN                     \ [0x02] ADF_CCK1 clock enable This bit is set and reset by software. It is used to control the generation of the bitstream clock on the ADF_CCK1 pin.
    $04 constant ADF_CKGMOD                     \ [0x04] Clock generator mode This bit is set and reset by software. It is used to define the way the clock generator is enabled. This bit must not be changed if the filter is enabled (DFTEN = 1). Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
    $05 constant ADF_CCK0DIR                    \ [0x05] ADF_CCK0 direction This bit is set and reset by software. It is used to control the direction of the ADF_CCK0 pin. Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
    $06 constant ADF_CCK1DIR                    \ [0x06] ADF_CCK1 direction This bit is set and reset by software. It is used to control the direction of the ADF_CCK1 pin. Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
    $08 constant ADF_TRGSENS                    \ [0x08] CKGEN trigger sensitivity selection This bit is set and cleared by software. It is used to select the trigger sensitivity of the trigger signals. This bit is not significant if the CKGMOD = 0. Note: When the trigger source is TRGO, the sensitivity is forced to falling edge, thus TRGSENS value is not taken into account. This bit can be write-protected (see Section 46.4.13: Register protection for details).
    $0c constant ADF_TRGSRC                     \ [0x0c : 4] Digital filter trigger signal selection This field is set and cleared by software. It is used to select which external signals trigger the corresponding filter. This field is not significant if the CKGMOD = 0. 000x: TRGO selected others: reserved Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
    $10 constant ADF_CCKDIV                     \ [0x10 : 4] Divider to control the ADF_CCK clock This field is set and reset by software. It is used to adjust the frequency of the ADF_CCK clock. The input clock of this divider is the clock provided to the SITF. More globally, the frequency of the ADF_CCK is given by the following formula: This field must not be changed if the filter is enabled (DFTEN = 1). ... Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
    $18 constant ADF_PROCDIV                    \ [0x18 : 7] Divider to control the serial interface clock this field is set and reset by software. It is used to adjust the frequency of the clock provided to the SITF. This field must not be changed if the filter is enabled (DFTEN = 1). ... Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
    $1f constant ADF_CKGACTIVE                  \ [0x1f] Clock generator active flag This bit is set and cleared by hardware. Ii is used by the application to check if the clock generator is effectively enabled (active) or not. The protected fields of this function can only be updated when CKGACTIVE = 0 (see Section 46.4.13: Register protection for details). The delay between a transition on CKGDEN and a transition on CKGACTIVE is two periods of AHB clock and two 2 periods of adf_proc_ck.
  [then]


  [ifdef] ADF_ADF_SITF0CR_DEF
    \
    \ @brief ADF serial interface control register 0
    \ Address offset: 0x80
    \ Reset value: 0x00001F00
    \
    $00 constant ADF_SITFEN                     \ [0x00] Serial interface enable This bit is set and cleared by software. It is used to enable/disable the serial interface.
    $01 constant ADF_SCKSRC                     \ [0x01 : 2] Serial clock source This field is set and cleared by software. It is used to select the clock source of the serial interface. others: reserved Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
    $04 constant ADF_SITFMOD                    \ [0x04 : 2] Serial interface type This field is set and cleared by software. It is used to define the serial interface type. Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
    $08 constant ADF_STH                        \ [0x08 : 5] Manchester symbol threshold/SPI threshold This field is set and cleared by software. It is used for Manchester mode to define the expected symbol threshold levels (seer to Manchester mode for details on computation). In addition this field is used to define the timeout value for the clock absence detection in Normal SPI mode. STH[4:0] values lower than four are invalid. Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
    $1f constant ADF_SITFACTIVE                 \ [0x1f] Serial interface active flag This bit is set and cleared by hardware. It is used by the application to check if the serial interface is effectively enabled (active) or not. The protected fields of this function can only be updated when SITFACTIVE is set to 0 (see Section 46.4.13: Register protection for details). The delay between a transition on SITFEN and a transition on SITFACTIVE is two periods of AHB clock and two periods of adf_proc_ck.
  [then]


  [ifdef] ADF_ADF_BSMX0CR_DEF
    \
    \ @brief ADF bitstream matrix control register 0
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant ADF_BSSEL                      \ [0x00 : 5] Bitstream selection This field is set and cleared by software. It is used to select the bitstream to be processed for DFLT0. others: reserved Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
    $1f constant ADF_BSMXACTIVE                 \ [0x1f] BSMX active flag This bit is set and cleared by hardware. It is used by the application to check if the BSMX is effectively enabled (active) or not. BSSEL[4:0] can only be updated when BSMXACTIVE is set to 0. This BSMXACTIVE flag cannot go to 0 if DFLT0 is enabled.
  [then]


  [ifdef] ADF_ADF_DFLT0CR_DEF
    \
    \ @brief ADF digital filter control register 0
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant ADF_DFLTEN                     \ [0x00] DFLT0 enable This bit is set and cleared by software. It is used to control the start of acquisition of the DFLT0 path. This bit behavior depends on ACQMOD[2:0] and external events. The serial or parallel interface delivering the samples must be enabled as well.
    $01 constant ADF_DMAEN                      \ [0x01] DMA requests enable This bit is set and cleared by software. It is used to control the generation of DMA request to transfer the processed samples into the memory. Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
    $02 constant ADF_FTH                        \ [0x02] RXFIFO threshold selection This bit is set and cleared by software. It is used to select the RXFIFO threshold. Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
    $04 constant ADF_ACQMOD                     \ [0x04 : 3] DFLT0 trigger mode This field is set and cleared by software. It is used to select the filter trigger mode. others: same as 000 Note: This field can be write-protected (see Section 46.4.13: Register protection for details)..
    $08 constant ADF_TRGSENS                    \ [0x08] DFLT0 trigger sensitivity selection This field is set and cleared by software. It is used to select the trigger sensitivity of the external signals When the trigger source is TRGO, TRGSENS value is not taken into account. When TRGO is selected, the sensitivity is forced to falling edge. Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
    $0c constant ADF_TRGSRC                     \ [0x0c : 4] DFLT0 trigger signal selection This field is set and cleared by software. It is used to select which external signals trigger DFLT0. others: Reserved Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
    $14 constant ADF_NBDIS                      \ [0x14 : 8] Number of samples to be discarded This field is set and cleared by software. It is used to define the number of samples to be discarded every time DFLT0 is re-started. ... Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
    $1e constant ADF_DFLTRUN                    \ [0x1e] DFLT0 run status flag This bit is set and cleared by hardware. It indicates if DFLT0 is running or not.
    $1f constant ADF_DFLTACTIVE                 \ [0x1f] DFLT0 active flag This bit is set and cleared by hardware. It indicates if DFLT0 is active: can be running or waiting for events.
  [then]


  [ifdef] ADF_ADF_DFLT0CICR_DEF
    \
    \ @brief ADF digital filer configuration register 0
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant ADF_DATSRC                     \ [0x00 : 2] Source data for the digital filter This field is set and cleared by software. 0x: Stream coming from the BSMX selected Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
    $04 constant ADF_CICMOD                     \ [0x04 : 3] Select the CIC order This field is set and cleared by software. It is used to select the order of the MCIC. others: reserved Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
    $08 constant ADF_MCICD                      \ [0x08 : 8] CIC decimation ratio selection This field is set and cleared by software.It is used to select the CIC decimation ratio. A decimation ratio smaller than two is not allowed. The decimation ratio is given by (CICDEC+1). ... Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
    $10 constant ADF_MCICD8                     \ [0x10] CIC decimation ratio selection This field is set and cleared by software.It is used to select the CIC decimation ratio. A decimation ratio smaller than two is not allowed. The decimation ratio is given by (CICDEC+1). ... Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
    $14 constant ADF_SCALE                      \ [0x14 : 6] Scaling factor selection This field is set and cleared by software. It is used to select the gain to be applied at CIC output (see Table 419 for details). If the application attempts to write a new gain value while the previous one is not yet applied, this new gain value is ignored. Reading back this field informs the application on the current gain value. ... ... others: Reserved
  [then]


  [ifdef] ADF_ADF_DFLT0RSFR_DEF
    \
    \ @brief ADF reshape filter configuration register 0
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant ADF_RSFLTBYP                   \ [0x00] Reshaper filter bypass This bit is set and cleared by software. It is used to bypass the reshape filter and its decimation block. Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
    $04 constant ADF_RSFLTD                     \ [0x04] Reshaper filter decimation ratio This bit is set and cleared by software. It is used to select the decimation ratio for the reshape filter Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
    $07 constant ADF_HPFBYP                     \ [0x07] High-pass filter bypass This bit is set and cleared by software. It is used to bypass the high-pass filter. Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
    $08 constant ADF_HPFC                       \ [0x08 : 2] High-pass filter cut-off frequency This field is set and cleared by software. it is used to select the cut-off frequency of the high-pass filter. F<sub>PCM</sub> represents the sampling frequency at HPF input. Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
  [then]


  [ifdef] ADF_ADF_DLY0CR_DEF
    \
    \ @brief ADF delay control register 0
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant ADF_SKPDLY                     \ [0x00 : 7] Delay to apply to a bitstream This field is set and cleared by software. It defines the number of input samples that are skipped. Skipping is applied immediately after writing to this field, if SKPBF = 0 and DFLTEN = 1. If SKPBF = 1, the value written into the register is ignored by the delay state machine. ...
    $1f constant ADF_SKPBF                      \ [0x1f] Skip busy flag This bit is set and cleared by hardware. It is used to control if the delay sequence is completed.
  [then]


  [ifdef] ADF_ADF_DFLT0IER_DEF
    \
    \ @brief ADF DFLT0 interrupt enable register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant ADF_FTHIE                      \ [0x00] RXFIFO threshold interrupt enable This bit is set and cleared by software.
    $01 constant ADF_DOVRIE                     \ [0x01] Data overflow interrupt enable This bit is set and cleared by software.
    $09 constant ADF_SATIE                      \ [0x09] Saturation detection interrupt enable This bit is set and cleared by software.
    $0a constant ADF_CKABIE                     \ [0x0a] Clock absence detection interrupt enable This bit is set and cleared by software.
    $0b constant ADF_RFOVRIE                    \ [0x0b] Reshape filter overrun interrupt enable This bit is set and cleared by software.
    $0c constant ADF_SDDETIE                    \ [0x0c] Sound activity detection interrupt enable This bit is set and cleared by software.
    $0d constant ADF_SDLVLIE                    \ [0x0d] SAD sound-level value ready enable This bit is set and cleared by software.
  [then]


  [ifdef] ADF_ADF_DFLT0ISR_DEF
    \
    \ @brief ADF DFLT0 interrupt status register 0
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant ADF_FTHF                       \ [0x00] RXFIFO threshold flag This bit is set by hardware, and cleared by the hardware when the RXFIFO level is lower than the threshold.
    $01 constant ADF_DOVRF                      \ [0x01] Data overflow flag This bit is set by hardware and cleared by software by writing this bit to 1.
    $03 constant ADF_RXNEF                      \ [0x03] RXFIFO not empty flag This bit is set and cleared by hardware according to the RXFIFO level.
    $09 constant ADF_SATF                       \ [0x09] Saturation detection flag This bit is set by hardware and cleared by software by writing this bit to 1.
    $0a constant ADF_CKABF                      \ [0x0a] Clock absence detection flag This bit is set by hardware and cleared by software by writing this bit to 1.
    $0b constant ADF_RFOVRF                     \ [0x0b] Reshape filter overrun detection flag This bit is set by hardware and cleared by software by writing this bit to 1.
    $0c constant ADF_SDDETF                     \ [0x0c] Sound activity detection flag This bit is set by hardware and cleared by software by writing this bit to 1.
    $0d constant ADF_SDLVLF                     \ [0x0d] Sound level value ready flag This bit is set by hardware and cleared by software by writing this bit to 1.
  [then]


  [ifdef] ADF_ADF_SADCR_DEF
    \
    \ @brief ADF SAD control register
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant ADF_SADEN                      \ [0x00] Sound activity detector enable This bit is set and cleared by software. It is used to enable/disable the SAD.
    $01 constant ADF_DATCAP                     \ [0x01 : 2] Data capture mode This field is set and cleared by software. It is used to define in which conditions, the samples provided by DLFT0 are stored into the memory. 1x: Samples from DFLT0 transfered into memory when SAD and DFLT0 are enabled Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
    $03 constant ADF_DETCFG                     \ [0x03] Sound trigger event configuration This bit is set and cleared by software. It is used to define if the sddet_evt event is generated only when the SAD enters to MONITOR state or when the SAD enters or exits the DETECT state. Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
    $04 constant ADF_SADST                      \ [0x04 : 2] SAD state This field is set and cleared by hardware. It indicates the SAD state and is meaningful only when SADEN = 1. The SAD state can be: - LEARN when the SAD is in learning phase or in SDLVL computation mode - MONITOR when the SAD is in monitoring phase - DETECT when the SAD detects a sound
    $07 constant ADF_HYSTEN                     \ [0x07] Hysteresis enable This bit is set and cleared by software. It is used to enable/disable the hysteresis function (see Table 419 for details). This bit must be kept to 0 when SADMOD[1:0] = 1x. Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
    $08 constant ADF_FRSIZE                     \ [0x08 : 3] Frame size This field is set and cleared by software. it is used to define the size of one frame and also to define how many samples are taken into account to compute the short-term signal level. 11x: 512 PCM samples used to compute the short-term signal level Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
    $0c constant ADF_SADMOD                     \ [0x0c : 2] SAD working mode This field is set and cleared by software. It is used to define the way the SAD works. The SAD triggers when the sound level (SDLVL) is bigger than the defined threshold. In this mode, the SAD works like a voice activity detector. The SAD triggers when the sound level (SDLVL) is bigger than the defined threshold. In this mode, the SAD works like a sound detector. 1x: Threshold value given by 4 x ANMIN[12:0] The SAD triggers when the estimated ambient noise (ANLVL), multiplied by the gain selected by SNTHR[3:0] is bigger than the defined threshold. In this mode, the SAD is working like an ambient noise estimator. Hysteresis function cannot be used in this mode. Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
    $1f constant ADF_SADACTIVE                  \ [0x1f] SAD Active flag This bit is set and cleared by hardware. It is used to check if the SAD is effectively enabled (active) or not. The protected fields and registers of this function can only be updated when the SADACTIVE is set to 0 (see Section 46.4.13: Register protection for details). The delay between a transition on SADEN and a transition on SADACTIVE is two periods of AHB clock and two periods of adf_proc_ck.
  [then]


  [ifdef] ADF_ADF_SADCFGR_DEF
    \
    \ @brief ADF SAD configuration register
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant ADF_SNTHR                      \ [0x00 : 4] Signal to noise threshold This field is set and cleared by software. It is used to define THR<sub>H </sub>(and THR<sub>L</sub> if hysteresis is enabled). See Table 419 for details. others: Reserved Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
    $04 constant ADF_ANSLP                      \ [0x04 : 3] Ambient noise slope control This field is set and cleared by software. It is used to define the positive and negative slope of the noise estimator, in charge of updating the ANLVL (see Ambient noise estimation (ANLVL) for information about programming this field). Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
    $08 constant ADF_LFRNB                      \ [0x08 : 3] Number of learning frames This field is set and cleared by software. It is used to define the number of learning frames to perform the first estimate of the noise level. 1xx: 32 frames used to compute the initial noise level Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
    $0c constant ADF_HGOVR                      \ [0x0c : 3] Hangover time window This field is set and cleared by software. Once the SAD state is DETECT, this parameter is used to define the amount of time the sound is allowed to remain below the threshold, before switching the SAD to MONITOR state (see FRSIZE field for the description of a frame). Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
    $10 constant ADF_ANMIN                      \ [0x10 : 13] Minimum noise level This field is set and cleared by software. It is used to define the minimum noise level and then the sensitivity. It represents a positive number. Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
  [then]


  [ifdef] ADF_ADF_SADSDLVR_DEF
    \
    \ @brief ADF SAD sound level register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant ADF_SDLVL                      \ [0x00 : 15] Short term sound level This field is set by hardware. It contains the latest sound level computed by the SAD. To refresh this value, SDLVLF must be cleared.
  [then]


  [ifdef] ADF_ADF_SADANLVR_DEF
    \
    \ @brief ADF SAD ambient noise level register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant ADF_ANLVL                      \ [0x00 : 15] Ambient noise level estimation This field is set by hardware. It contains the latest ambient noise level computed by the SAD. To refresh this field, the SDLVLF flag must be cleared.
  [then]


  [ifdef] ADF_ADF_DFLT0DR_DEF
    \
    \ @brief ADF digital filter data register 0
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $08 constant ADF_DR                         \ [0x08 : 24] Data processed by DFT0
  [then]

  \
  \ @brief Audio digital filter
  \
  $00 constant ADF_ADF_GCR              \ ADF global control register
  $04 constant ADF_ADF_CKGCR            \ ADF clock generator control register
  $80 constant ADF_ADF_SITF0CR          \ ADF serial interface control register 0
  $84 constant ADF_ADF_BSMX0CR          \ ADF bitstream matrix control register 0
  $88 constant ADF_ADF_DFLT0CR          \ ADF digital filter control register 0
  $8C constant ADF_ADF_DFLT0CICR        \ ADF digital filer configuration register 0
  $90 constant ADF_ADF_DFLT0RSFR        \ ADF reshape filter configuration register 0
  $A4 constant ADF_ADF_DLY0CR           \ ADF delay control register 0
  $AC constant ADF_ADF_DFLT0IER         \ ADF DFLT0 interrupt enable register
  $B0 constant ADF_ADF_DFLT0ISR         \ ADF DFLT0 interrupt status register 0
  $B8 constant ADF_ADF_SADCR            \ ADF SAD control register
  $BC constant ADF_ADF_SADCFGR          \ ADF SAD configuration register
  $C0 constant ADF_ADF_SADSDLVR         \ ADF SAD sound level register
  $C4 constant ADF_ADF_SADANLVR         \ ADF SAD ambient noise level register
  $F0 constant ADF_ADF_DFLT0DR          \ ADF digital filter data register 0

: ADF_DEF ; [then]
