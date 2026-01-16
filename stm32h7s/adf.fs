\
\ @file adf.fs
\ @brief Audio digital filter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief ADF global control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant ADF_ADF_GCR_TRGO                                 \ Trigger output control This bit is set by software and reset by hardware. It is used to start the acquisition of several filters synchronously. It is also used to synchronize several ADF together by controlling the adf_trgo signal.


\
\ @brief ADF clock generator control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant ADF_ADF_CKGCR_CKGDEN                             \ CKGEN dividers enable This bit is set and reset by software. It is used to enable/disable the clock dividers of the CKGEN: PROCDIV and CCKDIV.
$00000002 constant ADF_ADF_CKGCR_CCK0EN                             \ ADF_CCK0 clock enable This bit is set and reset by software. It is used to control the generation of the bitstream clock on the ADF_CCK0 pin.
$00000004 constant ADF_ADF_CKGCR_CCK1EN                             \ ADF_CCK1 clock enable This bit is set and reset by software. It is used to control the generation of the bitstream clock on the ADF_CCK1 pin.
$00000010 constant ADF_ADF_CKGCR_CKGMOD                             \ Clock generator mode This bit is set and reset by software. It is used to define the way the clock generator is enabled. This bit must not be changed if the filter is enabled (DFTEN = 1). Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
$00000020 constant ADF_ADF_CKGCR_CCK0DIR                            \ ADF_CCK0 direction This bit is set and reset by software. It is used to control the direction of the ADF_CCK0 pin. Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
$00000040 constant ADF_ADF_CKGCR_CCK1DIR                            \ ADF_CCK1 direction This bit is set and reset by software. It is used to control the direction of the ADF_CCK1 pin. Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
$00000100 constant ADF_ADF_CKGCR_TRGSENS                            \ CKGEN trigger sensitivity selection This bit is set and cleared by software. It is used to select the trigger sensitivity of the trigger signals. This bit is not significant if the CKGMOD = 0. Note: When the trigger source is TRGO, the sensitivity is forced to falling edge, thus TRGSENS value is not taken into account. This bit can be write-protected (see Section 46.4.13: Register protection for details).
$0000f000 constant ADF_ADF_CKGCR_TRGSRC                             \ Digital filter trigger signal selection This field is set and cleared by software. It is used to select which external signals trigger the corresponding filter. This field is not significant if the CKGMOD = 0. 000x: TRGO selected others: reserved Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
$000f0000 constant ADF_ADF_CKGCR_CCKDIV                             \ Divider to control the ADF_CCK clock This field is set and reset by software. It is used to adjust the frequency of the ADF_CCK clock. The input clock of this divider is the clock provided to the SITF. More globally, the frequency of the ADF_CCK is given by the following formula: This field must not be changed if the filter is enabled (DFTEN = 1). ... Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
$7f000000 constant ADF_ADF_CKGCR_PROCDIV                            \ Divider to control the serial interface clock this field is set and reset by software. It is used to adjust the frequency of the clock provided to the SITF. This field must not be changed if the filter is enabled (DFTEN = 1). ... Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
$80000000 constant ADF_ADF_CKGCR_CKGACTIVE                          \ Clock generator active flag This bit is set and cleared by hardware. Ii is used by the application to check if the clock generator is effectively enabled (active) or not. The protected fields of this function can only be updated when CKGACTIVE = 0 (see Section 46.4.13: Register protection for details). The delay between a transition on CKGDEN and a transition on CKGACTIVE is two periods of AHB clock and two 2 periods of adf_proc_ck.


\
\ @brief ADF serial interface control register 0
\ Address offset: 0x80
\ Reset value: 0x00001F00
\

