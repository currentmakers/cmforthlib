\
\ @file spdifrx.fs
\ @brief SPDIF receiver interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SPDIFRX_DEF

  [ifdef] SPDIFRX_SPDIFRX_CR_DEF
    \
    \ @brief SPDIFRX control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_SPDIFRXEN              \ [0x00 : 2] Peripheral block enable<sup>(1)</sup> This field is modified by software. It must be used to change the peripheral phase among the three possible states: STATE_IDLE, STATE_SYNC and STATE_RCV. It is not possible to transition from STATE_RCV to STATE_SYNC, the user must first go the STATE_IDLE. Note: it is possible to transition from STATE_IDLE to STATE_RCV: in that case the peripheral transitions from STATE_IDLE to STATE_SYNC and as soon as the synchronization is performed goes to STATE_RCV.
    $02 constant SPDIFRX_RXDMAEN                \ [0x02] Receiver DMA enable for data flow<sup>(1)</sup> This bit is set/reset by software. Note: When this bit is set, the DMA request is made whenever the RXNE flag is set.
    $03 constant SPDIFRX_RXSTEO                 \ [0x03] Stereo mode<sup>(1)</sup> This bit is set/reset by software. Note: This bit is used in case of overrun situation in order to handle misalignment.
    $04 constant SPDIFRX_DRFMT                  \ [0x04 : 2] RX data format<sup>(1)</sup> This bit is set/reset by software.
    $06 constant SPDIFRX_PMSK                   \ [0x06] Mask parity error bit<sup>(1)</sup> This bit is set/reset by software.
    $07 constant SPDIFRX_VMSK                   \ [0x07] Mask of validity bit<sup>(1)</sup> This bit is set/reset by software.
    $08 constant SPDIFRX_CUMSK                  \ [0x08] Mask of channel status and user bits<sup>(1)</sup> This bit is set/reset by software.
    $09 constant SPDIFRX_PTMSK                  \ [0x09] Mask of preamble type bits<sup>(1)</sup> This bit is set/reset by software.
    $0a constant SPDIFRX_CBDMAEN                \ [0x0a] Control buffer DMA enable for control flow<sup>(1)</sup> This bit is set/reset by software. Note: When this bit is set, the DMA request is made whenever the CSRNE flag is set.
    $0b constant SPDIFRX_CHSEL                  \ [0x0b] Channel selection<sup>(1)</sup> This bit is set/reset by software.
    $0c constant SPDIFRX_NBTR                   \ [0x0c : 2] Maximum allowed re-tries during synchronization phase<sup>(1)</sup>
    $0e constant SPDIFRX_WFA                    \ [0x0e] Wait for activity<sup>(1)</sup> This bit is set/reset by software.
    $10 constant SPDIFRX_INSEL                  \ [0x10 : 3] SPDIFRX input selection other: reserved
    $14 constant SPDIFRX_CKSEN                  \ [0x14] Symbol clock enable This bit is set/reset by software.
    $15 constant SPDIFRX_CKSBKPEN               \ [0x15] Backup symbol clock enable This bit is set/reset by software.
  [then]


  [ifdef] SPDIFRX_SPDIFRX_IMR_DEF
    \
    \ @brief SPDIFRX interrupt mask register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_RXNEIE                 \ [0x00] RXNE interrupt enable This bit is set and cleared by software.
    $01 constant SPDIFRX_CSRNEIE                \ [0x01] Control buffer ready interrupt enable This bit is set and cleared by software.
    $02 constant SPDIFRX_PERRIE                 \ [0x02] Parity error interrupt enable This bit is set and cleared by software.
    $03 constant SPDIFRX_OVRIE                  \ [0x03] Overrun error interrupt enable This bit is set and cleared by software.
    $04 constant SPDIFRX_SBLKIE                 \ [0x04] Synchronization block detected interrupt enable This bit is set and cleared by software.
    $05 constant SPDIFRX_SYNCDIE                \ [0x05] Synchronization done This bit is set and cleared by software.
    $06 constant SPDIFRX_IFEIE                  \ [0x06] Serial interface error interrupt enable This bit is set and cleared by software.
  [then]


  [ifdef] SPDIFRX_SPDIFRX_SR_DEF
    \
    \ @brief SPDIFRX status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_RXNE                   \ [0x00] Read data register not empty This bit is set by hardware when a valid data is available into SPDIFRX_FMTx_DR register. This flag is cleared by reading the SPDIFRX_FMTx_DR register. An interrupt is generated if RXNEIE=1 in the SPDIFRX_IMR register.
    $01 constant SPDIFRX_CSRNE                  \ [0x01] Control buffer register not empty This bit is set by hardware when a valid control information is ready. This flag is cleared when reading SPDIFRX_CSR register. An interrupt is generated if CBRDYIE = 1 in the SPDIFRX_IMR register.
    $02 constant SPDIFRX_PERR                   \ [0x02] Parity error This bit is set by hardware when the data and status bits of the sub-frame received contain an odd number of 0 and 1. This flag is cleared by writing a 1 to its corresponding bit on SPDIFRX_IFCR register. An interrupt is generated if PIE = 1 in the SPDIFRX_IMR register.
    $03 constant SPDIFRX_OVR                    \ [0x03] Overrun error This bit is set by hardware when a received data is ready to be transferred in the SPDIFRX_FMTx_DR register while RXNE = 1 and both SPDIFRX_FMTx_DR and RX_BUF are full. This flag is cleared by writing a 1 to its corresponding bit on SPDIFRX_IFCR register. An interrupt is generated if OVRIE=1 in the SPDIFRX_IMR register. Note: When this bit is set, the SPDIFRX_FMTx_DR register content is not lost but the last data received are.
    $04 constant SPDIFRX_SBD                    \ [0x04] Synchronization block detected This bit is set by hardware when a B preamble is detected. This flag is cleared by writing a 1 to its corresponding bit on SPDIFRX_IFCR register. An interrupt is generated if SBLKIE = 1 in the SPDIFRX_IMR register.
    $05 constant SPDIFRX_SYNCD                  \ [0x05] Synchronization done This bit is set by hardware when the initial synchronization phase is properly completed. This flag is cleared by writing a 1 to its corresponding bit on SPDIFRX_IFCR register. An interrupt is generated if SYNCDIE = 1 in the SPDIFRX_IMR register.
    $06 constant SPDIFRX_FERR                   \ [0x06] Framing error This bit is set by hardware when an error occurs during data reception: such as preamble not at the expected place, short transition not grouped by pairs. This is set by the hardware only if the synchronization is completed (SYNCD = 1). This flag is cleared by writing SPDIFRXEN to 0. An interrupt is generated if IFEIE=1 in the SPDIFRX_IMR register.
    $07 constant SPDIFRX_SERR                   \ [0x07] Synchronization error This bit is set by hardware when the synchronization fails due to amount of re-tries for NBTR. This flag is cleared by writing SPDIFRXEN to 0. An interrupt is generated if IFEIE = 1 in the SPDIFRX_IMR register.
    $08 constant SPDIFRX_TERR                   \ [0x08] Time-out error This bit is set by hardware when the counter TRCNT reaches its max value. It indicates that the time interval between two transitions is too long. It generally indicates that there is no valid signal on SPDIFRX_IN input. This flag is cleared by writing SPDIFRXEN to 0. An interrupt is generated if IFEIE=1 in the SPDIFRX_IMR register.
    $10 constant SPDIFRX_WIDTH5                 \ [0x10 : 15] duration of 5 symbols counted with spdifrx_ker_ck This value represents the amount of spdifrx_ker_ck clock periods contained on a length of 5 consecutive symbols. This value can be used to estimate the S/PDIF symbol rate. Its accuracy is limited by the frequency of spdifrx_ker_ck. For example if the spdifrx_ker_ck is fixed to 84 MHz, and WIDTH5 = 147d. The estimated sampling rate of the S/PDIF stream is: Fs = 5 x F<sub>spdifrx_ker_ck</sub> / (WIDTH5 x 64) ~ 44.6 kHz, so the closest standard sampling rate is 44.1 kHz. Note that WIDTH5 is updated by the hardware when SYNCD goes high, and then every frame.
  [then]


  [ifdef] SPDIFRX_SPDIFRX_IFCR_DEF
    \
    \ @brief SPDIFRX interrupt flag clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $02 constant SPDIFRX_PERRCF                 \ [0x02] clears the parity error flag Writing 1 in this bit clears the flag PERR in the SPDIFRX_SR register. Reading this bit always returns the value 0.
    $03 constant SPDIFRX_OVRCF                  \ [0x03] clears the overrun error flag Writing 1 in this bit clears the flag OVR in the SPDIFRX_SR register. Reading this bit always returns the value 0.
    $04 constant SPDIFRX_SBDCF                  \ [0x04] clears the synchronization block detected flag Writing 1 in this bit clears the flag SBD in the SPDIFRX_SR register. Reading this bit always returns the value 0.
    $05 constant SPDIFRX_SYNCDCF                \ [0x05] clears the synchronization done flag Writing 1 in this bit clears the flag SYNCD in the SPDIFRX_SR register. Reading this bit always returns the value 0.
  [then]


  [ifdef] SPDIFRX_SPDIFRX_FMT0_DR_DEF
    \
    \ @brief SPDIFRX data input register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_DR                     \ [0x00 : 24] data value Contains the 24 received data bits, aligned on D[23]
    $18 constant SPDIFRX_PE                     \ [0x18] parity error bit Contains a copy of PERR bit if PMSK = 0, otherwise it is forced to 0
    $19 constant SPDIFRX_V                      \ [0x19] validity bit Contains the received validity bit if VMSK = 0, otherwise it is forced to 0
    $1a constant SPDIFRX_U                      \ [0x1a] user bit Contains the received user bit, if CUMSK = 0, otherwise it is forced to 0
    $1b constant SPDIFRX_C                      \ [0x1b] channel status bit Contains the received channel status bit, if CUMSK = 0, otherwise it is forced to 0
    $1c constant SPDIFRX_PT                     \ [0x1c : 2] preamble type These bits indicate the preamble received. Note that if PTMSK = 1, this field is forced to zero
  [then]


  [ifdef] SPDIFRX_SPDIFRX_FMT0_DR_alternate1_DEF
    \
    \ @brief SPDIFRX data input register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_PE                     \ [0x00] parity error bit Contains a copy of PERR bit if PMSK = 0, otherwise it is forced to 0
    $01 constant SPDIFRX_V                      \ [0x01] validity bit Contains the received validity bit if VMSK = 0, otherwise it is forced to 0
    $02 constant SPDIFRX_U                      \ [0x02] user bit Contains the received user bit, if CUMSK = 0, otherwise it is forced to 0
    $03 constant SPDIFRX_C                      \ [0x03] channel Status bit Contains the received channel status bit, if CUMSK = 0, otherwise it is forced to 0
    $04 constant SPDIFRX_PT                     \ [0x04 : 2] preamble type These bits indicate the preamble received. Note that if PTMSK = 1, this field is forced to zero
    $08 constant SPDIFRX_DR                     \ [0x08 : 24] data value Contains the 24 received data bits, aligned on D[23]
  [then]


  [ifdef] SPDIFRX_SPDIFRX_FMT0_DR_alternate2_DEF
    \
    \ @brief SPDIFRX data input register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_DRNL1                  \ [0x00 : 16] data value This field contains the channel B
    $10 constant SPDIFRX_DRNL2                  \ [0x10 : 16] data value This field contains the channel A
  [then]


  [ifdef] SPDIFRX_SPDIFRX_CSR_DEF
    \
    \ @brief SPDIFRX channel status register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_USR                    \ [0x00 : 16] user data information Bit USR[0] is the oldest value, and comes from channel A, USR[1] comes channel B. So USR[n] bits come from channel A is n is even, otherwise they come from channel B.
    $10 constant SPDIFRX_CS                     \ [0x10 : 8] channel A status information Bit CS[0] is the oldest value
    $18 constant SPDIFRX_SOB                    \ [0x18] start of block This bit indicates if the bit CS[0] corresponds to the first bit of a new block
  [then]


  [ifdef] SPDIFRX_SPDIFRX_DIR_DEF
    \
    \ @brief SPDIFRX debug information register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_THI                    \ [0x00 : 13] threshold HIGH (THI = 2.5 x UI / T<sub>spdifrx_ker_ck</sub>) This field contains the current threshold HIGH estimation. This value can be used to estimate the sampling rate of the received stream. The accuracy of THI is limited to a period of the spdifrx_ker_ck. The sampling rate can be estimated as follow: Sampling Rate = [2 x THI x T<sub>spdifrx_ker_ck </sub>+/- T<sub>spdifrx_ker_ck</sub>] x 2/5 Note that THI is updated by the hardware when SYNCD goes high, and then every frame.
    $10 constant SPDIFRX_TLO                    \ [0x10 : 13] threshold LOW (TLO = 1.5 x UI / T<sub>spdifrx_ker_ck</sub>) This field contains the current threshold LOW estimation. This value can be used to estimate the sampling rate of the received stream. The accuracy of TLO is limited to a period of the spdifrx_ker_ck. The sampling rate can be estimated as follow: Sampling Rate = [2 x TLO x T<sub>spdifrx_ker_ck </sub>+/- T<sub>spdifrx_ker_ck</sub>] x 2/3 Note that TLO is updated by the hardware when SYNCD goes high, and then every frame.
  [then]

  \
  \ @brief SPDIF receiver interface
  \
  $00 constant SPDIFRX_SPDIFRX_CR       \ SPDIFRX control register
  $04 constant SPDIFRX_SPDIFRX_IMR      \ SPDIFRX interrupt mask register
  $08 constant SPDIFRX_SPDIFRX_SR       \ SPDIFRX status register
  $0C constant SPDIFRX_SPDIFRX_IFCR     \ SPDIFRX interrupt flag clear register
  $10 constant SPDIFRX_SPDIFRX_FMT0_DR  \ SPDIFRX data input register
  $10 constant SPDIFRX_SPDIFRX_FMT0_DR_ALTERNATE1    \ SPDIFRX data input register
  $10 constant SPDIFRX_SPDIFRX_FMT0_DR_ALTERNATE2    \ SPDIFRX data input register
  $14 constant SPDIFRX_SPDIFRX_CSR      \ SPDIFRX channel status register
  $18 constant SPDIFRX_SPDIFRX_DIR      \ SPDIFRX debug information register

: SPDIFRX_DEF ; [then]
