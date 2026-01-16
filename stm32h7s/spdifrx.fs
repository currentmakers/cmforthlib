\
\ @file spdifrx.fs
\ @brief SPDIF receiver interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SPDIFRX control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant SPDIFRX_SPDIFRX_CR_SPDIFRXEN                     \ Peripheral block enable<sup>(1)</sup> This field is modified by software. It must be used to change the peripheral phase among the three possible states: STATE_IDLE, STATE_SYNC and STATE_RCV. It is not possible to transition from STATE_RCV to STATE_SYNC, the user must first go the STATE_IDLE. Note: it is possible to transition from STATE_IDLE to STATE_RCV: in that case the peripheral transitions from STATE_IDLE to STATE_SYNC and as soon as the synchronization is performed goes to STATE_RCV.
$00000004 constant SPDIFRX_SPDIFRX_CR_RXDMAEN                       \ Receiver DMA enable for data flow<sup>(1)</sup> This bit is set/reset by software. Note: When this bit is set, the DMA request is made whenever the RXNE flag is set.
$00000008 constant SPDIFRX_SPDIFRX_CR_RXSTEO                        \ Stereo mode<sup>(1)</sup> This bit is set/reset by software. Note: This bit is used in case of overrun situation in order to handle misalignment.
$00000030 constant SPDIFRX_SPDIFRX_CR_DRFMT                         \ RX data format<sup>(1)</sup> This bit is set/reset by software.
$00000040 constant SPDIFRX_SPDIFRX_CR_PMSK                          \ Mask parity error bit<sup>(1)</sup> This bit is set/reset by software.
$00000080 constant SPDIFRX_SPDIFRX_CR_VMSK                          \ Mask of validity bit<sup>(1)</sup> This bit is set/reset by software.
$00000100 constant SPDIFRX_SPDIFRX_CR_CUMSK                         \ Mask of channel status and user bits<sup>(1)</sup> This bit is set/reset by software.
$00000200 constant SPDIFRX_SPDIFRX_CR_PTMSK                         \ Mask of preamble type bits<sup>(1)</sup> This bit is set/reset by software.
$00000400 constant SPDIFRX_SPDIFRX_CR_CBDMAEN                       \ Control buffer DMA enable for control flow<sup>(1)</sup> This bit is set/reset by software. Note: When this bit is set, the DMA request is made whenever the CSRNE flag is set.
$00000800 constant SPDIFRX_SPDIFRX_CR_CHSEL                         \ Channel selection<sup>(1)</sup> This bit is set/reset by software.
$00003000 constant SPDIFRX_SPDIFRX_CR_NBTR                          \ Maximum allowed re-tries during synchronization phase<sup>(1)</sup>
$00004000 constant SPDIFRX_SPDIFRX_CR_WFA                           \ Wait for activity<sup>(1)</sup> This bit is set/reset by software.
$00070000 constant SPDIFRX_SPDIFRX_CR_INSEL                         \ SPDIFRX input selection other: reserved
$00100000 constant SPDIFRX_SPDIFRX_CR_CKSEN                         \ Symbol clock enable This bit is set/reset by software.
$00200000 constant SPDIFRX_SPDIFRX_CR_CKSBKPEN                      \ Backup symbol clock enable This bit is set/reset by software.


\
\ @brief SPDIFRX interrupt mask register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SPDIFRX_SPDIFRX_IMR_RXNEIE                       \ RXNE interrupt enable This bit is set and cleared by software.
$00000002 constant SPDIFRX_SPDIFRX_IMR_CSRNEIE                      \ Control buffer ready interrupt enable This bit is set and cleared by software.
$00000004 constant SPDIFRX_SPDIFRX_IMR_PERRIE                       \ Parity error interrupt enable This bit is set and cleared by software.
$00000008 constant SPDIFRX_SPDIFRX_IMR_OVRIE                        \ Overrun error interrupt enable This bit is set and cleared by software.
$00000010 constant SPDIFRX_SPDIFRX_IMR_SBLKIE                       \ Synchronization block detected interrupt enable This bit is set and cleared by software.
$00000020 constant SPDIFRX_SPDIFRX_IMR_SYNCDIE                      \ Synchronization done This bit is set and cleared by software.
$00000040 constant SPDIFRX_SPDIFRX_IMR_IFEIE                        \ Serial interface error interrupt enable This bit is set and cleared by software.