$00000001 constant ADF_ADF_SITF0CR_SITFEN                           \ Serial interface enable This bit is set and cleared by software. It is used to enable/disable the serial interface.
$00000006 constant ADF_ADF_SITF0CR_SCKSRC                           \ Serial clock source This field is set and cleared by software. It is used to select the clock source of the serial interface. others: reserved Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
$00000030 constant ADF_ADF_SITF0CR_SITFMOD                          \ Serial interface type This field is set and cleared by software. It is used to define the serial interface type. Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
$00001f00 constant ADF_ADF_SITF0CR_STH                              \ Manchester symbol threshold/SPI threshold This field is set and cleared by software. It is used for Manchester mode to define the expected symbol threshold levels (seer to Manchester mode for details on computation). In addition this field is used to define the timeout value for the clock absence detection in Normal SPI mode. STH[4:0] values lower than four are invalid. Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
$80000000 constant ADF_ADF_SITF0CR_SITFACTIVE                       \ Serial interface active flag This bit is set and cleared by hardware. It is used by the application to check if the serial interface is effectively enabled (active) or not. The protected fields of this function can only be updated when SITFACTIVE is set to 0 (see Section 46.4.13: Register protection for details). The delay between a transition on SITFEN and a transition on SITFACTIVE is two periods of AHB clock and two periods of adf_proc_ck.


\
\ @brief ADF bitstream matrix control register 0
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000001f constant ADF_ADF_BSMX0CR_BSSEL                            \ Bitstream selection This field is set and cleared by software. It is used to select the bitstream to be processed for DFLT0. others: reserved Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
$80000000 constant ADF_ADF_BSMX0CR_BSMXACTIVE                       \ BSMX active flag This bit is set and cleared by hardware. It is used by the application to check if the BSMX is effectively enabled (active) or not. BSSEL[4:0] can only be updated when BSMXACTIVE is set to 0. This BSMXACTIVE flag cannot go to 0 if DFLT0 is enabled.


\
\ @brief ADF digital filter control register 0
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant ADF_ADF_DFLT0CR_DFLTEN                           \ DFLT0 enable This bit is set and cleared by software. It is used to control the start of acquisition of the DFLT0 path. This bit behavior depends on ACQMOD[2:0] and external events. The serial or parallel interface delivering the samples must be enabled as well.
$00000002 constant ADF_ADF_DFLT0CR_DMAEN                            \ DMA requests enable This bit is set and cleared by software. It is used to control the generation of DMA request to transfer the processed samples into the memory. Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
$00000004 constant ADF_ADF_DFLT0CR_FTH                              \ RXFIFO threshold selection This bit is set and cleared by software. It is used to select the RXFIFO threshold. Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
$00000070 constant ADF_ADF_DFLT0CR_ACQMOD                           \ DFLT0 trigger mode This field is set and cleared by software. It is used to select the filter trigger mode. others: same as 000 Note: This field can be write-protected (see Section 46.4.13: Register protection for details)..
$00000100 constant ADF_ADF_DFLT0CR_TRGSENS                          \ DFLT0 trigger sensitivity selection This field is set and cleared by software. It is used to select the trigger sensitivity of the external signals When the trigger source is TRGO, TRGSENS value is not taken into account. When TRGO is selected, the sensitivity is forced to falling edge. Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
$0000f000 constant ADF_ADF_DFLT0CR_TRGSRC                           \ DFLT0 trigger signal selection This field is set and cleared by software. It is used to select which external signals trigger DFLT0. others: Reserved Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
$0ff00000 constant ADF_ADF_DFLT0CR_NBDIS                            \ Number of samples to be discarded This field is set and cleared by software. It is used to define the number of samples to be discarded every time DFLT0 is re-started. ... Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
$40000000 constant ADF_ADF_DFLT0CR_DFLTRUN                          \ DFLT0 run status flag This bit is set and cleared by hardware. It indicates if DFLT0 is running or not.
$80000000 constant ADF_ADF_DFLT0CR_DFLTACTIVE                       \ DFLT0 active flag This bit is set and cleared by hardware. It indicates if DFLT0 is active: can be running or waiting for events.


\
\ @brief ADF digital filer configuration register 0
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000003 constant ADF_ADF_DFLT0CICR_DATSRC                         \ Source data for the digital filter This field is set and cleared by software. 0x: Stream coming from the BSMX selected Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
$00000070 constant ADF_ADF_DFLT0CICR_CICMOD                         \ Select the CIC order This field is set and cleared by software. It is used to select the order of the MCIC. others: reserved Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
$0000ff00 constant ADF_ADF_DFLT0CICR_MCICD                          \ CIC decimation ratio selection This field is set and cleared by software.It is used to select the CIC decimation ratio. A decimation ratio smaller than two is not allowed. The decimation ratio is given by (CICDEC+1). ... Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
$00010000 constant ADF_ADF_DFLT0CICR_MCICD8                         \ CIC decimation ratio selection This field is set and cleared by software.It is used to select the CIC decimation ratio. A decimation ratio smaller than two is not allowed. The decimation ratio is given by (CICDEC+1). ... Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
$03f00000 constant ADF_ADF_DFLT0CICR_SCALE                          \ Scaling factor selection This field is set and cleared by software. It is used to select the gain to be applied at CIC output (see Table 419 for details). If the application attempts to write a new gain value while the previous one is not yet applied, this new gain value is ignored. Reading back this field informs the application on the current gain value. ... ... others: Reserved


\
\ @brief ADF reshape filter configuration register 0
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant ADF_ADF_DFLT0RSFR_RSFLTBYP                       \ Reshaper filter bypass This bit is set and cleared by software. It is used to bypass the reshape filter and its decimation block. Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
$00000010 constant ADF_ADF_DFLT0RSFR_RSFLTD                         \ Reshaper filter decimation ratio This bit is set and cleared by software. It is used to select the decimation ratio for the reshape filter Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
$00000080 constant ADF_ADF_DFLT0RSFR_HPFBYP                         \ High-pass filter bypass This bit is set and cleared by software. It is used to bypass the high-pass filter. Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
$00000300 constant ADF_ADF_DFLT0RSFR_HPFC                           \ High-pass filter cut-off frequency This field is set and cleared by software. it is used to select the cut-off frequency of the high-pass filter. F<sub>PCM</sub> represents the sampling frequency at HPF input. Note: This field can be write-protected (see Section 46.4.13: Register protection for details).


\
\ @brief ADF delay control register 0
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$0000007f constant ADF_ADF_DLY0CR_SKPDLY                            \ Delay to apply to a bitstream This field is set and cleared by software. It defines the number of input samples that are skipped. Skipping is applied immediately after writing to this field, if SKPBF = 0 and DFLTEN = 1. If SKPBF = 1, the value written into the register is ignored by the delay state machine. ...
$80000000 constant ADF_ADF_DLY0CR_SKPBF                             \ Skip busy flag This bit is set and cleared by hardware. It is used to control if the delay sequence is completed.


\
\ @brief ADF DFLT0 interrupt enable register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000001 constant ADF_ADF_DFLT0IER_FTHIE                           \ RXFIFO threshold interrupt enable This bit is set and cleared by software.
$00000002 constant ADF_ADF_DFLT0IER_DOVRIE                          \ Data overflow interrupt enable This bit is set and cleared by software.
$00000200 constant ADF_ADF_DFLT0IER_SATIE                           \ Saturation detection interrupt enable This bit is set and cleared by software.
$00000400 constant ADF_ADF_DFLT0IER_CKABIE                          \ Clock absence detection interrupt enable This bit is set and cleared by software.
$00000800 constant ADF_ADF_DFLT0IER_RFOVRIE                         \ Reshape filter overrun interrupt enable This bit is set and cleared by software.
$00001000 constant ADF_ADF_DFLT0IER_SDDETIE                         \ Sound activity detection interrupt enable This bit is set and cleared by software.
$00002000 constant ADF_ADF_DFLT0IER_SDLVLIE                         \ SAD sound-level value ready enable This bit is set and cleared by software.