\
\ @brief SPDIFRX status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SPDIFRX_SPDIFRX_SR_RXNE                          \ Read data register not empty This bit is set by hardware when a valid data is available into SPDIFRX_FMTx_DR register. This flag is cleared by reading the SPDIFRX_FMTx_DR register. An interrupt is generated if RXNEIE=1 in the SPDIFRX_IMR register.
$00000002 constant SPDIFRX_SPDIFRX_SR_CSRNE                         \ Control buffer register not empty This bit is set by hardware when a valid control information is ready. This flag is cleared when reading SPDIFRX_CSR register. An interrupt is generated if CBRDYIE = 1 in the SPDIFRX_IMR register.
$00000004 constant SPDIFRX_SPDIFRX_SR_PERR                          \ Parity error This bit is set by hardware when the data and status bits of the sub-frame received contain an odd number of 0 and 1. This flag is cleared by writing a 1 to its corresponding bit on SPDIFRX_IFCR register. An interrupt is generated if PIE = 1 in the SPDIFRX_IMR register.
$00000008 constant SPDIFRX_SPDIFRX_SR_OVR                           \ Overrun error This bit is set by hardware when a received data is ready to be transferred in the SPDIFRX_FMTx_DR register while RXNE = 1 and both SPDIFRX_FMTx_DR and RX_BUF are full. This flag is cleared by writing a 1 to its corresponding bit on SPDIFRX_IFCR register. An interrupt is generated if OVRIE=1 in the SPDIFRX_IMR register. Note: When this bit is set, the SPDIFRX_FMTx_DR register content is not lost but the last data received are.
$00000010 constant SPDIFRX_SPDIFRX_SR_SBD                           \ Synchronization block detected This bit is set by hardware when a B preamble is detected. This flag is cleared by writing a 1 to its corresponding bit on SPDIFRX_IFCR register. An interrupt is generated if SBLKIE = 1 in the SPDIFRX_IMR register.
$00000020 constant SPDIFRX_SPDIFRX_SR_SYNCD                         \ Synchronization done This bit is set by hardware when the initial synchronization phase is properly completed. This flag is cleared by writing a 1 to its corresponding bit on SPDIFRX_IFCR register. An interrupt is generated if SYNCDIE = 1 in the SPDIFRX_IMR register.
$00000040 constant SPDIFRX_SPDIFRX_SR_FERR                          \ Framing error This bit is set by hardware when an error occurs during data reception: such as preamble not at the expected place, short transition not grouped by pairs. This is set by the hardware only if the synchronization is completed (SYNCD = 1). This flag is cleared by writing SPDIFRXEN to 0. An interrupt is generated if IFEIE=1 in the SPDIFRX_IMR register.
$00000080 constant SPDIFRX_SPDIFRX_SR_SERR                          \ Synchronization error This bit is set by hardware when the synchronization fails due to amount of re-tries for NBTR. This flag is cleared by writing SPDIFRXEN to 0. An interrupt is generated if IFEIE = 1 in the SPDIFRX_IMR register.
$00000100 constant SPDIFRX_SPDIFRX_SR_TERR                          \ Time-out error This bit is set by hardware when the counter TRCNT reaches its max value. It indicates that the time interval between two transitions is too long. It generally indicates that there is no valid signal on SPDIFRX_IN input. This flag is cleared by writing SPDIFRXEN to 0. An interrupt is generated if IFEIE=1 in the SPDIFRX_IMR register.
$7fff0000 constant SPDIFRX_SPDIFRX_SR_WIDTH5                        \ duration of 5 symbols counted with spdifrx_ker_ck This value represents the amount of spdifrx_ker_ck clock periods contained on a length of 5 consecutive symbols. This value can be used to estimate the S/PDIF symbol rate. Its accuracy is limited by the frequency of spdifrx_ker_ck. For example if the spdifrx_ker_ck is fixed to 84 MHz, and WIDTH5 = 147d. The estimated sampling rate of the S/PDIF stream is: Fs = 5 x F<sub>spdifrx_ker_ck</sub> / (WIDTH5 x 64) ~ 44.6 kHz, so the closest standard sampling rate is 44.1 kHz. Note that WIDTH5 is updated by the hardware when SYNCD goes high, and then every frame.


\
\ @brief SPDIFRX interrupt flag clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000004 constant SPDIFRX_SPDIFRX_IFCR_PERRCF                      \ clears the parity error flag Writing 1 in this bit clears the flag PERR in the SPDIFRX_SR register. Reading this bit always returns the value 0.
$00000008 constant SPDIFRX_SPDIFRX_IFCR_OVRCF                       \ clears the overrun error flag Writing 1 in this bit clears the flag OVR in the SPDIFRX_SR register. Reading this bit always returns the value 0.
$00000010 constant SPDIFRX_SPDIFRX_IFCR_SBDCF                       \ clears the synchronization block detected flag Writing 1 in this bit clears the flag SBD in the SPDIFRX_SR register. Reading this bit always returns the value 0.
$00000020 constant SPDIFRX_SPDIFRX_IFCR_SYNCDCF                     \ clears the synchronization done flag Writing 1 in this bit clears the flag SYNCD in the SPDIFRX_SR register. Reading this bit always returns the value 0.


\
\ @brief SPDIFRX data input register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00ffffff constant SPDIFRX_SPDIFRX_FMT0_DR_DR                       \ data value Contains the 24 received data bits, aligned on D[23]
$01000000 constant SPDIFRX_SPDIFRX_FMT0_DR_PE                       \ parity error bit Contains a copy of PERR bit if PMSK = 0, otherwise it is forced to 0
$02000000 constant SPDIFRX_SPDIFRX_FMT0_DR_V                        \ validity bit Contains the received validity bit if VMSK = 0, otherwise it is forced to 0
$04000000 constant SPDIFRX_SPDIFRX_FMT0_DR_U                        \ user bit Contains the received user bit, if CUMSK = 0, otherwise it is forced to 0
$08000000 constant SPDIFRX_SPDIFRX_FMT0_DR_C                        \ channel status bit Contains the received channel status bit, if CUMSK = 0, otherwise it is forced to 0
$30000000 constant SPDIFRX_SPDIFRX_FMT0_DR_PT                       \ preamble type These bits indicate the preamble received. Note that if PTMSK = 1, this field is forced to zero