\
\ @brief ADF DFLT0 interrupt status register 0
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000001 constant ADF_ADF_DFLT0ISR_FTHF                            \ RXFIFO threshold flag This bit is set by hardware, and cleared by the hardware when the RXFIFO level is lower than the threshold.
$00000002 constant ADF_ADF_DFLT0ISR_DOVRF                           \ Data overflow flag This bit is set by hardware and cleared by software by writing this bit to 1.
$00000008 constant ADF_ADF_DFLT0ISR_RXNEF                           \ RXFIFO not empty flag This bit is set and cleared by hardware according to the RXFIFO level.
$00000200 constant ADF_ADF_DFLT0ISR_SATF                            \ Saturation detection flag This bit is set by hardware and cleared by software by writing this bit to 1.
$00000400 constant ADF_ADF_DFLT0ISR_CKABF                           \ Clock absence detection flag This bit is set by hardware and cleared by software by writing this bit to 1.
$00000800 constant ADF_ADF_DFLT0ISR_RFOVRF                          \ Reshape filter overrun detection flag This bit is set by hardware and cleared by software by writing this bit to 1.
$00001000 constant ADF_ADF_DFLT0ISR_SDDETF                          \ Sound activity detection flag This bit is set by hardware and cleared by software by writing this bit to 1.
$00002000 constant ADF_ADF_DFLT0ISR_SDLVLF                          \ Sound level value ready flag This bit is set by hardware and cleared by software by writing this bit to 1.


\
\ @brief ADF SAD control register
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$00000001 constant ADF_ADF_SADCR_SADEN                              \ Sound activity detector enable This bit is set and cleared by software. It is used to enable/disable the SAD.
$00000006 constant ADF_ADF_SADCR_DATCAP                             \ Data capture mode This field is set and cleared by software. It is used to define in which conditions, the samples provided by DLFT0 are stored into the memory. 1x: Samples from DFLT0 transfered into memory when SAD and DFLT0 are enabled Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
$00000008 constant ADF_ADF_SADCR_DETCFG                             \ Sound trigger event configuration This bit is set and cleared by software. It is used to define if the sddet_evt event is generated only when the SAD enters to MONITOR state or when the SAD enters or exits the DETECT state. Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
$00000030 constant ADF_ADF_SADCR_SADST                              \ SAD state This field is set and cleared by hardware. It indicates the SAD state and is meaningful only when SADEN = 1. The SAD state can be: - LEARN when the SAD is in learning phase or in SDLVL computation mode - MONITOR when the SAD is in monitoring phase - DETECT when the SAD detects a sound
$00000080 constant ADF_ADF_SADCR_HYSTEN                             \ Hysteresis enable This bit is set and cleared by software. It is used to enable/disable the hysteresis function (see Table 419 for details). This bit must be kept to 0 when SADMOD[1:0] = 1x. Note: This bit can be write-protected (see Section 46.4.13: Register protection for details).
$00000700 constant ADF_ADF_SADCR_FRSIZE                             \ Frame size This field is set and cleared by software. it is used to define the size of one frame and also to define how many samples are taken into account to compute the short-term signal level. 11x: 512 PCM samples used to compute the short-term signal level Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
$00003000 constant ADF_ADF_SADCR_SADMOD                             \ SAD working mode This field is set and cleared by software. It is used to define the way the SAD works. The SAD triggers when the sound level (SDLVL) is bigger than the defined threshold. In this mode, the SAD works like a voice activity detector. The SAD triggers when the sound level (SDLVL) is bigger than the defined threshold. In this mode, the SAD works like a sound detector. 1x: Threshold value given by 4 x ANMIN[12:0] The SAD triggers when the estimated ambient noise (ANLVL), multiplied by the gain selected by SNTHR[3:0] is bigger than the defined threshold. In this mode, the SAD is working like an ambient noise estimator. Hysteresis function cannot be used in this mode. Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
$80000000 constant ADF_ADF_SADCR_SADACTIVE                          \ SAD Active flag This bit is set and cleared by hardware. It is used to check if the SAD is effectively enabled (active) or not. The protected fields and registers of this function can only be updated when the SADACTIVE is set to 0 (see Section 46.4.13: Register protection for details). The delay between a transition on SADEN and a transition on SADACTIVE is two periods of AHB clock and two periods of adf_proc_ck.


\
\ @brief ADF SAD configuration register
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$0000000f constant ADF_ADF_SADCFGR_SNTHR                            \ Signal to noise threshold This field is set and cleared by software. It is used to define THR<sub>H </sub>(and THR<sub>L</sub> if hysteresis is enabled). See Table 419 for details. others: Reserved Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
$00000070 constant ADF_ADF_SADCFGR_ANSLP                            \ Ambient noise slope control This field is set and cleared by software. It is used to define the positive and negative slope of the noise estimator, in charge of updating the ANLVL (see Ambient noise estimation (ANLVL) for information about programming this field). Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
$00000700 constant ADF_ADF_SADCFGR_LFRNB                            \ Number of learning frames This field is set and cleared by software. It is used to define the number of learning frames to perform the first estimate of the noise level. 1xx: 32 frames used to compute the initial noise level Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
$00007000 constant ADF_ADF_SADCFGR_HGOVR                            \ Hangover time window This field is set and cleared by software. Once the SAD state is DETECT, this parameter is used to define the amount of time the sound is allowed to remain below the threshold, before switching the SAD to MONITOR state (see FRSIZE field for the description of a frame). Note: This field can be write-protected (see Section 46.4.13: Register protection for details).
$1fff0000 constant ADF_ADF_SADCFGR_ANMIN                            \ Minimum noise level This field is set and cleared by software. It is used to define the minimum noise level and then the sensitivity. It represents a positive number. Note: This field can be write-protected (see Section 46.4.13: Register protection for details).


\
\ @brief ADF SAD sound level register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00007fff constant ADF_ADF_SADSDLVR_SDLVL                           \ Short term sound level This field is set by hardware. It contains the latest sound level computed by the SAD. To refresh this value, SDLVLF must be cleared.


\
\ @brief ADF SAD ambient noise level register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00007fff constant ADF_ADF_SADANLVR_ANLVL                           \ Ambient noise level estimation This field is set by hardware. It contains the latest ambient noise level computed by the SAD. To refresh this field, the SDLVLF flag must be cleared.


\
\ @brief ADF digital filter data register 0
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$ffffff00 constant ADF_ADF_DFLT0DR_DR                               \ Data processed by DFT0


\
\ @brief Audio digital filter
\
$4002f000 constant ADF_ADF_GCR    \ offset: 0x00 : ADF global control register
$4002f004 constant ADF_ADF_CKGCR  \ offset: 0x04 : ADF clock generator control register
$4002f080 constant ADF_ADF_SITF0CR  \ offset: 0x80 : ADF serial interface control register 0
$4002f084 constant ADF_ADF_BSMX0CR  \ offset: 0x84 : ADF bitstream matrix control register 0
$4002f088 constant ADF_ADF_DFLT0CR  \ offset: 0x88 : ADF digital filter control register 0
$4002f08c constant ADF_ADF_DFLT0CICR  \ offset: 0x8C : ADF digital filer configuration register 0
$4002f090 constant ADF_ADF_DFLT0RSFR  \ offset: 0x90 : ADF reshape filter configuration register 0
$4002f0a4 constant ADF_ADF_DLY0CR  \ offset: 0xA4 : ADF delay control register 0
$4002f0ac constant ADF_ADF_DFLT0IER  \ offset: 0xAC : ADF DFLT0 interrupt enable register
$4002f0b0 constant ADF_ADF_DFLT0ISR  \ offset: 0xB0 : ADF DFLT0 interrupt status register 0
$4002f0b8 constant ADF_ADF_SADCR  \ offset: 0xB8 : ADF SAD control register
$4002f0bc constant ADF_ADF_SADCFGR  \ offset: 0xBC : ADF SAD configuration register
$4002f0c0 constant ADF_ADF_SADSDLVR  \ offset: 0xC0 : ADF SAD sound level register
$4002f0c4 constant ADF_ADF_SADANLVR  \ offset: 0xC4 : ADF SAD ambient noise level register
$4002f0f0 constant ADF_ADF_DFLT0DR  \ offset: 0xF0 : ADF digital filter data register 0