\
\ @brief SPDIFRX data input register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SPDIFRX_SPDIFRX_FMT0_DR_ALTERNATE1_PE            \ parity error bit Contains a copy of PERR bit if PMSK = 0, otherwise it is forced to 0
$00000002 constant SPDIFRX_SPDIFRX_FMT0_DR_ALTERNATE1_V             \ validity bit Contains the received validity bit if VMSK = 0, otherwise it is forced to 0
$00000004 constant SPDIFRX_SPDIFRX_FMT0_DR_ALTERNATE1_U             \ user bit Contains the received user bit, if CUMSK = 0, otherwise it is forced to 0
$00000008 constant SPDIFRX_SPDIFRX_FMT0_DR_ALTERNATE1_C             \ channel Status bit Contains the received channel status bit, if CUMSK = 0, otherwise it is forced to 0
$00000030 constant SPDIFRX_SPDIFRX_FMT0_DR_ALTERNATE1_PT            \ preamble type These bits indicate the preamble received. Note that if PTMSK = 1, this field is forced to zero
$ffffff00 constant SPDIFRX_SPDIFRX_FMT0_DR_ALTERNATE1_DR            \ data value Contains the 24 received data bits, aligned on D[23]


\
\ @brief SPDIFRX data input register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant SPDIFRX_SPDIFRX_FMT0_DR_ALTERNATE2_DRNL1         \ data value This field contains the channel B
$ffff0000 constant SPDIFRX_SPDIFRX_FMT0_DR_ALTERNATE2_DRNL2         \ data value This field contains the channel A


\
\ @brief SPDIFRX channel status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant SPDIFRX_SPDIFRX_CSR_USR                          \ user data information Bit USR[0] is the oldest value, and comes from channel A, USR[1] comes channel B. So USR[n] bits come from channel A is n is even, otherwise they come from channel B.
$00ff0000 constant SPDIFRX_SPDIFRX_CSR_CS                           \ channel A status information Bit CS[0] is the oldest value
$01000000 constant SPDIFRX_SPDIFRX_CSR_SOB                          \ start of block This bit indicates if the bit CS[0] corresponds to the first bit of a new block


\
\ @brief SPDIFRX debug information register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00001fff constant SPDIFRX_SPDIFRX_DIR_THI                          \ threshold HIGH (THI = 2.5 x UI / T<sub>spdifrx_ker_ck</sub>) This field contains the current threshold HIGH estimation. This value can be used to estimate the sampling rate of the received stream. The accuracy of THI is limited to a period of the spdifrx_ker_ck. The sampling rate can be estimated as follow: Sampling Rate = [2 x THI x T<sub>spdifrx_ker_ck </sub>+/- T<sub>spdifrx_ker_ck</sub>] x 2/5 Note that THI is updated by the hardware when SYNCD goes high, and then every frame.
$1fff0000 constant SPDIFRX_SPDIFRX_DIR_TLO                          \ threshold LOW (TLO = 1.5 x UI / T<sub>spdifrx_ker_ck</sub>) This field contains the current threshold LOW estimation. This value can be used to estimate the sampling rate of the received stream. The accuracy of TLO is limited to a period of the spdifrx_ker_ck. The sampling rate can be estimated as follow: Sampling Rate = [2 x TLO x T<sub>spdifrx_ker_ck </sub>+/- T<sub>spdifrx_ker_ck</sub>] x 2/3 Note that TLO is updated by the hardware when SYNCD goes high, and then every frame.


\
\ @brief SPDIF receiver interface
\
$40004000 constant SPDIFRX_SPDIFRX_CR  \ offset: 0x00 : SPDIFRX control register
$40004004 constant SPDIFRX_SPDIFRX_IMR  \ offset: 0x04 : SPDIFRX interrupt mask register
$40004008 constant SPDIFRX_SPDIFRX_SR  \ offset: 0x08 : SPDIFRX status register
$4000400c constant SPDIFRX_SPDIFRX_IFCR  \ offset: 0x0C : SPDIFRX interrupt flag clear register
$40004010 constant SPDIFRX_SPDIFRX_FMT0_DR  \ offset: 0x10 : SPDIFRX data input register
$40004010 constant SPDIFRX_SPDIFRX_FMT0_DR_ALTERNATE1  \ offset: 0x10 : SPDIFRX data input register
$40004010 constant SPDIFRX_SPDIFRX_FMT0_DR_ALTERNATE2  \ offset: 0x10 : SPDIFRX data input register
$40004014 constant SPDIFRX_SPDIFRX_CSR  \ offset: 0x14 : SPDIFRX channel status register
$40004018 constant SPDIFRX_SPDIFRX_DIR  \ offset: 0x18 : SPDIFRX debug information register

